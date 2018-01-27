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
    public partial class frmAffichageDynamique : Form
    {
        public frmAffichageDynamique()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTestDataSet);

        }

        private void frmAffichageDynamique_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTestDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.contratTableAdapter.Fill(this.bDTestDataSet.contrat);
            // TODO: cette ligne de code charge les données dans la table 'bDTestDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDTestDataSet.employe);

        }

        private void employeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            int noenrigistrement = employeBindingSource.Position;
            int nbreRecord = employeBindingSource.Count;
            if(noenrigistrement>=0 && noenrigistrement < nbreRecord)
            {
                dynamic recordCurrent = employeBindingSource.Current;
                decimal recordSelectionne = recordCurrent["empNo"];
                contratTableAdapter.ClearBeforeFill=true;
                contratTableAdapter.Fill(bDTestDataSet.contrat, recordSelectionne);
            }


        }
    }
}
