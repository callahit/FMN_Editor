namespace FMN_Editor
{
    partial class Form_Spieler_Select
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_prominent = new System.Windows.Forms.Button();
            this.dGV_prominente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cB_land = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_prominente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nach Nationalität auswählen:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Schließen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_prominent
            // 
            this.btn_prominent.Location = new System.Drawing.Point(269, 432);
            this.btn_prominent.Name = "btn_prominent";
            this.btn_prominent.Size = new System.Drawing.Size(125, 23);
            this.btn_prominent.TabIndex = 7;
            this.btn_prominent.Text = "Spieler hinzufügen";
            this.btn_prominent.UseVisualStyleBackColor = true;
            // 
            // dGV_prominente
            // 
            this.dGV_prominente.AllowUserToAddRows = false;
            this.dGV_prominente.AllowUserToDeleteRows = false;
            this.dGV_prominente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_prominente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vorname,
            this.Nachname});
            this.dGV_prominente.Location = new System.Drawing.Point(4, 91);
            this.dGV_prominente.MinimumSize = new System.Drawing.Size(127, 0);
            this.dGV_prominente.MultiSelect = false;
            this.dGV_prominente.Name = "dGV_prominente";
            this.dGV_prominente.ReadOnly = true;
            this.dGV_prominente.RowHeadersVisible = false;
            this.dGV_prominente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_prominente.Size = new System.Drawing.Size(471, 335);
            this.dGV_prominente.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 110;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 120;
            // 
            // cB_land
            // 
            this.cB_land.FormattingEnabled = true;
            this.cB_land.Location = new System.Drawing.Point(163, 4);
            this.cB_land.Name = "cB_land";
            this.cB_land.Size = new System.Drawing.Size(312, 21);
            this.cB_land.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nach Verein auswählen:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // Form_Spieler_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 465);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_prominent);
            this.Controls.Add(this.dGV_prominente);
            this.Controls.Add(this.cB_land);
            this.Name = "Form_Spieler_Select";
            this.Text = "Spieler auswählen / hinzufügen";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_prominente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_prominent;
        private System.Windows.Forms.DataGridView dGV_prominente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.ComboBox cB_land;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}