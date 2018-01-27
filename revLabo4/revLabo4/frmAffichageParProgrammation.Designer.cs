namespace revLabo4
{
    partial class frmAffichageParProgrammation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfficherEmployes = new System.Windows.Forms.Button();
            this.lstEmploye = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAfficherEmployes
            // 
            this.btnAfficherEmployes.Location = new System.Drawing.Point(12, 27);
            this.btnAfficherEmployes.Name = "btnAfficherEmployes";
            this.btnAfficherEmployes.Size = new System.Drawing.Size(248, 23);
            this.btnAfficherEmployes.TabIndex = 0;
            this.btnAfficherEmployes.Text = "Afficher les Employés";
            this.btnAfficherEmployes.UseVisualStyleBackColor = true;
            this.btnAfficherEmployes.Click += new System.EventHandler(this.btnAfficherEmployes_Click);
            // 
            // lstEmploye
            // 
            this.lstEmploye.FormattingEnabled = true;
            this.lstEmploye.ItemHeight = 16;
            this.lstEmploye.Location = new System.Drawing.Point(-2, 79);
            this.lstEmploye.Name = "lstEmploye";
            this.lstEmploye.Size = new System.Drawing.Size(286, 180);
            this.lstEmploye.TabIndex = 1;
            this.lstEmploye.SelectedIndexChanged += new System.EventHandler(this.lstEmploye_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(290, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 180);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmAffichageParProgrammation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 255);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstEmploye);
            this.Controls.Add(this.btnAfficherEmployes);
            this.Name = "frmAffichageParProgrammation";
            this.Text = "Affichage Par Programmation";
            this.Load += new System.EventHandler(this.frmAffichageParProgrammation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherEmployes;
        private System.Windows.Forms.ListBox lstEmploye;
        private System.Windows.Forms.ListBox listBox1;
    }
}