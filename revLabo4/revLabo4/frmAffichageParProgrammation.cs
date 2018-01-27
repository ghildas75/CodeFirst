using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace revLabo4
{
    public partial class frmAffichageParProgrammation : Form
    {
        string machaine = @"Data Source=E5550-FC-05;Initial Catalog=BDTest;Integrated Security=True;Pooling=False";
        SqlConnection myConnect = new SqlConnection();
        DataSet ds = new DataSet();
        public frmAffichageParProgrammation()
        {
            InitializeComponent();
        }

        private void frmAffichageParProgrammation_Load(object sender, EventArgs e)
        {

        }

        private void btnAfficherEmployes_Click(object sender, EventArgs e)
        {
            myConnect.ConnectionString = machaine;
           string  myrequest = "select empPrenom,empNom from employe";
            SqlDataAdapter dataAdapterEmploye = new SqlDataAdapter(myrequest, myConnect);
            if(ds.Tables.Contains("prenomNomEmploye"))
             ds.Tables.Remove("prenomEmploye");
                dataAdapterEmploye.Fill(ds, "prenomNomEmploye");
           if(ds.Tables["prenomNomEmploye"].Rows.Count==0)
            {
                MessageBox.Show("LA TABLE EST VIDE");
            }
            else
            {
                foreach (DataRow  ligneEmploye in ds.Tables["prenomNomEmploye"].Rows)
                {
                    string prenomNomEmploye = ligneEmploye["empPrenom"] + " " + ligneEmploye["empNom"];
                    lstEmploye.Items.Add(prenomNomEmploye);
                }
            }
        }

        private void lstEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            myConnect.ConnectionString = machaine;
            int indiceSelection = lstEmploye.SelectedIndex;
            DataRow ligneEmploye = ds.Tables["prenomNomEmploye"].Rows[indiceSelection];
            string prenom = ligneEmploye["empPrenom"].ToString();
            string nom = ligneEmploye["empNom"].ToString();
            string mysql = "select conNo from contrat,employe where contrat.empNo=employe.empNo and empPrenom=@prenom and empNom=@nom";
            SqlParameter prenomEmploye = new SqlParameter("@prenom", prenom);
            SqlParameter nomEmploye = new SqlParameter("@nom", nom);
            SqlDataAdapter dataAdapterContrat = new SqlDataAdapter(mysql, myConnect);
            dataAdapterContrat.SelectCommand.Parameters.Add(prenomEmploye);
            dataAdapterContrat.SelectCommand.Parameters.Add(nomEmploye);
            //dataAdapterContrat.Fill(ds, "contratEmploye");
            if (dataAdapterContrat == null)
            {
                listBox1.Items.Add("aucun contrat");
                //MessageBox.Show("aucun contrat");
            }
            if (ds.Tables.Contains("contratEmploye"))
            {
                ds.Tables.Remove("contratEmploye");
            }
            //dataAdapterContrat.Fill(ds,"contratEmploye");
            dataAdapterContrat.Fill(ds,"contratEmploye");
            if (ds.Tables["contratEmploye"].Rows.Count== 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add( "Aucun contrat");
            }
            else
            {
                listBox1.Items.Clear();
                foreach (DataRow ligneContrat in ds.Tables["contratEmploye"].Rows)
                {
                    string contratNumber = ligneContrat["conNo"] + "  ";
                    listBox1.Items.Add(contratNumber);
                }
               
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
