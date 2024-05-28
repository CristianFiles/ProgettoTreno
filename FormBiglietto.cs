using System.Windows.Forms;
using System;
using static ProgettoTreno.Gestore;
using System.Diagnostics;
using System.Configuration;
using System.Numerics;
namespace ProgettoTreno
{
    public partial class FormBiglietto : Form
    {
        public FormBiglietto()
        {
            InitializeComponent();
            InitTipiBiglietti();
            FormBiglietto_Load(null, null);
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
                Biglietto? bigl = Biglietto.creaBiglietto(TipiBiglietti.SelectedItem.ToString(), dest.SelectedItem.ToString(), Treno, passeggero.Text);
                #pragma warning restore CS8604 // Possibile argomento di riferimento Null.
                if (bigl != null)
                {
                    biglietti.Add(bigl);
                    LabelBiglietti.Text = "Numero biglietti: " + biglietti.Count;
                }
                //biglietti.ForEach(b => MessageBox.Show(b.ToString()));
            }
            else MessageBox.Show("Valori inseriti non validi!");
            FormBiglietto_Load(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.gestore.IsDisposed)
                Program.gestore.PopulateDataGridView();
            biglietti.ForEach(b => MessageBox.Show(b.ToString()));
            Hide();
            e.Cancel = true;

        }

        private void loop_Tick(object sender, EventArgs e)
        {
            if (TipiBiglietti.SelectedItem == null || dest.SelectedItem == null || passeggero.Text == "")
                NuovoBiglietto.Enabled = false;
            else
                NuovoBiglietto.Enabled = true;
        }

        public void FormBiglietto_Load(object? sender, EventArgs? e)
        {
            if (biglietti.Count != 0)
            {
                TipiBiglietti.Enabled = false;
                dest.Enabled = false;
            }
            else
            {
                TipiBiglietti.Enabled = true;
                dest.Enabled = true;
            }

            LabelBiglietti.Text = "Numero biglietti: " + biglietti.Count;
        }
    }
}
