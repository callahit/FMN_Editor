namespace FMN_Editor
{
    partial class Form_Stadion_Select
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
            this.cB_land = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liB_stadion = new System.Windows.Forms.ListBox();
            this.btn_stadionaendern = new System.Windows.Forms.Button();
            this.btn_schliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cB_land
            // 
            this.cB_land.FormattingEnabled = true;
            this.cB_land.Location = new System.Drawing.Point(12, 33);
            this.cB_land.Name = "cB_land";
            this.cB_land.Size = new System.Drawing.Size(279, 21);
            this.cB_land.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Land";
            // 
            // liB_stadion
            // 
            this.liB_stadion.FormattingEnabled = true;
            this.liB_stadion.Location = new System.Drawing.Point(13, 61);
            this.liB_stadion.Name = "liB_stadion";
            this.liB_stadion.Size = new System.Drawing.Size(278, 355);
            this.liB_stadion.TabIndex = 2;
            // 
            // btn_stadionaendern
            // 
            this.btn_stadionaendern.Location = new System.Drawing.Point(13, 422);
            this.btn_stadionaendern.Name = "btn_stadionaendern";
            this.btn_stadionaendern.Size = new System.Drawing.Size(75, 23);
            this.btn_stadionaendern.TabIndex = 3;
            this.btn_stadionaendern.Text = "Stadion ändern";
            this.btn_stadionaendern.UseVisualStyleBackColor = true;
            // 
            // btn_schliessen
            // 
            this.btn_schliessen.Location = new System.Drawing.Point(216, 422);
            this.btn_schliessen.Name = "btn_schliessen";
            this.btn_schliessen.Size = new System.Drawing.Size(75, 23);
            this.btn_schliessen.TabIndex = 4;
            this.btn_schliessen.Text = "Schließen";
            this.btn_schliessen.UseVisualStyleBackColor = true;
            this.btn_schliessen.Click += new System.EventHandler(this.btn_schliessen_Click);
            // 
            // Form_Stadionaendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 453);
            this.Controls.Add(this.btn_schliessen);
            this.Controls.Add(this.btn_stadionaendern);
            this.Controls.Add(this.liB_stadion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_land);
            this.Name = "Form_Stadionaendern";
            this.Text = "Stadion auswählen";
            this.Load += new System.EventHandler(this.Form_Stadionaendern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_land;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox liB_stadion;
        private System.Windows.Forms.Button btn_stadionaendern;
        private System.Windows.Forms.Button btn_schliessen;
    }
}