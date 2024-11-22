namespace CheckDrivers
{
    partial class InsertVision
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
            System.Windows.Forms.Label driver_NameLabel;
            System.Windows.Forms.Label driver_VersionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertVision));
            this.buttonBackVision = new System.Windows.Forms.Button();
            this.dataCDDataSet = new CheckDrivers.dataCDDataSet();
            this.tableVisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableVisionTableAdapter = new CheckDrivers.dataCDDataSetTableAdapters.TableVisionTableAdapter();
            this.tableAdapterManager = new CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager();
            this.tableVisionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableVisionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.driver_NameTextBox = new System.Windows.Forms.TextBox();
            this.driver_VersionTextBox = new System.Windows.Forms.TextBox();
            this.tableVisionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            driver_NameLabel = new System.Windows.Forms.Label();
            driver_VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionBindingNavigator)).BeginInit();
            this.tableVisionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // driver_NameLabel
            // 
            driver_NameLabel.AutoSize = true;
            driver_NameLabel.Location = new System.Drawing.Point(12, 51);
            driver_NameLabel.Name = "driver_NameLabel";
            driver_NameLabel.Size = new System.Drawing.Size(69, 13);
            driver_NameLabel.TabIndex = 8;
            driver_NameLabel.Text = "Driver Name:";
            // 
            // driver_VersionLabel
            // 
            driver_VersionLabel.AutoSize = true;
            driver_VersionLabel.Location = new System.Drawing.Point(12, 76);
            driver_VersionLabel.Name = "driver_VersionLabel";
            driver_VersionLabel.Size = new System.Drawing.Size(76, 13);
            driver_VersionLabel.TabIndex = 9;
            driver_VersionLabel.Text = "Driver Version:";
            // 
            // buttonBackVision
            // 
            this.buttonBackVision.Location = new System.Drawing.Point(15, 584);
            this.buttonBackVision.Name = "buttonBackVision";
            this.buttonBackVision.Size = new System.Drawing.Size(75, 23);
            this.buttonBackVision.TabIndex = 7;
            this.buttonBackVision.Text = "Back";
            this.buttonBackVision.UseVisualStyleBackColor = true;
            this.buttonBackVision.Click += new System.EventHandler(this.buttonBackVision_Click);
            // 
            // dataCDDataSet
            // 
            this.dataCDDataSet.DataSetName = "dataCDDataSet";
            this.dataCDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableVisionBindingSource
            // 
            this.tableVisionBindingSource.DataMember = "TableVision";
            this.tableVisionBindingSource.DataSource = this.dataCDDataSet;
            // 
            // tableVisionTableAdapter
            // 
            this.tableVisionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ARTableAdapter = null;
            this.tableAdapterManager.TableBoardTableAdapter = null;
            this.tableAdapterManager.TableVisionTableAdapter = this.tableVisionTableAdapter;
            this.tableAdapterManager.UpdateOrder = CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableVisionBindingNavigator
            // 
            this.tableVisionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableVisionBindingNavigator.BindingSource = this.tableVisionBindingSource;
            this.tableVisionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableVisionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableVisionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableVisionBindingNavigatorSaveItem});
            this.tableVisionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableVisionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableVisionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableVisionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableVisionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableVisionBindingNavigator.Name = "tableVisionBindingNavigator";
            this.tableVisionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableVisionBindingNavigator.Size = new System.Drawing.Size(647, 25);
            this.tableVisionBindingNavigator.TabIndex = 8;
            this.tableVisionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableVisionBindingNavigatorSaveItem
            // 
            this.tableVisionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableVisionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableVisionBindingNavigatorSaveItem.Image")));
            this.tableVisionBindingNavigatorSaveItem.Name = "tableVisionBindingNavigatorSaveItem";
            this.tableVisionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableVisionBindingNavigatorSaveItem.Text = "Save Data";
            this.tableVisionBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableVisionBindingNavigatorSaveItem_Click);
            // 
            // driver_NameTextBox
            // 
            this.driver_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableVisionBindingSource, "Driver Name", true));
            this.driver_NameTextBox.Location = new System.Drawing.Point(87, 48);
            this.driver_NameTextBox.Name = "driver_NameTextBox";
            this.driver_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_NameTextBox.TabIndex = 9;
            // 
            // driver_VersionTextBox
            // 
            this.driver_VersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableVisionBindingSource, "Driver Version", true));
            this.driver_VersionTextBox.Location = new System.Drawing.Point(87, 73);
            this.driver_VersionTextBox.Name = "driver_VersionTextBox";
            this.driver_VersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_VersionTextBox.TabIndex = 10;
            // 
            // tableVisionDataGridView
            // 
            this.tableVisionDataGridView.AutoGenerateColumns = false;
            this.tableVisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVisionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableVisionDataGridView.DataSource = this.tableVisionBindingSource;
            this.tableVisionDataGridView.Location = new System.Drawing.Point(0, 221);
            this.tableVisionDataGridView.Name = "tableVisionDataGridView";
            this.tableVisionDataGridView.Size = new System.Drawing.Size(532, 357);
            this.tableVisionDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Driver Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Driver Version";
            this.dataGridViewTextBoxColumn3.HeaderText = "Driver Version";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // InsertVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 630);
            this.Controls.Add(this.tableVisionDataGridView);
            this.Controls.Add(driver_VersionLabel);
            this.Controls.Add(this.driver_VersionTextBox);
            this.Controls.Add(driver_NameLabel);
            this.Controls.Add(this.driver_NameTextBox);
            this.Controls.Add(this.tableVisionBindingNavigator);
            this.Controls.Add(this.buttonBackVision);
            this.Name = "InsertVision";
            this.Text = "Insert Drivers Vision";
            this.Load += new System.EventHandler(this.InsertVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionBindingNavigator)).EndInit();
            this.tableVisionBindingNavigator.ResumeLayout(false);
            this.tableVisionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVisionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackVision;
        private dataCDDataSet dataCDDataSet;
        private System.Windows.Forms.BindingSource tableVisionBindingSource;
        private dataCDDataSetTableAdapters.TableVisionTableAdapter tableVisionTableAdapter;
        private dataCDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableVisionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableVisionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox driver_NameTextBox;
        private System.Windows.Forms.TextBox driver_VersionTextBox;
        private System.Windows.Forms.DataGridView tableVisionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}