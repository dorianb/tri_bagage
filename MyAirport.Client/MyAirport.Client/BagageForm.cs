using MyAirport.Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAirport.Client
{
    public partial class BagageForm : Form
    {
        public BagageForm()
        {
            InitializeComponent();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            VolDefinition[] listVol = Program.proxy.RechercherVolsDeLaCompagnie(comboBox_compagnie.Text);
            BagageDefinition[] listBagage;
            int counter = 1;

            foreach (VolDefinition vol in listVol)
            {
                listBagage = Program.proxy.RechercherBagagesDuVol((int)vol.Id);
                if (listBagage != null)
                {
                    foreach (BagageDefinition bag in listBagage)
                    {
                        dataGridView_listeBagages.Rows.Add(counter++, bag.CodeIATA);
                        DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeBagages.Rows[dataGridView_listeBagages.RowCount-1].Cells["detail_link"];
                        cell.Description = bag.Id.ToString();
                    }
                } 
            }
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell) dataGridView_listeBagages.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewColumn column = dataGridView_listeBagages.Columns[cell.ColumnIndex];

            if(column.HeaderText.Equals("Lien"))
            {
                DetailBagageForm detailBagage = new DetailBagageForm(Int32.Parse(cell.Description));
                detailBagage.Show();
            }
        }
    }
}
