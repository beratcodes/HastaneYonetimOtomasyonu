using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmhastagiris = new FrmHastaGiris();
            frmhastagiris.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktorgiris = new FrmDoktorGiris();  
            doktorgiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sekretergiris = new FrmSekreterGiris();
            sekretergiris.Show();
            this.Hide();
        }
    }
}
