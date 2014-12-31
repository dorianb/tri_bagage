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
    public partial class DetailBagageForm : Form
    {
        public int id;

        public DetailBagageForm()
        {
            InitializeComponent();
        }

        public DetailBagageForm(int id)
        {
            this.id = id;
            
            InitializeComponent();
        }

        private void DetailBagageForm_Load(object sender, EventArgs e)
        {
            BagageDefinition bagage = Program.proxy.DetailBagage(this.id);

            if(bagage != null)
            {
                this.Text = @"Caractéristiques du bagage <" + bagage.CodeIATA + @">";
                label_codeIATA.Text = bagage.CodeIATA;
                label_compagnie.Text = bagage.Ciee;
                label_type.Text = bagage.Typ;

                if (bagage.Recol)
                {
                    label_recolle.Text = "Oui";
                }
                else
                {
                    label_recolle.Text = "Non";
                }

                if (bagage.Emb)
                {
                    label_embarquable.Text = "Oui";
                }
                else
                {
                    label_embarquable.Text = "Non";
                }

                label_Datecreation.Text = bagage.DateCreation.ToString();
                label_creation.Text = bagage.Creation;
                label_particularite.Text = bagage.Description;

                if(bagage.VolAuDepart != null)
                {
                    label_aeroportDestination.Text = bagage.VolAuDepart.Aer;
                    
                    dataGridView_volsAssocies.Rows.Add("Vol au départ", bagage.VolAuDepart.CodeCIE, null, bagage.VolAuDepart.Ligne, bagage.VolAuDepart.Jex, null, null);
                    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView_volsAssocies.Rows[dataGridView_volsAssocies.RowCount - 1].Cells["detail_link"];
                    cell.Description = bagage.VolAuDepart.Id.ToString();
                }

                if (bagage.VolContinuation != null)
                {
                    label_aeroportContinuation.Text = bagage.VolContinuation.Aer;
                    
                    dataGridView_volsAssocies.Rows.Add("Vol continuation", bagage.VolContinuation.CodeCIE, null, bagage.VolContinuation.Ligne, bagage.VolContinuation.Jex, null, null);
                }

                if (bagage.VolApport != null)
                {
                    dataGridView_volsAssocies.Rows.Add("Vol apport", bagage.VolApport.CodeCIE, null, bagage.VolApport.Ligne, bagage.VolApport.Jex, null, null);
                }

                if(bagage.Trace != null)
                {
                    int counter = 1;

                    foreach (TraceDefinition trace in bagage.Trace)
                    {
                        dataGridView_tracabiliteBagage.Rows.Add(counter++, trace.DatePassage, trace.Type, trace.Localisation, trace.Statut, trace.Informations);
                    }
                }
            }
        }
    }
}
