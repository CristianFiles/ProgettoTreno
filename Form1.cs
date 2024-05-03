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

        private void button1_Click(object sender, EventArgs e)
        {
            biglietto = biglietteria.CreaBiglietto();
        }
        
    }
}
