using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoTreno
{
    public partial class Gestore : Form
    {
        public static Biglietteria biglietteria = new Biglietteria();

        public static Biglietto? biglietto;

        public static List<Vagone> Treno = new List<Vagone>();

        Form1? creatore;

        Vagone? vagoneSelezionato;

        public Gestore()
        {
            InitializeComponent();
            Treno.Add(new PrimaClasse(24));
            Treno.Add(new SecondaClasse(32));
            Treno.Add(new SecondaClasse(32));
            Treno.Add(new Ristorante(20));
            Treno.Add(new Cuccette(16));
            Treno.Add(new Silenzio(20));
            Treno.Add(new Fumatori(10));
            PopulateDataGridView();
        }
        public void PopulateDataGridView()
        {
            ViewVagoni.Rows.Clear();
            Treno.ForEach(v => ViewVagoni.Rows.Add(new string[] { v.TipoVagone(), v.passeggeri.ToString() }));
        }


        private void Gestore_Load(object sender, EventArgs e)
        {

        }

        private void MostraBigl_Click(object sender, EventArgs e)
        {
            if (biglietto != null)
                MessageBox.Show(biglietto.ToString());
            else
                MessageBox.Show("Non hai un biglietto!");
        }

        private void CreaBigl_Click(object sender, EventArgs e)
        {
            if (creatore == null || creatore.IsDisposed)
                creatore = new Form1();
            creatore.Show();
        }
        
        private void bottoneSali_Click(object sender, EventArgs e)
        {
            int salenti = (int)contPasseggeri.Value;
            if (vagoneSelezionato != null) {
                salenti = vagoneSelezionato.ClusterSali(salenti);
                if (salenti > 0)
                {
                    Treno.ForEach(v =>
                    {
                        if (v.TipoVagone() == vagoneSelezionato.TipoVagone())
                        {
                            salenti = v.ClusterSali(salenti);
                        }
                    });
                }
            }
            else
                MessageBox.Show("Seleziona un vagone nella lista sottostante!");
            PopulateDataGridView();
            MessageBox.Show("Non saliti: " + salenti);
        }


        private void ViewVagoni_CellContentClick(object sender, DataGridViewCellEventArgs e) => vagoneSelezionato = Treno.ElementAt(e.RowIndex);
   
        private void scendiBottone_Click(object sender, EventArgs e)
        {
            int scendenti=(int)contPasseggeri.Value;
            if (vagoneSelezionato != null && !vagoneSelezionato.ClusterScendi(scendenti)) 
            {
                MessageBox.Show("Non puoi scendere da questo vagone");
            }
            PopulateDataGridView();
        }
    }

}
//TODO: funzione sposta e cluster sposta, un bel tentativo di accesso al WIFI, funzione che permette di rimuovere il biglietto e quindi farne un altro
