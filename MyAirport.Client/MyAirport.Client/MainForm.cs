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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.proxy = new ServiceReference1.Service1Client("EpBasicHttp");

            /** Pour les tests, à commanter autrement **/
            /*Program.proxy = new ServiceReference1.Service1Client("EpBasicHttpUserCredential");
            Program.proxy.ClientCredentials.UserName.UserName = "User1";
            Program.proxy.ClientCredentials.UserName.Password = "1234";*/
            /**         **/
        }

        private void button_vol_Click(object sender, EventArgs e)
        {
            VolForm form = new VolForm();
            form.Show();
            //this.Hide();
        }

        private void button_param_Click(object sender, EventArgs e)
        {
            ParameterForm form = new ParameterForm();
            form.Show();
        }

        private void button_bagage_Click(object sender, EventArgs e)
        {
            BagageForm form = new BagageForm();
            form.Show();
        }
    }
}
