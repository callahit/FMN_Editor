namespace FMN_Editor
{
    partial class Form_TV_Select
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
            this.btn_schließen = new System.Windows.Forms.Button();
            this.btn_Sponsor = new System.Windows.Forms.Button();
            this.cB_land = new System.Windows.Forms.ComboBox();
            this.DGV_Sposoren = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sposoren)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_schließen
            // 
            this.btn_schließen.Location = new System.Drawing.Point(164, 326);
            this.btn_schließen.Name = "btn_schließen";
            this.btn_schließen.Size = new System.Drawing.Size(75, 23);
            this.btn_schließen.TabIndex = 7;
            this.btn_schließen.Text = "Schließen";
            this.btn_schließen.UseVisualStyleBackColor = true;
            // 
            // btn_Sponsor
            // 
            this.btn_Sponsor.Location = new System.Drawing.Point(2, 326);
            this.btn_Sponsor.Name = "btn_Sponsor";
            this.btn_Sponsor.Size = new System.Drawing.Size(156, 23);
            this.btn_Sponsor.TabIndex = 6;
            this.btn_Sponsor.Text = "Fernsehsender hinzufügen";
            this.btn_Sponsor.UseVisualStyleBackColor = true;
            // 
            // cB_land
            // 
            this.cB_land.FormattingEnabled = true;
            this.cB_land.Location = new System.Drawing.Point(2, 7);
            this.cB_land.Name = "cB_land";
            this.cB_land.Size = new System.Drawing.Size(240, 21);
            this.cB_land.TabIndex = 5;
            // 
            // DGV_Sposoren
            // 
            this.DGV_Sposoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sposoren.Location = new System.Drawing.Point(2, 37);
            this.DGV_Sposoren.Name = "DGV_Sposoren";
            this.DGV_Sposoren.Size = new System.Drawing.Size(240, 283);
            this.DGV_Sposoren.TabIndex = 4;
            // 
            // Form_TV_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 358);
            this.Controls.Add(this.btn_schließen);
            this.Controls.Add(this.btn_Sponsor);
            this.Controls.Add(this.cB_land);
            this.Controls.Add(this.DGV_Sposoren);
            this.Name = "Form_TV_Select";
            this.Text = "Fernsehsender hinzufügen / ändern";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sposoren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_schließen;
        private System.Windows.Forms.Button btn_Sponsor;
        private System.Windows.Forms.ComboBox cB_land;
        private System.Windows.Forms.DataGridView DGV_Sposoren;
    }
}