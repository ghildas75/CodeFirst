namespace RevisionLabo3
{
    partial class frmMVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMVC));
            System.Windows.Forms.Label empNoLabel;
            this.bDTestDataSet = new RevisionLabo3.BDTestDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new RevisionLabo3.BDTestDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new RevisionLabo3.BDTestDataSetTableAdapters.TableAdapterManager();
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnModifyName = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnReprendre = new System.Windows.Forms.Button();
            this.btnSuspendre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnNombreEmploye = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSuppEcurrent = new System.Windows.Forms.Button();
            empNoLabel = new System.Windows.Forms.Label();
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
            this.tableAdapterManager.UpdateOrder = RevisionLabo3.BDTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.employeBindingNavigator.Size = new System.Drawing.Size(968, 27);
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
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click);
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
            this.employeDataGridView.Location = new System.Drawing.Point(0, 116);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.RowTemplate.Height = 24;
            this.employeDataGridView.Size = new System.Drawing.Size(909, 220);
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
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Location = new System.Drawing.Point(169, 85);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new System.Drawing.Size(61, 17);
            empNoLabel.TabIndex = 2;
            empNoLabel.Text = "emp No:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNo", true));
            this.txtNom.Location = new System.Drawing.Point(261, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 3;
            // 
            // btnModifyName
            // 
            this.btnModifyName.Location = new System.Drawing.Point(560, 77);
            this.btnModifyName.Name = "btnModifyName";
            this.btnModifyName.Size = new System.Drawing.Size(195, 23);
            this.btnModifyName.TabIndex = 4;
            this.btnModifyName.Text = "MODIFY NAME";
            this.btnModifyName.UseVisualStyleBackColor = true;
            this.btnModifyName.Click += new System.EventHandler(this.btnModifyName_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(422, 78);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 5;
            // 
            // btnReprendre
            // 
            this.btnReprendre.Location = new System.Drawing.Point(783, 30);
            this.btnReprendre.Name = "btnReprendre";
            this.btnReprendre.Size = new System.Drawing.Size(173, 23);
            this.btnReprendre.TabIndex = 6;
            this.btnReprendre.Text = "reprendre liaison";
            this.btnReprendre.UseVisualStyleBackColor = true;
            this.btnReprendre.Click += new System.EventHandler(this.btnReprendre_Click);
            // 
            // btnSuspendre
            // 
            this.btnSuspendre.Location = new System.Drawing.Point(599, 30);
            this.btnSuspendre.Name = "btnSuspendre";
            this.btnSuspendre.Size = new System.Drawing.Size(156, 23);
            this.btnSuspendre.TabIndex = 7;
            this.btnSuspendre.Text = "Suspendre liaison";
            this.btnSuspendre.UseVisualStyleBackColor = true;
            this.btnSuspendre.Click += new System.EventHandler(this.btnSuspendre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNombreEmploye);
            this.panel1.Controls.Add(this.btnPosition);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 117);
            this.panel1.TabIndex = 8;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 23);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(140, 43);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First Employe";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(172, 23);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(140, 43);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "PREV Employe";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(329, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 43);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Employe";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(492, 23);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(140, 43);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last Employe";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(653, 23);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(140, 43);
            this.btnPosition.TabIndex = 4;
            this.btnPosition.Text = "position Employe";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnNombreEmploye
            // 
            this.btnNombreEmploye.Location = new System.Drawing.Point(816, 23);
            this.btnNombreEmploye.Name = "btnNombreEmploye";
            this.btnNombreEmploye.Size = new System.Drawing.Size(140, 43);
            this.btnNombreEmploye.TabIndex = 5;
            this.btnNombreEmploye.Text = "nombre Employe";
            this.btnNombreEmploye.UseVisualStyleBackColor = true;
            this.btnNombreEmploye.Click += new System.EventHandler(this.btnNombreEmploye_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update eCurrent";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Employe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSuppEcurrent
            // 
            this.btnSuppEcurrent.Location = new System.Drawing.Point(366, 43);
            this.btnSuppEcurrent.Name = "btnSuppEcurrent";
            this.btnSuppEcurrent.Size = new System.Drawing.Size(156, 23);
            this.btnSuppEcurrent.TabIndex = 11;
            this.btnSuppEcurrent.Text = "delete Ecurrent";
            this.btnSuppEcurrent.UseVisualStyleBackColor = true;
            this.btnSuppEcurrent.Click += new System.EventHandler(this.btnSuppEcurrent_Click);
            // 
            // frmMVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 409);
            this.Controls.Add(this.btnSuppEcurrent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSuspendre);
            this.Controls.Add(this.btnReprendre);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnModifyName);
            this.Controls.Add(empNoLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.employeDataGridView);
            this.Controls.Add(this.employeBindingNavigator);
            this.Name = "frmMVC";
            this.Text = "frmMVC";
            this.Load += new System.EventHandler(this.frmMVC_Load);
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
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnModifyName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnReprendre;
        private System.Windows.Forms.Button btnSuspendre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnNombreEmploye;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSuppEcurrent;
    }
}