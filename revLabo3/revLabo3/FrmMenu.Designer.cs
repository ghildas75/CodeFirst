namespace revLabo3
{
    partial class FrmMenu
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
            this.labo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeleMvcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargementDynamiqueDesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labo3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labo3ToolStripMenuItem
            // 
            this.labo3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeleMvcToolStripMenuItem,
            this.chargementDynamiqueDesDonnéesToolStripMenuItem});
            this.labo3ToolStripMenuItem.Name = "labo3ToolStripMenuItem";
            this.labo3ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.labo3ToolStripMenuItem.Text = "Labo3";
            // 
            // modeleMvcToolStripMenuItem
            // 
            this.modeleMvcToolStripMenuItem.Name = "modeleMvcToolStripMenuItem";
            this.modeleMvcToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.modeleMvcToolStripMenuItem.Text = "Modele Mvc";
            this.modeleMvcToolStripMenuItem.Click += new System.EventHandler(this.modeleMvcToolStripMenuItem_Click);
            // 
            // chargementDynamiqueDesDonnéesToolStripMenuItem
            // 
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Name = "chargementDynamiqueDesDonnéesToolStripMenuItem";
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Text = "Chargement dynamique des données";
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Click += new System.EventHandler(this.chargementDynamiqueDesDonnéesToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "MenuGhilas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeleMvcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargementDynamiqueDesDonnéesToolStripMenuItem;
    }
}

