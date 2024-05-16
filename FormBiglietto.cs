using System.Windows.Forms;
using System;
using static ProgettoTreno.Gestore;
using System.Diagnostics;
namespace ProgettoTreno
{
    /*Ciao
     


    ciao*/

    public partial class FormBiglietto : Form
    {
        public FormBiglietto()
        {
            InitializeComponent();
            InitTipiBiglietti();
        }
        private void InitTipiBiglietti()
        {
            foreach (string tipo in Biglietto.Tipi.Values)
                TipiBiglietti.Items.Add(tipo);
            foreach (string destinazione in Biglietto.Destinazione.Values)
                dest.Items.Add(destinazione);
        }

        private void NuovoBiglietto_Click(object sender, EventArgs e)
        {
            if (TipiBiglietti.SelectedItem != null && dest.SelectedItem != null)
            {
                #pragma warning disable CS8604 // Possibile argomento di riferimento Null.
                biglietti.Add(new Biglietto(TipiBiglietti.SelectedItem.ToString(), dest.SelectedItem.ToString(), Treno, passeggero.Text));
                MessageBox.Show(biglietti.ToString());
            }
            else if (TipiBiglietti.SelectedItem == null)
                MessageBox.Show("Seleziona un tipo di biglietto!");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.gestore.IsDisposed)
                Program.gestore.PopulateDataGridView();
        }

        private void FormBiglietto_Load(object sender, EventArgs e)
        {
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            if(TipiBiglietti.SelectedItem == null || dest.SelectedItem == null || passeggero.Text == "" || nBiglietti.Value == 0)
                NuovoBiglietto.Enabled = false;
            else
                NuovoBiglietto.Enabled = true;
        }
    }
}
