﻿using MyAirport.Client.ServiceReference1;
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
        public VolForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //proxy.MonHistorique();
                VolDefinition vol = Program.proxy.DetailVol((int)this.numericUpDown1.Value);

                if (vol != null)
                {
                    this.textBox1.Text = vol.CIE;
                    this.textBox2.Text = vol.Ligne;
                    this.textBox3.Text = vol.Date.ToString();
                    this.listBox1.Items.Clear();

                    if (vol.Banques != null)
                    {
                        foreach (var b in vol.Banques)
                        {
                            this.listBox1.Items.Add(b);
                        }
                    }
                }
            }
            catch (FaultException<PersoFaultException>val)
            {
                MessageBox.Show(val.Detail.Message);
            }
            catch (FaultException exp)
            {
                this.textBox1.Text = exp.Reason.ToString();
                this.textBox2.Text = exp.Code.Name;
                this.textBox3.Text = exp.Message;
            }            
        }
    }
}
