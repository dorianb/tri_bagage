namespace MyAirport.Client
{
    partial class MainForm
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
            this.button_param = new System.Windows.Forms.Button();
            this.button_vol = new System.Windows.Forms.Button();
            this.button_bagage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_param
            // 
            this.button_param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_param.Location = new System.Drawing.Point(112, 57);
            this.button_param.Name = "button_param";
            this.button_param.Size = new System.Drawing.Size(150, 23);
            this.button_param.TabIndex = 0;
            this.button_param.Text = "Paramétrage";
            this.button_param.UseVisualStyleBackColor = true;
            this.button_param.Click += new System.EventHandler(this.button_param_Click);
            // 
            // button_vol
            // 
            this.button_vol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_vol.Location = new System.Drawing.Point(112, 118);
            this.button_vol.Name = "button_vol";
            this.button_vol.Size = new System.Drawing.Size(150, 23);
            this.button_vol.TabIndex = 1;
            this.button_vol.Text = "Recherche Vol";
            this.button_vol.UseVisualStyleBackColor = true;
            this.button_vol.Click += new System.EventHandler(this.button_vol_Click);
            // 
            // button_bagage
            // 
            this.button_bagage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bagage.Location = new System.Drawing.Point(112, 184);
            this.button_bagage.Name = "button_bagage";
            this.button_bagage.Size = new System.Drawing.Size(150, 23);
            this.button_bagage.TabIndex = 2;
            this.button_bagage.Text = "Recherche Bagage";
            this.button_bagage.UseVisualStyleBackColor = true;
            this.button_bagage.Click += new System.EventHandler(this.button_bagage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button_bagage);
            this.Controls.Add(this.button_vol);
            this.Controls.Add(this.button_param);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Aéroport de Paris - Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_param;
        private System.Windows.Forms.Button button_vol;
        private System.Windows.Forms.Button button_bagage;
    }
}