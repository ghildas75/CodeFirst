using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionLabo3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mODELEMVCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMVC().ShowDialog();
            this.Show();
        }

        private void cHARGEMENTDYNAMIQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDynamique().ShowDialog();
            this.Show();
        }
    }
}
