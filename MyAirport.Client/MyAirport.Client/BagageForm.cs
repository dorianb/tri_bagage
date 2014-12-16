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
            foreach (VolDefinition vol in listVol)
            {
                listBagage = Program.proxy.RechercherBagagesDuVol((int)vol.Id);
                if (listBagage != null)
                {
                    foreach (BagageDefinition bag in listBagage)
                    {
                        dataGridView1.Rows.Add(bag.CodeIATA, vol.Ligne, null, null, null, null, null);
                    }
                } 
            }
        }
    }
}
