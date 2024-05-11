using System.Windows.Forms;
using System;
using static ProgettoTreno.Gestore;
namespace ProgettoTreno
{
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
            if (biglietto == null && TipiBiglietti.SelectedItem != null && dest.SelectedItem != null)
            {
                #pragma warning disable CS8604 // Possibile argomento di riferimento Null.
                biglietto = biglietteria.CreaBiglietto(TipiBiglietti.SelectedItem.ToString(), dest.SelectedItem.ToString(), Treno, passeggero.Text);
                MessageBox.Show(biglietto.ToString());
            }
            else if (TipiBiglietti.SelectedItem == null)
                MessageBox.Show("Seleziona un tipo di biglietto!");
            else
                MessageBox.Show("Hai già aquistato un biglietto!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Program.gestore.IsDisposed)
                Program.gestore.PopulateDataGridView();
        }

        private void FormBiglietto_Load(object sender, EventArgs e)
        {
        }
    }
}
