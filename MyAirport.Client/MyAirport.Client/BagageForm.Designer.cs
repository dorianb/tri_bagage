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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lien = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox_filtrage = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_volDepart = new System.Windows.Forms.Label();
            this.label_compagnie = new System.Windows.Forms.Label();
            this.comboBox_compagnie = new System.Windows.Forms.ComboBox();
            this.button_RAZ = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_filtrage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IATA,
            this.Vol,
            this.Loca,
            this.Statut,
            this.Rec,
            this.sortie,
            this.lien});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 227);
            this.dataGridView1.TabIndex = 0;
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
            this.Statut.HeaderText = "Statut sureté";
            this.Statut.Name = "Statut";
            // 
            // Rec
            // 
            this.Rec.HeaderText = "Rec";
            this.Rec.Name = "Rec";
            // 
            // sortie
            // 
            this.sortie.HeaderText = "Sortie de trie";
            this.sortie.Name = "sortie";
            // 
            // lien
            // 
            this.lien.HeaderText = "Lien";
            this.lien.Name = "lien";
            // 
            // groupBox_filtrage
            // 
            this.groupBox_filtrage.Controls.Add(this.button_apply);
            this.groupBox_filtrage.Controls.Add(this.button_RAZ);
            this.groupBox_filtrage.Controls.Add(this.comboBox_compagnie);
            this.groupBox_filtrage.Controls.Add(this.label_compagnie);
            this.groupBox_filtrage.Controls.Add(this.label_volDepart);
            this.groupBox_filtrage.Controls.Add(this.comboBox1);
            this.groupBox_filtrage.Location = new System.Drawing.Point(12, 35);
            this.groupBox_filtrage.Name = "groupBox_filtrage";
            this.groupBox_filtrage.Size = new System.Drawing.Size(945, 177);
            this.groupBox_filtrage.TabIndex = 1;
            this.groupBox_filtrage.TabStop = false;
            this.groupBox_filtrage.Text = "Filtrage";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label_volDepart
            // 
            this.label_volDepart.AutoSize = true;
            this.label_volDepart.Location = new System.Drawing.Point(22, 94);
            this.label_volDepart.Name = "label_volDepart";
            this.label_volDepart.Size = new System.Drawing.Size(70, 13);
            this.label_volDepart.TabIndex = 1;
            this.label_volDepart.Text = "Vol au départ";
            // 
            // label_compagnie
            // 
            this.label_compagnie.AutoSize = true;
            this.label_compagnie.Location = new System.Drawing.Point(22, 53);
            this.label_compagnie.Name = "label_compagnie";
            this.label_compagnie.Size = new System.Drawing.Size(60, 13);
            this.label_compagnie.TabIndex = 2;
            this.label_compagnie.Text = "Compagnie";
            // 
            // comboBox_compagnie
            // 
            this.comboBox_compagnie.FormattingEnabled = true;
            this.comboBox_compagnie.Items.AddRange(new object[] {
            "QATAR AIRWAYS"});
            this.comboBox_compagnie.Location = new System.Drawing.Point(112, 53);
            this.comboBox_compagnie.Name = "comboBox_compagnie";
            this.comboBox_compagnie.Size = new System.Drawing.Size(160, 21);
            this.comboBox_compagnie.TabIndex = 3;
            // 
            // button_RAZ
            // 
            this.button_RAZ.Location = new System.Drawing.Point(535, 145);
            this.button_RAZ.Name = "button_RAZ";
            this.button_RAZ.Size = new System.Drawing.Size(75, 23);
            this.button_RAZ.TabIndex = 4;
            this.button_RAZ.Text = "RAZ";
            this.button_RAZ.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(333, 145);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Appliquer";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // BagageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 444);
            this.Controls.Add(this.groupBox_filtrage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BagageForm";
            this.Text = "Liste des bagages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_filtrage.ResumeLayout(false);
            this.groupBox_filtrage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortie;
        private System.Windows.Forms.DataGridViewLinkColumn lien;
        private System.Windows.Forms.GroupBox groupBox_filtrage;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_RAZ;
        private System.Windows.Forms.ComboBox comboBox_compagnie;
        private System.Windows.Forms.Label label_compagnie;
        private System.Windows.Forms.Label label_volDepart;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}