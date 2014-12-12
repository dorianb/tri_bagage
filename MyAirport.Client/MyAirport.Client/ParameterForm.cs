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
    public partial class ParameterForm : Form
    {
        public ParameterForm()
        {
            InitializeComponent();

            //TransportClientCredentialType = None
            //TransportClientCredentialType = Windows
            //TransportClientCredentialType = Basic
            
            if(!Program.proxy.ClientCredentials.Windows.ClientCredential.UserName.Equals(""))
            {
                textBox_login.Text = Program.proxy.ClientCredentials.Windows.ClientCredential.UserName;
                textBox_password.Text = Program.proxy.ClientCredentials.Windows.ClientCredential.Password;
                textBox_domaine.Text = Program.proxy.ClientCredentials.Windows.ClientCredential.Domain;

                comboBox1.SelectedIndex = comboBox1.FindStringExact("Windows");
                button_connexion.Text = "Se déconnecter";
            }
            else if(Program.proxy.ClientCredentials.UserName.UserName != null)
            {
                textBox_login.Text = Program.proxy.ClientCredentials.UserName.UserName;
                textBox_password.Text = Program.proxy.ClientCredentials.UserName.Password;

                comboBox1.SelectedIndex = comboBox1.FindStringExact("UserName");
                button_connexion.Text = "Se déconnecter";
            }
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            if (button_connexion.Text.Equals("Se connecter"))
            {
                String credential = comboBox1.Text;

                if(credential.Equals("Windows"))
                {
                    Program.proxy = new ServiceReference1.Service1Client("EpBasicHttpWindowsCredential");
                    Program.proxy.ClientCredentials.Windows.ClientCredential.Password = textBox_password.Text;
                    Program.proxy.ClientCredentials.Windows.ClientCredential.UserName = textBox_login.Text;
                    Program.proxy.ClientCredentials.Windows.ClientCredential.Domain = textBox_domaine.Text;
                    var obj = Program.proxy.ChannelFactory.Credentials;
                }
                else if(credential.Equals("UserName"))
                {
                     Program.proxy = new ServiceReference1.Service1Client("EpBasicHttpUserCredential");
                     Program.proxy.ClientCredentials.UserName.Password = textBox_password.Text;
                     if (textBox_domaine.Text.Equals(""))
                     {
                         Program.proxy.ClientCredentials.UserName.UserName = textBox_login.Text;
                     }
                     else
                     {
                         Program.proxy.ClientCredentials.UserName.UserName = textBox_domaine + @"\\" + textBox_login.Text;
                     }
                     var obj = Program.proxy.ChannelFactory.Credentials;
                }
                this.Close();
            }
            else if (button_connexion.Text.Equals("Se déconnecter"))
            {
                Program.proxy = new ServiceReference1.Service1Client("EpBasicHttp");
                this.Close();
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*Program.proxy.ClientCredentials.Windows.ClientCredential.Password = "";
                Program.proxy.ClientCredentials.Windows.ClientCredential.UserName = @"dorian";
                Program.proxy.ClientCredentials.Windows.ClientCredential.Domain = @"";
                */
//CDG1
//this.proxy.ClientCredentials.UserName.UserName = "User1";
//this.proxy.ClientCredentials.UserName.Password = "1234";

//CEBCDG1
//this.proxy.ClientCredentials.UserName.UserName = "User2";
//this.proxy.ClientCredentials.UserName.Password = "1234";
