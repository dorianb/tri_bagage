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
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.VolDefinition vol = proxy.DetailVol(Convert.ToInt32(this.numericUpDown1.Value));

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
}
