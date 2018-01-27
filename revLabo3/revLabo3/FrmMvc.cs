using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revLabo3
{
    public partial class FrmMvc : Form
    {
        public FrmMvc()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTestDataSet);

        }

        private void employeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTestDataSet);

        }

        private void employeBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTestDataSet);

        }

        private void FrmMvc_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTestDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDTestDataSet.employe);

        }

        private void btnModifierNom_Click(object sender, EventArgs e)
        {
            bDTestDataSet.employe[0].empNom = txtNom.Text;
        }

        private void btnSuspendre_Click(object sender, EventArgs e)
        {
            employeBindingSource.SuspendBinding();
            this.btnSuspendre.Enabled = false;
            this.btnReprendre.Enabled = true;
        }

        private void btnReprendre_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResumeBinding();
            this.btnReprendre.Enabled = false;
            this.btnSuspendre.Enabled = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            employeBindingSource.MovePrevious();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("position employe" + employeBindingSource.Position);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("position employe" + employeBindingSource.Count);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResetCurrentItem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employeBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employeBindingSource.RemoveCurrent();      
                }
    }
}
