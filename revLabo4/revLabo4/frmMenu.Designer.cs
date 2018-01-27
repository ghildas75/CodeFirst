namespace revLabo4
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
            this.labo4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageParProgrammationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDeVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labo4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labo4ToolStripMenuItem
            // 
            this.labo4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageParProgrammationToolStripMenuItem,
            this.reservationDeVoyagesToolStripMenuItem});
            this.labo4ToolStripMenuItem.Name = "labo4ToolStripMenuItem";
            this.labo4ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.labo4ToolStripMenuItem.Text = "Labo4";
            // 
            // affichageParProgrammationToolStripMenuItem
            // 
            this.affichageParProgrammationToolStripMenuItem.Name = "affichageParProgrammationToolStripMenuItem";
            this.affichageParProgrammationToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.affichageParProgrammationToolStripMenuItem.Text = "Affichage par programmation";
            this.affichageParProgrammationToolStripMenuItem.Click += new System.EventHandler(this.affichageParProgrammationToolStripMenuItem_Click);
            // 
            // reservationDeVoyagesToolStripMenuItem
            // 
            this.reservationDeVoyagesToolStripMenuItem.Name = "reservationDeVoyagesToolStripMenuItem";
            this.reservationDeVoyagesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.reservationDeVoyagesToolStripMenuItem.Text = "Reservation de voyages";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labo4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageParProgrammationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationDeVoyagesToolStripMenuItem;
    }
}

