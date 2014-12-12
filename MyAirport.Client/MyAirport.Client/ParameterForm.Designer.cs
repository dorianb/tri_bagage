namespace MyAirport.Client
{
    partial class ParameterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_domaine = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_connexion = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_clientcredential = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_domaine
            // 
            this.textBox_domaine.Location = new System.Drawing.Point(109, 83);
            this.textBox_domaine.Name = "textBox_domaine";
            this.textBox_domaine.Size = new System.Drawing.Size(317, 20);
            this.textBox_domaine.TabIndex = 15;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(109, 49);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(317, 20);
            this.textBox_password.TabIndex = 14;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(109, 23);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(317, 20);
            this.textBox_login.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Domaine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pwd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login :";
            // 
            // button_annuler
            // 
            this.button_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_annuler.Location = new System.Drawing.Point(109, 186);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(124, 35);
            this.button_annuler.TabIndex = 9;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_connexion
            // 
            this.button_connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_connexion.Location = new System.Drawing.Point(295, 186);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(131, 35);
            this.button_connexion.TabIndex = 8;
            this.button_connexion.Text = "Se connecter";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Windows";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows",
            "UserName"});
            this.comboBox1.Location = new System.Drawing.Point(109, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Select...";
            // 
            // label_clientcredential
            // 
            this.label_clientcredential.AutoSize = true;
            this.label_clientcredential.Location = new System.Drawing.Point(17, 118);
            this.label_clientcredential.Name = "label_clientcredential";
            this.label_clientcredential.Size = new System.Drawing.Size(89, 13);
            this.label_clientcredential.TabIndex = 17;
            this.label_clientcredential.Text = "Client Credential :";
            // 
            // ParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 305);
            this.Controls.Add(this.label_clientcredential);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_domaine);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_connexion);
            this.Name = "ParameterForm";
            this.Text = "Paramètre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_domaine;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_clientcredential;

    }
}