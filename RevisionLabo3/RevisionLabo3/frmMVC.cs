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
    public partial class frmMVC : Form
    {
        public frmMVC()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTestDataSet);

        }

        private void frmMVC_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTestDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDTestDataSet.employe);

        }

        private void btnModifyName_Click(object sender, EventArgs e)
        {
            bDTestDataSet.employe[0].empNom = txtBoxName.Text;
        }

        private void btnReprendre_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResumeBinding();
            this.btnReprendre.Enabled = false;
            this.btnSuspendre.Enabled = true;
        }

        private void btnSuspendre_Click(object sender, EventArgs e)
        {
            employeBindingSource.SuspendBinding();
            this.btnSuspendre.Enabled = false;
            this.btnReprendre.Enabled = true;
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            employeBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveNext();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveLast();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("position Employe" + employeBindingSource.Position);

        }

        private void btnNombreEmploye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nombre Employe" + employeBindingSource.Count);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResetCurrentItem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employeBindingSource.AddNew();
        }

        private void btnSuppEcurrent_Click(object sender, EventArgs e)
        {
            employeBindingSource.RemoveCurrent();
        }
    }
}
