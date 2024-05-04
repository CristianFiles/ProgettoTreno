namespace ProgettoTreno
{
    public partial class Form1 : Form
    {
        public static Biglietteria biglietteria = new Biglietteria();

        public Biglietto? biglietto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void NuovoBiglietto_Click(object sender, EventArgs e)
        {
            if (biglietto == null)
                biglietto = biglietteria.CreaBiglietto(TipiBiglietti.SelectedIndex);
            else 
            {
                MessageBox.Show("Hai già acquistato un biglietto!");

            }
        }
        
    }
}
