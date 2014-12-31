namespace MyAirport.Client
{
    partial class BagageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_listeBagages = new System.Windows.Forms.DataGridView();
            this.groupBox_filtrage = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_statutTemporel = new System.Windows.Forms.ComboBox();
            this.comboBox_sortieEjection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_EtatEjection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_StatutSurete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TypeCreation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CodeIATA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_RAZ = new System.Windows.Forms.Button();
            this.comboBox_compagnie = new System.Windows.Forms.ComboBox();
            this.label_compagnie = new System.Windows.Forms.Label();
            this.label_volDepart = new System.Windows.Forms.Label();
            this.comboBox_VolAuDepart = new System.Windows.Forms.ComboBox();
            this.button_fermer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_link = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeBagages)).BeginInit();
            this.groupBox_filtrage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_listeBagages
            // 
            this.dataGridView_listeBagages.AllowUserToAddRows = false;
            this.dataGridView_listeBagages.AllowUserToDeleteRows = false;
            this.dataGridView_listeBagages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listeBagages.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_listeBagages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_listeBagages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeBagages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.IATA,
            this.Vol,
            this.Loca,
            this.Statut,
            this.Rec,
            this.sortie,
            this.detail_link});
            this.dataGridView_listeBagages.EnableHeadersVisualStyles = false;
            this.dataGridView_listeBagages.Location = new System.Drawing.Point(12, 333);
            this.dataGridView_listeBagages.Name = "dataGridView_listeBagages";
            this.dataGridView_listeBagages.RowHeadersVisible = false;
            this.dataGridView_listeBagages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listeBagages.Size = new System.Drawing.Size(751, 227);
            this.dataGridView_listeBagages.TabIndex = 0;
            this.dataGridView_listeBagages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_filtrage
            // 
            this.groupBox_filtrage.Controls.Add(this.dateTimePicker1);
            this.groupBox_filtrage.Controls.Add(this.label7);
            this.groupBox_filtrage.Controls.Add(this.label6);
            this.groupBox_filtrage.Controls.Add(this.comboBox_statutTemporel);
            this.groupBox_filtrage.Controls.Add(this.comboBox_sortieEjection);
            this.groupBox_filtrage.Controls.Add(this.label5);
            this.groupBox_filtrage.Controls.Add(this.comboBox_EtatEjection);
            this.groupBox_filtrage.Controls.Add(this.label4);
            this.groupBox_filtrage.Controls.Add(this.comboBox_StatutSurete);
            this.groupBox_filtrage.Controls.Add(this.label3);
            this.groupBox_filtrage.Controls.Add(this.comboBox_TypeCreation);
            this.groupBox_filtrage.Controls.Add(this.label2);
            this.groupBox_filtrage.Controls.Add(this.textBox_CodeIATA);
            this.groupBox_filtrage.Controls.Add(this.label1);
            this.groupBox_filtrage.Controls.Add(this.button_apply);
            this.groupBox_filtrage.Controls.Add(this.button_RAZ);
            this.groupBox_filtrage.Controls.Add(this.comboBox_compagnie);
            this.groupBox_filtrage.Controls.Add(this.label_compagnie);
            this.groupBox_filtrage.Controls.Add(this.label_volDepart);
            this.groupBox_filtrage.Controls.Add(this.comboBox_VolAuDepart);
            this.groupBox_filtrage.Location = new System.Drawing.Point(12, 35);
            this.groupBox_filtrage.Name = "groupBox_filtrage";
            this.groupBox_filtrage.Size = new System.Drawing.Size(751, 259);
            this.groupBox_filtrage.TabIndex = 1;
            this.groupBox_filtrage.TabStop = false;
            this.groupBox_filtrage.Text = "Filtrage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Statut temporel";
            // 
            // comboBox_statutTemporel
            // 
            this.comboBox_statutTemporel.FormattingEnabled = true;
            this.comboBox_statutTemporel.Location = new System.Drawing.Point(112, 146);
            this.comboBox_statutTemporel.Name = "comboBox_statutTemporel";
            this.comboBox_statutTemporel.Size = new System.Drawing.Size(160, 21);
            this.comboBox_statutTemporel.TabIndex = 16;
            // 
            // comboBox_sortieEjection
            // 
            this.comboBox_sortieEjection.FormattingEnabled = true;
            this.comboBox_sortieEjection.Location = new System.Drawing.Point(505, 179);
            this.comboBox_sortieEjection.Name = "comboBox_sortieEjection";
            this.comboBox_sortieEjection.Size = new System.Drawing.Size(160, 21);
            this.comboBox_sortieEjection.TabIndex = 15;
            this.comboBox_sortieEjection.Text = "Toutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sortie de tri éjection";
            // 
            // comboBox_EtatEjection
            // 
            this.comboBox_EtatEjection.FormattingEnabled = true;
            this.comboBox_EtatEjection.Location = new System.Drawing.Point(505, 141);
            this.comboBox_EtatEjection.Name = "comboBox_EtatEjection";
            this.comboBox_EtatEjection.Size = new System.Drawing.Size(160, 21);
            this.comboBox_EtatEjection.TabIndex = 13;
            this.comboBox_EtatEjection.Text = "Tous";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Etat éjection";
            // 
            // comboBox_StatutSurete
            // 
            this.comboBox_StatutSurete.FormattingEnabled = true;
            this.comboBox_StatutSurete.Location = new System.Drawing.Point(505, 103);
            this.comboBox_StatutSurete.Name = "comboBox_StatutSurete";
            this.comboBox_StatutSurete.Size = new System.Drawing.Size(160, 21);
            this.comboBox_StatutSurete.TabIndex = 11;
            this.comboBox_StatutSurete.Text = "Tous";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Statut sûreté";
            // 
            // comboBox_TypeCreation
            // 
            this.comboBox_TypeCreation.FormattingEnabled = true;
            this.comboBox_TypeCreation.Location = new System.Drawing.Point(505, 67);
            this.comboBox_TypeCreation.Name = "comboBox_TypeCreation";
            this.comboBox_TypeCreation.Size = new System.Drawing.Size(160, 21);
            this.comboBox_TypeCreation.TabIndex = 9;
            this.comboBox_TypeCreation.Text = "Tous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type création";
            // 
            // textBox_CodeIATA
            // 
            this.textBox_CodeIATA.Location = new System.Drawing.Point(505, 29);
            this.textBox_CodeIATA.Name = "textBox_CodeIATA";
            this.textBox_CodeIATA.Size = new System.Drawing.Size(133, 20);
            this.textBox_CodeIATA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code IATA";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(248, 230);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Appliquer";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_RAZ
            // 
            this.button_RAZ.Location = new System.Drawing.Point(364, 230);
            this.button_RAZ.Name = "button_RAZ";
            this.button_RAZ.Size = new System.Drawing.Size(75, 23);
            this.button_RAZ.TabIndex = 4;
            this.button_RAZ.Text = "RAZ";
            this.button_RAZ.UseVisualStyleBackColor = true;
            // 
            // comboBox_compagnie
            // 
            this.comboBox_compagnie.FormattingEnabled = true;
            this.comboBox_compagnie.Items.AddRange(new object[] {
            "QATAR AIRWAYS"});
            this.comboBox_compagnie.Location = new System.Drawing.Point(112, 106);
            this.comboBox_compagnie.Name = "comboBox_compagnie";
            this.comboBox_compagnie.Size = new System.Drawing.Size(160, 21);
            this.comboBox_compagnie.TabIndex = 3;
            this.comboBox_compagnie.Text = "QATAR AIRWAYS";
            // 
            // label_compagnie
            // 
            this.label_compagnie.AutoSize = true;
            this.label_compagnie.Location = new System.Drawing.Point(22, 106);
            this.label_compagnie.Name = "label_compagnie";
            this.label_compagnie.Size = new System.Drawing.Size(60, 13);
            this.label_compagnie.TabIndex = 2;
            this.label_compagnie.Text = "Compagnie";
            // 
            // label_volDepart
            // 
            this.label_volDepart.AutoSize = true;
            this.label_volDepart.Location = new System.Drawing.Point(22, 182);
            this.label_volDepart.Name = "label_volDepart";
            this.label_volDepart.Size = new System.Drawing.Size(70, 13);
            this.label_volDepart.TabIndex = 1;
            this.label_volDepart.Text = "Vol au départ";
            // 
            // comboBox_VolAuDepart
            // 
            this.comboBox_VolAuDepart.FormattingEnabled = true;
            this.comboBox_VolAuDepart.Location = new System.Drawing.Point(112, 179);
            this.comboBox_VolAuDepart.Name = "comboBox_VolAuDepart";
            this.comboBox_VolAuDepart.Size = new System.Drawing.Size(160, 21);
            this.comboBox_VolAuDepart.TabIndex = 0;
            this.comboBox_VolAuDepart.Text = "Tous";
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(338, 566);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 2;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Horaire théorique";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Lien";
            this.dataGridViewImageColumn1.Image = global::MyAirport.Client.Properties.Resources.image_lien;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // index
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.index.DefaultCellStyle = dataGridViewCellStyle1;
            this.index.HeaderText = "";
            this.index.Name = "index";
            // 
            // IATA
            // 
            this.IATA.HeaderText = "Code IATA";
            this.IATA.Name = "IATA";
            // 
            // Vol
            // 
            this.Vol.HeaderText = "Vol";
            this.Vol.Name = "Vol";
            // 
            // Loca
            // 
            this.Loca.HeaderText = "Loca";
            this.Loca.Name = "Loca";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut sûreté";
            this.Statut.Name = "Statut";
            // 
            // Rec
            // 
            this.Rec.HeaderText = "Rec";
            this.Rec.Name = "Rec";
            // 
            // sortie
            // 
            this.sortie.HeaderText = "Sortie de tri éjection";
            this.sortie.Name = "sortie";
            // 
            // detail_link
            // 
            this.detail_link.HeaderText = "Lien";
            this.detail_link.Image = global::MyAirport.Client.Properties.Resources.image_lien;
            this.detail_link.Name = "detail_link";
            this.detail_link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BagageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 601);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.groupBox_filtrage);
            this.Controls.Add(this.dataGridView_listeBagages);
            this.Name = "BagageForm";
            this.Text = "Liste des bagages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeBagages)).EndInit();
            this.groupBox_filtrage.ResumeLayout(false);
            this.groupBox_filtrage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listeBagages;
        private System.Windows.Forms.GroupBox groupBox_filtrage;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_RAZ;
        private System.Windows.Forms.ComboBox comboBox_compagnie;
        private System.Windows.Forms.Label label_compagnie;
        private System.Windows.Forms.Label label_volDepart;
        private System.Windows.Forms.ComboBox comboBox_VolAuDepart;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.TextBox textBox_CodeIATA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_StatutSurete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_TypeCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_sortieEjection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_EtatEjection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_statutTemporel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn IATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortie;
        private System.Windows.Forms.DataGridViewImageColumn detail_link;
    }
}