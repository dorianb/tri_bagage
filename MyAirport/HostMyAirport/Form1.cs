using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Net;


namespace HostMyAirport
{
    public partial class Form1 : Form
    {

        System.ServiceModel.ServiceHost host;
        public Form1()
        {
            InitializeComponent();
            host = new System.ServiceModel.ServiceHost(typeof(MyAirport.Service.Service1));
            this.label2.Text = host.State.ToString();

            this.linkLabel1.Text = this.host.BaseAddresses[0].ToString();
            this.listBox1.Items.Add(this.linkLabel1.Text = this.host.BaseAddresses[0].ToString());
            host.Closed += new EventHandler(host_StateChanged);
            host.Closing += new EventHandler(host_StateChanged);
            host.Faulted += new EventHandler(host_StateChanged);
            host.Opening += new EventHandler(host_StateChanged);
            host.Opened += new EventHandler(host_StateChanged);
//            host.UnknownMessageReceived += host_UnknownMessageReceived;


        }

        void host_UnknownMessageReceived(object sender, UnknownMessageReceivedEventArgs e)
        {
            MessageBox.Show("Message non correct");
        }
        void host_StateChanged(Object sender, EventArgs e)
        {
            this.label2.Text = host.State.ToString();
            this.listBox1.Items.Add("Changement d'état du host :" +
                host.State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            host.Open();
            foreach(var v in host.Description.Endpoints)
            {
                this.listBox2.Items.Add(v.Name +":"+v.ListenUri);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.label5.Text = MyAirport.Service.Service1.NbInstance.ToString();
        }
    }
}
