using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDrivers
{
    public partial class InsertAR : Form
    {
        public InsertAR()
        {
            InitializeComponent();
        }

        private void table_ARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ARBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataCDDataSet);

        }

        private void InsertAR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataCDDataSet.Table_AR' table. You can move, or remove it, as needed.
            this.table_ARTableAdapter.Fill(this.dataCDDataSet.Table_AR);

        }

        private void buttonBackAr_Click(object sender, EventArgs e)
        {
            this.Hide();
            initial initial = new initial();
            initial.Show();
        }
    }
}
