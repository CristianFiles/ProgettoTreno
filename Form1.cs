using System.Windows.Forms;
using System;

namespace ProgettoTreno
{
    public partial class Form1 : Form
    {
        public static Biglietteria biglietteria = new Biglietteria();

        public Biglietto? biglietto;

        public List<Vagone> Treno = new List<Vagone>();
        public Form1()
        {
            InitializeComponent();
            InitTipiBiglietti();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Treno.Add(new PrimaClasse(24));
            Treno.Add(new SecondaClasse(32));
            Treno.Add(new Ristorante(20));
            Treno.Add(new Cuccette(16));
            Treno.Add(new Silenzio(20));
            Treno.Add(new Fumatori(10));
        }
        private void InitTipiBiglietti() //Cosi da utilizzare i valori dell'enum per il tipo dei biglietti
        {
            foreach(Biglietto.Tipi tipo in Enum.GetValues(typeof(Biglietto.Tipi)))
                TipiBiglietti.Items.Add(tipo);
        }

        private void NuovoBiglietto_Click(object sender, EventArgs e)
        {
            DateTime dataora = DateTime.Now;
            if (biglietto == null && TipiBiglietti.SelectedItem != null)
            {
                biglietto = biglietteria.CreaBiglietto((Biglietto.Tipi)TipiBiglietti.SelectedItem, Treno);
                MessageBox.Show("Tipo biglietto: " + biglietto.tipoBiglietto + "\nData e ora: " + dataora.ToString("dd/MM/yyyy HH:mm") + "\nNumero vagone: " + (biglietto.vagone + 1) + "\nNumero posto: " + (biglietto.posto + 1));
                
            }
            else if (TipiBiglietti.SelectedItem == null)
                MessageBox.Show("Seleziona un tipo di biglietto!");
            else
                MessageBox.Show("Hai già aquistato un biglietto!");
        }
    }
}
