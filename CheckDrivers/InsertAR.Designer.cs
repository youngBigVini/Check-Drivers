namespace CheckDrivers
{
    partial class InsertAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAR));
            System.Windows.Forms.Label driver_NameLabel;
            System.Windows.Forms.Label driver_VersionLabel;
            this.dataCDDataSet = new CheckDrivers.dataCDDataSet();
            this.table_ARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ARTableAdapter = new CheckDrivers.dataCDDataSetTableAdapters.Table_ARTableAdapter();
            this.tableAdapterManager = new CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager();
            this.table_ARBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table_ARBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.table_ARDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_NameTextBox = new System.Windows.Forms.TextBox();
            this.driver_VersionTextBox = new System.Windows.Forms.TextBox();
            this.buttonBackAr = new System.Windows.Forms.Button();
            driver_NameLabel = new System.Windows.Forms.Label();
            driver_VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARBindingNavigator)).BeginInit();
            this.table_ARBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCDDataSet
            // 
            this.dataCDDataSet.DataSetName = "dataCDDataSet";
            this.dataCDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_ARBindingSource
            // 
            this.table_ARBindingSource.DataMember = "Table_AR";
            this.table_ARBindingSource.DataSource = this.dataCDDataSet;
            // 
            // table_ARTableAdapter
            // 
            this.table_ARTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ARTableAdapter = this.table_ARTableAdapter;
            this.tableAdapterManager.TableBoardTableAdapter = null;
            this.tableAdapterManager.TableVisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_ARBindingNavigator
            // 
            this.table_ARBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_ARBindingNavigator.BindingSource = this.table_ARBindingSource;
            this.table_ARBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_ARBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_ARBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_ARBindingNavigatorSaveItem});
            this.table_ARBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_ARBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_ARBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_ARBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_ARBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_ARBindingNavigator.Name = "table_ARBindingNavigator";
            this.table_ARBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_ARBindingNavigator.Size = new System.Drawing.Size(647, 25);
            this.table_ARBindingNavigator.TabIndex = 0;
            this.table_ARBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // table_ARBindingNavigatorSaveItem
            // 
            this.table_ARBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_ARBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_ARBindingNavigatorSaveItem.Image")));
            this.table_ARBindingNavigatorSaveItem.Name = "table_ARBindingNavigatorSaveItem";
            this.table_ARBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_ARBindingNavigatorSaveItem.Text = "Save Data";
            this.table_ARBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_ARBindingNavigatorSaveItem_Click);
            // 
            // table_ARDataGridView
            // 
            this.table_ARDataGridView.AutoGenerateColumns = false;
            this.table_ARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_ARDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.table_ARDataGridView.DataSource = this.table_ARBindingSource;
            this.table_ARDataGridView.Location = new System.Drawing.Point(0, 221);
            this.table_ARDataGridView.Name = "table_ARDataGridView";
            this.table_ARDataGridView.Size = new System.Drawing.Size(392, 219);
            this.table_ARDataGridView.TabIndex = 1;
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
            // driver_NameLabel
            // 
            driver_NameLabel.AutoSize = true;
            driver_NameLabel.Location = new System.Drawing.Point(12, 51);
            driver_NameLabel.Name = "driver_NameLabel";
            driver_NameLabel.Size = new System.Drawing.Size(69, 13);
            driver_NameLabel.TabIndex = 2;
            driver_NameLabel.Text = "Driver Name:";
            // 
            // driver_NameTextBox
            // 
            this.driver_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ARBindingSource, "Driver Name", true));
            this.driver_NameTextBox.Location = new System.Drawing.Point(87, 48);
            this.driver_NameTextBox.Name = "driver_NameTextBox";
            this.driver_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_NameTextBox.TabIndex = 3;
            // 
            // driver_VersionLabel
            // 
            driver_VersionLabel.AutoSize = true;
            driver_VersionLabel.Location = new System.Drawing.Point(12, 76);
            driver_VersionLabel.Name = "driver_VersionLabel";
            driver_VersionLabel.Size = new System.Drawing.Size(76, 13);
            driver_VersionLabel.TabIndex = 4;
            driver_VersionLabel.Text = "Driver Version:";
            // 
            // driver_VersionTextBox
            // 
            this.driver_VersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ARBindingSource, "Driver Version", true));
            this.driver_VersionTextBox.Location = new System.Drawing.Point(87, 73);
            this.driver_VersionTextBox.Name = "driver_VersionTextBox";
            this.driver_VersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_VersionTextBox.TabIndex = 5;
            // 
            // buttonBackAr
            // 
            this.buttonBackAr.Location = new System.Drawing.Point(15, 512);
            this.buttonBackAr.Name = "buttonBackAr";
            this.buttonBackAr.Size = new System.Drawing.Size(75, 23);
            this.buttonBackAr.TabIndex = 6;
            this.buttonBackAr.Text = "Back";
            this.buttonBackAr.UseVisualStyleBackColor = true;
            this.buttonBackAr.Click += new System.EventHandler(this.buttonBackAr_Click);
            // 
            // InsertAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 630);
            this.Controls.Add(this.buttonBackAr);
            this.Controls.Add(driver_VersionLabel);
            this.Controls.Add(this.driver_VersionTextBox);
            this.Controls.Add(driver_NameLabel);
            this.Controls.Add(this.driver_NameTextBox);
            this.Controls.Add(this.table_ARDataGridView);
            this.Controls.Add(this.table_ARBindingNavigator);
            this.Name = "InsertAR";
            this.Text = "Insert Drivers AR";
            this.Load += new System.EventHandler(this.InsertAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARBindingNavigator)).EndInit();
            this.table_ARBindingNavigator.ResumeLayout(false);
            this.table_ARBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ARDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataCDDataSet dataCDDataSet;
        private System.Windows.Forms.BindingSource table_ARBindingSource;
        private dataCDDataSetTableAdapters.Table_ARTableAdapter table_ARTableAdapter;
        private dataCDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_ARBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_ARBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView table_ARDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox driver_NameTextBox;
        private System.Windows.Forms.TextBox driver_VersionTextBox;
        private System.Windows.Forms.Button buttonBackAr;
    }
}