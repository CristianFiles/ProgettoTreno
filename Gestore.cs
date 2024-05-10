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
        private void PopulateDataGridView() => Treno.ForEach(v => ViewVagoni.Rows.Add(new string[] { v.TipoVagone(), v.passeggeri.ToString() }));

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

        private void button1_Click(object sender, EventArgs e)
        {
            int salenti = (int)saliBtn.Value;
            if (salenti > 0)
            {
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    } 

}
