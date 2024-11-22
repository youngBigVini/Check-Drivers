using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CheckDrivers
{
    public partial class initial : Form
    {
        private List<string> msgDriversOk = new List<string>();
        private List<string> msgDriversNok = new List<string>();
        public initial()
        {
            InitializeComponent();
            buttonOkAr.Visible = false;
            buttonOkVision.Visible = false;
            buttonOkBoard.Visible = false;
        }

        private void buttonInsertDriverAr_Click(object sender, EventArgs e)
        {
            InsertAR insertAR = new InsertAR();
            insertAR.Show();
            this.Hide();
        }

        private void buttonOkAr_Click(object sender, EventArgs e)
        {
            pictureBoxAr.Image = null;
            buttonOkAr.Visible = false;
        }
    }
}
