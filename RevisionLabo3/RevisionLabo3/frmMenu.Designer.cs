namespace RevisionLabo3
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lABO3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELEMVCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lABO3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lABO3ToolStripMenuItem
            // 
            this.lABO3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODELEMVCToolStripMenuItem,
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem});
            this.lABO3ToolStripMenuItem.Name = "lABO3ToolStripMenuItem";
            this.lABO3ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.lABO3ToolStripMenuItem.Text = "LABO3";
            // 
            // mODELEMVCToolStripMenuItem
            // 
            this.mODELEMVCToolStripMenuItem.Name = "mODELEMVCToolStripMenuItem";
            this.mODELEMVCToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.mODELEMVCToolStripMenuItem.Text = "MODELE MVC";
            this.mODELEMVCToolStripMenuItem.Click += new System.EventHandler(this.mODELEMVCToolStripMenuItem_Click);
            // 
            // cHARGEMENTDYNAMIQUEToolStripMenuItem
            // 
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem.Name = "cHARGEMENTDYNAMIQUEToolStripMenuItem";
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem.Text = "CHARGEMENT DYNAMIQUE";
            this.cHARGEMENTDYNAMIQUEToolStripMenuItem.Click += new System.EventHandler(this.cHARGEMENTDYNAMIQUEToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lABO3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODELEMVCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHARGEMENTDYNAMIQUEToolStripMenuItem;
    }
}

