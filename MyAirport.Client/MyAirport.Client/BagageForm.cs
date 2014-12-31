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
        public int? id_vol = null;

        public BagageForm()
        {
            InitializeComponent();
        }

        public BagageForm(int id_vol)
        {
            InitializeComponent();

            this.id_vol = (int?) id_vol;
        }

        private void BagageForm_Load(object sender, EventArgs e)
        {
            BagageCriteres criteres = Program.proxy.MesCriteresFiltre();

            foreach(string compagnie in criteres.Compagnies)
            {
                comboBox_compagnie.Items.Add(compagnie);
            }

            if(this.id_vol != null)
            {
                BagageDefinition[] listBagage = null;
                int counter = 1;

                listBagage = Program.proxy.RechercherBagagesDuVol(this.id_vol);

                if (listBagage != null)
                {
                    foreach (BagageDefinition bag in listBagage)
                    {
                        dataGridView_listeBagages.Rows.Add(counter++, bag.CodeIATA, bag.Ciee + bag.Ligne, null, bag.StatutSurete, (bag.Recol) ? "Oui" : "Non", null, null);
                        DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeBagages.Rows[dataGridView_listeBagages.RowCount - 1].Cells["detail_link"];
                        cell.Description = bag.Id.ToString();
                    }
                } 
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            BagageDefinition[] listBagage = null;
            int counter = 1;

            dataGridView_listeBagages.Rows.Clear();

            if((!textBox_CodeIATA.Text.Equals("")) && (!comboBox_compagnie.Text.Equals("")))
            {
                BagageCriteres criteres = new BagageCriteres();
                criteres.Compagnies = new string[] {comboBox_compagnie.Text};
                criteres.TemplateCodeIata = textBox_CodeIATA.Text;
                listBagage = Program.proxy.RechercherBagages(criteres);
            }
            else if (!textBox_CodeIATA.Text.Equals(""))
            {
                listBagage = Program.proxy.RechercherBagagesParIATA(textBox_CodeIATA.Text);
            }
            else if(!comboBox_compagnie.Text.Equals(""))
            {
                listBagage = Program.proxy.RechercherBagagesDeLaCompagnie(comboBox_compagnie.Text);
            }

            if (listBagage != null)
            {
                foreach (BagageDefinition bag in listBagage)
                {
                    dataGridView_listeBagages.Rows.Add(counter++, bag.CodeIATA, bag.Ciee + bag.Ligne, null, bag.StatutSurete, (bag.Recol) ? "Oui" : "Non", null, null);
                    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeBagages.Rows[dataGridView_listeBagages.RowCount-1].Cells["detail_link"];
                    cell.Description = bag.Id.ToString();
                }
            } 
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeBagages.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewColumn column = dataGridView_listeBagages.Columns[cell.ColumnIndex];

                if (column.HeaderText.Equals("Lien"))
                {
                    DetailBagageForm detailBagage = new DetailBagageForm(Int32.Parse(cell.Description));
                    detailBagage.Show();
                }
            }
            catch(System.InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button_RAZ_Click(object sender, EventArgs e)
        {
            comboBox_compagnie.Text = "";
            textBox_CodeIATA.Text = "";
            dataGridView_listeBagages.Rows.Clear();
        }
    }
}
