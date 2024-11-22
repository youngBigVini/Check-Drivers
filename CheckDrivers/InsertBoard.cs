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
    public partial class InsertBoard : Form
    {
        public InsertBoard()
        {
            InitializeComponent();
        }

        private void buttonBackBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            initial initial = new initial();
            initial.Show();
        }

        private void tableBoardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBoardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataCDDataSet);

        }

        private void InsertBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataCDDataSet.TableBoard' table. You can move, or remove it, as needed.
            this.tableBoardTableAdapter.Fill(this.dataCDDataSet.TableBoard);

        }
    }
}
