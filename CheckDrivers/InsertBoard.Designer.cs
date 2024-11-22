namespace CheckDrivers
{
    partial class InsertBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertBoard));
            System.Windows.Forms.Label driver_NameLabel;
            System.Windows.Forms.Label driver_VersionLabel;
            this.buttonBackBoard = new System.Windows.Forms.Button();
            this.dataCDDataSet = new CheckDrivers.dataCDDataSet();
            this.tableBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBoardTableAdapter = new CheckDrivers.dataCDDataSetTableAdapters.TableBoardTableAdapter();
            this.tableAdapterManager = new CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager();
            this.tableBoardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableBoardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.driver_NameTextBox = new System.Windows.Forms.TextBox();
            this.driver_VersionTextBox = new System.Windows.Forms.TextBox();
            this.tableBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            driver_NameLabel = new System.Windows.Forms.Label();
            driver_VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardBindingNavigator)).BeginInit();
            this.tableBoardBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackBoard
            // 
            this.buttonBackBoard.Location = new System.Drawing.Point(15, 584);
            this.buttonBackBoard.Name = "buttonBackBoard";
            this.buttonBackBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonBackBoard.TabIndex = 7;
            this.buttonBackBoard.Text = "Back";
            this.buttonBackBoard.UseVisualStyleBackColor = true;
            this.buttonBackBoard.Click += new System.EventHandler(this.buttonBackBoard_Click);
            // 
            // dataCDDataSet
            // 
            this.dataCDDataSet.DataSetName = "dataCDDataSet";
            this.dataCDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBoardBindingSource
            // 
            this.tableBoardBindingSource.DataMember = "TableBoard";
            this.tableBoardBindingSource.DataSource = this.dataCDDataSet;
            // 
            // tableBoardTableAdapter
            // 
            this.tableBoardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ARTableAdapter = null;
            this.tableAdapterManager.TableBoardTableAdapter = this.tableBoardTableAdapter;
            this.tableAdapterManager.TableVisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CheckDrivers.dataCDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBoardBindingNavigator
            // 
            this.tableBoardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBoardBindingNavigator.BindingSource = this.tableBoardBindingSource;
            this.tableBoardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBoardBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBoardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableBoardBindingNavigatorSaveItem});
            this.tableBoardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBoardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBoardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBoardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBoardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBoardBindingNavigator.Name = "tableBoardBindingNavigator";
            this.tableBoardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBoardBindingNavigator.Size = new System.Drawing.Size(647, 25);
            this.tableBoardBindingNavigator.TabIndex = 8;
            this.tableBoardBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBoardBindingNavigatorSaveItem
            // 
            this.tableBoardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBoardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBoardBindingNavigatorSaveItem.Image")));
            this.tableBoardBindingNavigatorSaveItem.Name = "tableBoardBindingNavigatorSaveItem";
            this.tableBoardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableBoardBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBoardBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBoardBindingNavigatorSaveItem_Click);
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
            // driver_NameTextBox
            // 
            this.driver_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBoardBindingSource, "Driver Name", true));
            this.driver_NameTextBox.Location = new System.Drawing.Point(87, 48);
            this.driver_NameTextBox.Name = "driver_NameTextBox";
            this.driver_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_NameTextBox.TabIndex = 9;
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
            // driver_VersionTextBox
            // 
            this.driver_VersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBoardBindingSource, "Driver Version", true));
            this.driver_VersionTextBox.Location = new System.Drawing.Point(87, 73);
            this.driver_VersionTextBox.Name = "driver_VersionTextBox";
            this.driver_VersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.driver_VersionTextBox.TabIndex = 10;
            // 
            // tableBoardDataGridView
            // 
            this.tableBoardDataGridView.AutoGenerateColumns = false;
            this.tableBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBoardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableBoardDataGridView.DataSource = this.tableBoardBindingSource;
            this.tableBoardDataGridView.Location = new System.Drawing.Point(0, 221);
            this.tableBoardDataGridView.Name = "tableBoardDataGridView";
            this.tableBoardDataGridView.Size = new System.Drawing.Size(532, 357);
            this.tableBoardDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // InsertBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 630);
            this.Controls.Add(this.tableBoardDataGridView);
            this.Controls.Add(driver_VersionLabel);
            this.Controls.Add(this.driver_VersionTextBox);
            this.Controls.Add(driver_NameLabel);
            this.Controls.Add(this.driver_NameTextBox);
            this.Controls.Add(this.tableBoardBindingNavigator);
            this.Controls.Add(this.buttonBackBoard);
            this.Name = "InsertBoard";
            this.Text = "Insert Drivers Board";
            this.Load += new System.EventHandler(this.InsertBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardBindingNavigator)).EndInit();
            this.tableBoardBindingNavigator.ResumeLayout(false);
            this.tableBoardBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBoardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackBoard;
        private dataCDDataSet dataCDDataSet;
        private System.Windows.Forms.BindingSource tableBoardBindingSource;
        private dataCDDataSetTableAdapters.TableBoardTableAdapter tableBoardTableAdapter;
        private dataCDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBoardBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableBoardBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox driver_NameTextBox;
        private System.Windows.Forms.TextBox driver_VersionTextBox;
        private System.Windows.Forms.DataGridView tableBoardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}