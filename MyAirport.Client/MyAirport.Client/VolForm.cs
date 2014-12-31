using MyAirport.Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAirport.Client
{
    public partial class VolForm : Form
    {
        public int id_vol = -1;
        
        public VolForm()
        {
            InitializeComponent();
        }

        public VolForm(int id_vol)
        {
            InitializeComponent();

            this.id_vol = id_vol;
        }

        private void VolForm_Load(object sender, EventArgs e)
        {
            BagageCriteres criteres = Program.proxy.MesCriteresFiltre();

            foreach (string compagnie in criteres.Compagnies)
            {
                comboBox_compagnie.Items.Add(compagnie);
            }

            if (this.id_vol != -1)
            {
                VolDefinition vol = null;

                vol = Program.proxy.DetailVol(this.id_vol);

                if (vol != null)
                {
                    dataGridView_listeDeVols.Rows.Add(1, vol.Date.ToString(), vol.CIE, vol.CodeCIE, vol.Ligne, null);
                    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeDeVols.Rows[dataGridView_listeDeVols.RowCount - 1].Cells["detail_link"];
                    cell.Description = vol.Id.ToString();
                }
            }
        }

        private void button_RechercherParDateOuCompagnie_Click(object sender, EventArgs e)
        {
            VolDefinition[] listVols = null;
            int counter = 1;

            dataGridView_listeDeVols.Rows.Clear();

            if(!comboBox_compagnie.Text.Equals(""))
            {
                listVols = Program.proxy.RechercherVolsDeLaCompagnie(comboBox_compagnie.Text);
            }

            if (listVols != null)
            {
                foreach (VolDefinition vol in listVols)
                {
                    dataGridView_listeDeVols.Rows.Add(counter++, vol.Date.ToString(), vol.CIE, vol.CodeCIE, vol.Ligne, null);
                    DataGridViewImageCell cell = (DataGridViewImageCell) dataGridView_listeDeVols.Rows[dataGridView_listeDeVols.RowCount - 1].Cells["detail_link"];
                    cell.Description = vol.Id.ToString();
                }
            } 
        }

        private void button_RechercherParNumeroVol_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_listeDeVols.Rows.Clear();

                //proxy.MonHistorique();
                VolDefinition vol = Program.proxy.DetailVol((int)this.numericUpDown1.Value);

                if (vol != null)
                {     
                    dataGridView_listeDeVols.Rows.Add(1, vol.Date.ToString(), vol.CIE, vol.CodeCIE, vol.Ligne, null);
                    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeDeVols.Rows[dataGridView_listeDeVols.RowCount - 1].Cells["detail_link"];
                    cell.Description = vol.Id.ToString(); 
                } 
            }
            catch (FaultException<PersoFaultException> val)
            {
                MessageBox.Show(val.Detail.Message);
            }
            catch (FaultException exp)
            {
                /*this.textBox1.Text = exp.Reason.ToString();
                this.textBox2.Text = exp.Code.Name;
                this.textBox3.Text = exp.Message;*/
            }
        }

        private void dataGridView_listeDeVols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_listeDeVols.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewColumn column = dataGridView_listeDeVols.Columns[cell.ColumnIndex];

                if (column.HeaderText.Equals("Rechercher les bagages"))
                {
                    BagageForm bagage = new BagageForm(Int32.Parse(cell.Description));
                    bagage.Show();
                }
            }
            catch (System.InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
