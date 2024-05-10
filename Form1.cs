using System.Windows.Forms;
using System;
using static ProgettoTreno.Gestore;
namespace ProgettoTreno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitTipiBiglietti();
        }
        private void InitTipiBiglietti()
        {
            foreach (Biglietto.Tipi tipo in Enum.GetValues(typeof(Biglietto.Tipi)))
                TipiBiglietti.Items.Add(tipo);
            foreach (Biglietto.Destinazione destinazione in Enum.GetValues(typeof(Biglietto.Destinazione)))
                dest.Items.Add(destinazione);
        }

        private void NuovoBiglietto_Click(object sender, EventArgs e)
        {
            if (biglietto == null && TipiBiglietti.SelectedItem != null && dest.SelectedItem != null)
            {
                biglietto = biglietteria.CreaBiglietto((Biglietto.Tipi)TipiBiglietti.SelectedItem, (Biglietto.Destinazione)dest.SelectedItem, Treno, passeggero.Text);
                MessageBox.Show(biglietto.ToString());
            }
            else if (TipiBiglietti.SelectedItem == null)
                MessageBox.Show("Seleziona un tipo di biglietto!");
            else
                MessageBox.Show("Hai già aquistato un biglietto!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.gestore.PopulateDataGridView();
        }
    }
}
