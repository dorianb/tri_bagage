namespace MyAirport.Client
{
    partial class VolForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_compagnie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_RechercherParNumeroVol = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_RechercherParDateOuCompagnie = new System.Windows.Forms.Button();
            this.dataGridView_listeDeVols = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_cie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_link = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeDeVols)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 314);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_RechercherParDateOuCompagnie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_compagnie);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Par date ou compagnie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date Début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Compagnie";
            // 
            // comboBox_compagnie
            // 
            this.comboBox_compagnie.FormattingEnabled = true;
            this.comboBox_compagnie.Location = new System.Drawing.Point(137, 167);
            this.comboBox_compagnie.Name = "comboBox_compagnie";
            this.comboBox_compagnie.Size = new System.Drawing.Size(200, 21);
            this.comboBox_compagnie.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Fin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_RechercherParNumeroVol);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Par numéro de vol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_RechercherParNumeroVol
            // 
            this.button_RechercherParNumeroVol.Location = new System.Drawing.Point(150, 133);
            this.button_RechercherParNumeroVol.Name = "button_RechercherParNumeroVol";
            this.button_RechercherParNumeroVol.Size = new System.Drawing.Size(75, 23);
            this.button_RechercherParNumeroVol.TabIndex = 14;
            this.button_RechercherParNumeroVol.Text = "Rechercher";
            this.button_RechercherParNumeroVol.UseVisualStyleBackColor = true;
            this.button_RechercherParNumeroVol.Click += new System.EventHandler(this.button_RechercherParNumeroVol_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            363817,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numéro Vol";
            // 
            // button_RechercherParDateOuCompagnie
            // 
            this.button_RechercherParDateOuCompagnie.Location = new System.Drawing.Point(192, 223);
            this.button_RechercherParDateOuCompagnie.Name = "button_RechercherParDateOuCompagnie";
            this.button_RechercherParDateOuCompagnie.Size = new System.Drawing.Size(75, 23);
            this.button_RechercherParDateOuCompagnie.TabIndex = 15;
            this.button_RechercherParDateOuCompagnie.Text = "Rechercher";
            this.button_RechercherParDateOuCompagnie.UseVisualStyleBackColor = true;
            this.button_RechercherParDateOuCompagnie.Click += new System.EventHandler(this.button_RechercherParDateOuCompagnie_Click);
            // 
            // dataGridView_listeDeVols
            // 
            this.dataGridView_listeDeVols.AllowUserToAddRows = false;
            this.dataGridView_listeDeVols.AllowUserToDeleteRows = false;
            this.dataGridView_listeDeVols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listeDeVols.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_listeDeVols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeDeVols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.date,
            this.cie,
            this.code_cie,
            this.ligne,
            this.detail_link});
            this.dataGridView_listeDeVols.EnableHeadersVisualStyles = false;
            this.dataGridView_listeDeVols.Location = new System.Drawing.Point(403, 34);
            this.dataGridView_listeDeVols.Name = "dataGridView_listeDeVols";
            this.dataGridView_listeDeVols.RowHeadersVisible = false;
            this.dataGridView_listeDeVols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listeDeVols.Size = new System.Drawing.Size(592, 288);
            this.dataGridView_listeDeVols.TabIndex = 16;
            this.dataGridView_listeDeVols.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listeDeVols_CellContentClick);
            // 
            // index
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.index.DefaultCellStyle = dataGridViewCellStyle7;
            this.index.HeaderText = "";
            this.index.Name = "index";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // cie
            // 
            this.cie.HeaderText = "Compagnie";
            this.cie.Name = "cie";
            // 
            // code_cie
            // 
            this.code_cie.HeaderText = "Code compagnie";
            this.code_cie.Name = "code_cie";
            // 
            // ligne
            // 
            this.ligne.HeaderText = "N° ligne";
            this.ligne.Name = "ligne";
            // 
            // detail_link
            // 
            this.detail_link.HeaderText = "Rechercher les bagages";
            this.detail_link.Image = global::MyAirport.Client.Properties.Resources.image_lien;
            this.detail_link.Name = "detail_link";
            // 
            // VolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 335);
            this.Controls.Add(this.dataGridView_listeDeVols);
            this.Controls.Add(this.tabControl1);
            this.Name = "VolForm";
            this.Text = "Recherche Vol";
            this.Load += new System.EventHandler(this.VolForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeDeVols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_compagnie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_RechercherParNumeroVol;
        private System.Windows.Forms.Button button_RechercherParDateOuCompagnie;
        private System.Windows.Forms.DataGridView dataGridView_listeDeVols;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cie;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_cie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligne;
        private System.Windows.Forms.DataGridViewImageColumn detail_link;
    }
}

