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
    public partial class InsertVision : Form
    {
        public InsertVision()
        {
            InitializeComponent();
        }

        private void tableVisionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableVisionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataCDDataSet);

        }

        private void InsertVision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataCDDataSet.TableVision' table. You can move, or remove it, as needed.
            this.tableVisionTableAdapter.Fill(this.dataCDDataSet.TableVision);

        }

        private void buttonBackVision_Click(object sender, EventArgs e)
        {
            this.Hide();
            initial initial = new initial();
            initial.Show();
        }

        private void InsertVision_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
