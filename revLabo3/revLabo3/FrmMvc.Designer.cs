namespace revLabo3
{
    partial class FrmMvc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMvc));
            System.Windows.Forms.Label empNomLabel;
            this.bDTestDataSet = new revLabo3.BDTestDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new revLabo3.BDTestDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new revLabo3.BDTestDataSetTableAdapters.TableAdapterManager();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.btnModifierNom = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSuspendre = new System.Windows.Forms.Button();
            this.btnReprendre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            empNomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDTestDataSet
            // 
            this.bDTestDataSet.DataSetName = "BDTestDataSet";
            this.bDTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.bDTestDataSet;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = this.employeTableAdapter;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = revLabo3.BDTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // employeBindingNavigator
            // 
            this.employeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeBindingNavigator.BindingSource = this.employeBindingSource;
            this.employeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeBindingNavigatorSaveItem});
            this.employeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeBindingNavigator.Name = "employeBindingNavigator";
            this.employeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeBindingNavigator.Size = new System.Drawing.Size(1016, 27);
            this.employeBindingNavigator.TabIndex = 0;
            this.employeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click_2);
            // 
            // employeDataGridView
            // 
            this.employeDataGridView.AutoGenerateColumns = false;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeDataGridView.DataSource = this.employeBindingSource;
            this.employeDataGridView.Location = new System.Drawing.Point(25, 72);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.RowTemplate.Height = 24;
            this.employeDataGridView.Size = new System.Drawing.Size(955, 220);
            this.employeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "empNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "empPrenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "empPrenom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "empNom";
            this.dataGridViewTextBoxColumn3.HeaderText = "empNom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "empEmploi";
            this.dataGridViewTextBoxColumn4.HeaderText = "empEmploi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "empSal";
            this.dataGridViewTextBoxColumn5.HeaderText = "empSal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "empComm";
            this.dataGridViewTextBoxColumn6.HeaderText = "empComm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empSup";
            this.dataGridViewTextBoxColumn7.HeaderText = "empSup";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "empBureau";
            this.dataGridViewTextBoxColumn8.HeaderText = "empBureau";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Location = new System.Drawing.Point(116, 47);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(72, 17);
            empNomLabel.TabIndex = 2;
            empNomLabel.Text = "emp Nom:";
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(194, 44);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(100, 22);
            this.empNomTextBox.TabIndex = 3;
            // 
            // btnModifierNom
            // 
            this.btnModifierNom.Location = new System.Drawing.Point(376, 41);
            this.btnModifierNom.Name = "btnModifierNom";
            this.btnModifierNom.Size = new System.Drawing.Size(185, 23);
            this.btnModifierNom.TabIndex = 4;
            this.btnModifierNom.Text = "Modifier le Nom";
            this.btnModifierNom.UseVisualStyleBackColor = true;
            this.btnModifierNom.Click += new System.EventHandler(this.btnModifierNom_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(620, 41);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 22);
            this.txtNom.TabIndex = 5;
            // 
            // btnSuspendre
            // 
            this.btnSuspendre.Location = new System.Drawing.Point(28, 298);
            this.btnSuspendre.Name = "btnSuspendre";
            this.btnSuspendre.Size = new System.Drawing.Size(195, 36);
            this.btnSuspendre.TabIndex = 6;
            this.btnSuspendre.Text = "Suspendre la liaison";
            this.btnSuspendre.UseVisualStyleBackColor = true;
            this.btnSuspendre.Click += new System.EventHandler(this.btnSuspendre_Click);
            // 
            // btnReprendre
            // 
            this.btnReprendre.Location = new System.Drawing.Point(229, 298);
            this.btnReprendre.Name = "btnReprendre";
            this.btnReprendre.Size = new System.Drawing.Size(181, 36);
            this.btnReprendre.TabIndex = 7;
            this.btnReprendre.Text = "Reprendre la liaison";
            this.btnReprendre.UseVisualStyleBackColor = true;
            this.btnReprendre.Click += new System.EventHandler(this.btnReprendre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNombre);
            this.panel1.Controls.Add(this.btnPosition);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Location = new System.Drawing.Point(25, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(185, 32);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(154, 36);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "last employe";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 32);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(160, 36);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "first employe";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(351, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(154, 36);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "next employe";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(524, 32);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(154, 36);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "previous employe";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(684, 32);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(154, 36);
            this.btnPosition.TabIndex = 11;
            this.btnPosition.Text = "position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(844, 32);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(141, 36);
            this.btnNombre.TabIndex = 12;
            this.btnNombre.Text = "nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(754, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "delete Employe";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(549, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Employe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 36);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Actualiser Employe Courant";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmMvc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 472);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReprendre);
            this.Controls.Add(this.btnSuspendre);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnModifierNom);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(this.employeDataGridView);
            this.Controls.Add(this.employeBindingNavigator);
            this.Name = "FrmMvc";
            this.Text = "Modele MVC";
            this.Load += new System.EventHandler(this.FrmMvc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDTestDataSet bDTestDataSet;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private BDTestDataSetTableAdapters.employeTableAdapter employeTableAdapter;
        private BDTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.Button btnModifierNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnSuspendre;
        private System.Windows.Forms.Button btnReprendre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}