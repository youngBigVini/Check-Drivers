namespace CheckDrivers
{
    partial class initial
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
            this.comboBoxAr = new System.Windows.Forms.ComboBox();
            this.buttonInsertDriverAr = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonOkAr = new System.Windows.Forms.Button();
            this.pictureBoxAr = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonOkVision = new System.Windows.Forms.Button();
            this.pictureBoxVision = new System.Windows.Forms.PictureBox();
            this.comboBoxVision = new System.Windows.Forms.ComboBox();
            this.buttonInsertDriverVision = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonOkBoard = new System.Windows.Forms.Button();
            this.pictureBoxBoard = new System.Windows.Forms.PictureBox();
            this.comboBoxBoard = new System.Windows.Forms.ComboBox();
            this.buttonInsertDriverBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAr)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVision)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAr
            // 
            this.comboBoxAr.FormattingEnabled = true;
            this.comboBoxAr.Location = new System.Drawing.Point(3, 25);
            this.comboBoxAr.Name = "comboBoxAr";
            this.comboBoxAr.Size = new System.Drawing.Size(425, 21);
            this.comboBoxAr.TabIndex = 0;
            this.comboBoxAr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonInsertDriverAr
            // 
            this.buttonInsertDriverAr.Location = new System.Drawing.Point(6, 62);
            this.buttonInsertDriverAr.Name = "buttonInsertDriverAr";
            this.buttonInsertDriverAr.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDriverAr.TabIndex = 1;
            this.buttonInsertDriverAr.Text = "Insert Driver";
            this.buttonInsertDriverAr.UseVisualStyleBackColor = true;
            this.buttonInsertDriverAr.Click += new System.EventHandler(this.buttonInsertDriverAr_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(169, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 625);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonOkAr);
            this.tabPage1.Controls.Add(this.pictureBoxAr);
            this.tabPage1.Controls.Add(this.comboBoxAr);
            this.tabPage1.Controls.Add(this.buttonInsertDriverAr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonOkAr
            // 
            this.buttonOkAr.Location = new System.Drawing.Point(332, 549);
            this.buttonOkAr.Name = "buttonOkAr";
            this.buttonOkAr.Size = new System.Drawing.Size(75, 23);
            this.buttonOkAr.TabIndex = 3;
            this.buttonOkAr.Text = "OK";
            this.buttonOkAr.UseVisualStyleBackColor = true;
            this.buttonOkAr.Click += new System.EventHandler(this.buttonOkAr_Click);
            // 
            // pictureBoxAr
            // 
            this.pictureBoxAr.Location = new System.Drawing.Point(3, 178);
            this.pictureBoxAr.Name = "pictureBoxAr";
            this.pictureBoxAr.Size = new System.Drawing.Size(428, 421);
            this.pictureBoxAr.TabIndex = 2;
            this.pictureBoxAr.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonOkVision);
            this.tabPage2.Controls.Add(this.pictureBoxVision);
            this.tabPage2.Controls.Add(this.comboBoxVision);
            this.tabPage2.Controls.Add(this.buttonInsertDriverVision);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VISION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOkVision
            // 
            this.buttonOkVision.Location = new System.Drawing.Point(332, 549);
            this.buttonOkVision.Name = "buttonOkVision";
            this.buttonOkVision.Size = new System.Drawing.Size(75, 23);
            this.buttonOkVision.TabIndex = 7;
            this.buttonOkVision.Text = "OK";
            this.buttonOkVision.UseVisualStyleBackColor = true;
            // 
            // pictureBoxVision
            // 
            this.pictureBoxVision.Location = new System.Drawing.Point(3, 178);
            this.pictureBoxVision.Name = "pictureBoxVision";
            this.pictureBoxVision.Size = new System.Drawing.Size(428, 421);
            this.pictureBoxVision.TabIndex = 6;
            this.pictureBoxVision.TabStop = false;
            // 
            // comboBoxVision
            // 
            this.comboBoxVision.FormattingEnabled = true;
            this.comboBoxVision.Location = new System.Drawing.Point(3, 25);
            this.comboBoxVision.Name = "comboBoxVision";
            this.comboBoxVision.Size = new System.Drawing.Size(425, 21);
            this.comboBoxVision.TabIndex = 4;
            this.comboBoxVision.SelectedIndexChanged += new System.EventHandler(this.comboBoxVision_SelectedIndexChanged);
            // 
            // buttonInsertDriverVision
            // 
            this.buttonInsertDriverVision.Location = new System.Drawing.Point(6, 62);
            this.buttonInsertDriverVision.Name = "buttonInsertDriverVision";
            this.buttonInsertDriverVision.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDriverVision.TabIndex = 5;
            this.buttonInsertDriverVision.Text = "Insert Driver";
            this.buttonInsertDriverVision.UseVisualStyleBackColor = true;
            this.buttonInsertDriverVision.Click += new System.EventHandler(this.buttonInsertDriverVision_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.buttonOkBoard);
            this.tabPage3.Controls.Add(this.pictureBoxBoard);
            this.tabPage3.Controls.Add(this.comboBoxBoard);
            this.tabPage3.Controls.Add(this.buttonInsertDriverBoard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(434, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BOARD";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonOkBoard
            // 
            this.buttonOkBoard.Location = new System.Drawing.Point(332, 549);
            this.buttonOkBoard.Name = "buttonOkBoard";
            this.buttonOkBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonOkBoard.TabIndex = 7;
            this.buttonOkBoard.Text = "OK";
            this.buttonOkBoard.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBoard
            // 
            this.pictureBoxBoard.Location = new System.Drawing.Point(3, 178);
            this.pictureBoxBoard.Name = "pictureBoxBoard";
            this.pictureBoxBoard.Size = new System.Drawing.Size(428, 421);
            this.pictureBoxBoard.TabIndex = 6;
            this.pictureBoxBoard.TabStop = false;
            // 
            // comboBoxBoard
            // 
            this.comboBoxBoard.FormattingEnabled = true;
            this.comboBoxBoard.Location = new System.Drawing.Point(3, 25);
            this.comboBoxBoard.Name = "comboBoxBoard";
            this.comboBoxBoard.Size = new System.Drawing.Size(425, 21);
            this.comboBoxBoard.TabIndex = 4;
            this.comboBoxBoard.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoard_SelectedIndexChanged);
            // 
            // buttonInsertDriverBoard
            // 
            this.buttonInsertDriverBoard.Location = new System.Drawing.Point(6, 62);
            this.buttonInsertDriverBoard.Name = "buttonInsertDriverBoard";
            this.buttonInsertDriverBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDriverBoard.TabIndex = 5;
            this.buttonInsertDriverBoard.Text = "Insert Driver";
            this.buttonInsertDriverBoard.UseVisualStyleBackColor = true;
            this.buttonInsertDriverBoard.Click += new System.EventHandler(this.buttonInsertDriverBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a driver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select a driver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select a driver:";
            // 
            // initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "initial";
            this.Text = "Check Drivers";
            this.Load += new System.EventHandler(this.initial_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAr)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVision)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAr;
        private System.Windows.Forms.Button buttonInsertDriverAr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxVision;
        private System.Windows.Forms.Button buttonInsertDriverVision;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxBoard;
        private System.Windows.Forms.Button buttonInsertDriverBoard;
        private System.Windows.Forms.Button buttonOkAr;
        private System.Windows.Forms.PictureBox pictureBoxAr;
        private System.Windows.Forms.Button buttonOkVision;
        private System.Windows.Forms.PictureBox pictureBoxVision;
        private System.Windows.Forms.Button buttonOkBoard;
        private System.Windows.Forms.PictureBox pictureBoxBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}