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

        Form1 creatore;
        public Gestore()
        {
            InitializeComponent();
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
            if(creatore == null || creatore.IsDisposed)
                creatore = new Form1();
            creatore.Show();
        }
    }
}
