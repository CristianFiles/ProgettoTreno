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

        private void NuovoBiglietto_Click(object sender, EventArgs e)
        {
            DateTime dataora = DateTime.Now;
            if (biglietto == null)
            {
                biglietto = biglietteria.CreaBiglietto(TipiBiglietti.SelectedIndex, Treno);
                MessageBox.Show("tipo biglietto: " + biglietto.tipoBiglietto + "\ndata e ora: " + dataora + "\nnumero vagone: "+(biglietto.vagone+1)+"\nnumero posto: "+(biglietto.posto+1));

            }
            else
            {
                MessageBox.Show("Hai già acquistato un biglietto!");
            }
        }
    }
}
