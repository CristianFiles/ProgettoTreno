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
        public static List<Biglietto> biglietti = new List<Biglietto>();

        public static List<Vagone> Treno = [];

        FormBiglietto? creatoreBiglietto;

        Vagone? vagoneSelezionato;

        public Vagone? vagoneCorrente;

        
        public Gestore()
        {
            InitializeComponent();
            Carica.Visible = false;
            Treno.Add(new PrimaClasse(24));
            Treno.Add(new SecondaClasse(32));
            Treno.Add(new SecondaClasse(32));
            Treno.Add(new Ristorante(20));
            Treno.Add(new Cuccette(16));
            Treno.Add(new Silenzio(20));
            Treno.Add(new Fumatori(10));
        }
        public void PopulateDataGridView()
        {
            ViewVagoni.Rows.Clear();
            Treno.ForEach(v => ViewVagoni.Rows.Add(new string[] { v.TipoVagone().ToString(), v.passeggeri.ToString() }));
        }


        private void Gestore_Load(object sender, EventArgs e)
        {
            InitListaVagoni(ListaDropVagoni);
            InitListaVagoni(ListaVagoniRim);
            InitListaVagoni(ListaVagoniAtt);
            tipiVagone.Items.Clear();
            foreach (TipiVagone tipo in Enum.GetValues(typeof(TipiVagone)))
                tipiVagone.Items.Add(tipo);
            indexVagone.Maximum = Treno.Count;
            PopulateDataGridView();
        }

        private void MostraBigl_Click(object sender, EventArgs e)
        {
            if (!biglietti.Any())
                biglietti.ForEach(b => MessageBox.Show(b.ToString()));
            else
                MessageBox.Show("Non hai un biglietto!");
        }

        private void CreaBigl_Click(object sender, EventArgs e)
        {
            if (creatoreBiglietto == null || creatoreBiglietto.IsDisposed)
                creatoreBiglietto = new FormBiglietto();
            creatoreBiglietto.Show();
        }

        private void bottoneSali_Click(object sender, EventArgs e)
        {
            int salenti = (int)contPasseggeri.Value;
            if (vagoneSelezionato != null)
            {
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
            int scendenti = (int)contPasseggeri.Value;
            if (vagoneSelezionato != null && !vagoneSelezionato.ClusterScendi(scendenti))
            {
                MessageBox.Show("Non puoi scendere da questo vagone");
            }
            PopulateDataGridView();
        }

        private static void InitListaVagoni(ComboBox box) { box.Items.Clear(); Treno.ForEach(v => { box.Items.Add(v.TipoVagone()); }); }

        private void ElimBiglietto_Click(object sender, EventArgs e)
        {
            if (biglietti != null)
            {
                //Treno[biglietti.vagone].PrimoLibero--;
                biglietti = null;
            }
        }

        private void collegaWifi_Click(object sender, EventArgs e)
        {
            if (vagoneCorrente == null) MessageBox.Show("Compra prima un biglietto");
            else
            {
                if (vagoneCorrente.AccessoWIFI) MessageBox.Show("È stato possibile collegarsi al WiFi");
                else MessageBox.Show("Non è stato possibile collegatsi al WiFi.\nTentare su un altro vagone.");
            }
        }

        private void SpostaUtente_Click(object sender, EventArgs e)
        {
            if (vagoneCorrente == null || biglietti == null) MessageBox.Show("Selezione del vagone o biglietto mancante, riprova!");
            else
            {
                /*
                if (Treno[ListaDropVagoni.SelectedIndex].Accessibile(biglietti))
                {
                    vagoneCorrente = vagoneCorrente.Sposta(Treno[ListaDropVagoni.SelectedIndex]);
                }
                */
                /*else*/ MessageBox.Show("Questo vagone non è accessibile con il tuo biglietto!");
            }
            PopulateDataGridView();
        }

        private void togliVagone_Click(object sender, EventArgs e)
        {
            if (ListaVagoniRim.SelectedIndex != -1)
            {
                Treno.RemoveAt(ListaVagoniRim.SelectedIndex);
                Gestore_Load(sender, e);
            }
            else MessageBox.Show("Vagone non selezionato!");
        }

        private void mettiVagone_Click(object sender, EventArgs e)
        {
            int posti = (int)nPostiCounter.Value;
            Vagone vagone = tipiVagone.SelectedIndex switch
            {
                0 => new PrimaClasse(posti),
                1 => new SecondaClasse(posti),
                2 => new Cuccette(posti),
                3 => new Silenzio(posti),
                4 => new Ristorante(posti),
                5 => new Fumatori(posti),
                _ => new SecondaClasse(posti),
            };
            Treno.Insert((int)indexVagone.Value, vagone);
            Gestore_Load(sender, e);
        }

        async private void PresaBtn_Click(object sender, EventArgs e)
        {
            if (vagoneCorrente == null) MessageBox.Show("Compra prima un biglietto");
            else
            {
                if (vagoneCorrente.Caricatori)
                {
                    Carica.Visible = true;
                    await Task.Delay(1000);
                    Carica.Visible = false;
                }
                else MessageBox.Show("Non ci sono prese.\nProvare su un altro vagone.");
            }
        }

        private void spostaTanti_Click(object sender, EventArgs e)
        {
            if (vagoneSelezionato != null)
                MessageBox.Show(vagoneSelezionato.ClusterSposta(Treno[ListaVagoniAtt.SelectedIndex], (int)nSpostati.Value).ToString());
            Gestore_Load(sender, e);
        }
    }
}

