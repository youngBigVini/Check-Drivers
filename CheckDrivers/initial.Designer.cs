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
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxBoard = new System.Windows.Forms.ComboBox();
            this.pictureBoxBoard = new System.Windows.Forms.PictureBox();
            this.buttonOkBoard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Developed by V. Luiz";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.buttonOkBoard);
            this.tabPage3.Controls.Add(this.pictureBoxBoard);
            this.tabPage3.Controls.Add(this.comboBoxBoard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(434, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // pictureBoxBoard
            // 
            this.pictureBoxBoard.Location = new System.Drawing.Point(3, 178);
            this.pictureBoxBoard.Name = "pictureBoxBoard";
            this.pictureBoxBoard.Size = new System.Drawing.Size(428, 421);
            this.pictureBoxBoard.TabIndex = 6;
            this.pictureBoxBoard.TabStop = false;
            // 
            // buttonOkBoard
            // 
            this.buttonOkBoard.Location = new System.Drawing.Point(332, 549);
            this.buttonOkBoard.Name = "buttonOkBoard";
            this.buttonOkBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonOkBoard.TabIndex = 7;
            this.buttonOkBoard.Text = "OK";
            this.buttonOkBoard.UseVisualStyleBackColor = true;
            this.buttonOkBoard.Click += new System.EventHandler(this.buttonOkBoard_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(169, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 625);
            this.tabControl1.TabIndex = 2;
            // 
            // initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Name = "initial";
            this.Text = "Check Drivers";
            this.Load += new System.EventHandler(this.initial_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOkBoard;
        private System.Windows.Forms.PictureBox pictureBoxBoard;
        private System.Windows.Forms.ComboBox comboBoxBoard;
        private System.Windows.Forms.TabControl tabControl1;
    }
}