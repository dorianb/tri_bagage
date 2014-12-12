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
    public partial class AuthentificationForm : Form
    {
        public string Domaine 
        {get; private set;}
        public string UserName
        { get; private set; }
        public string Password
        { get; private set; }
        public AuthentificationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UserName = this.textBox1.Text;
            this.Password = this.textBox2.Text;
            this.Domaine = this.textBox3.Text;
        }
    }
}
