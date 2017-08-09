namespace FMN_Editor
{
    partial class Form_Prominente_Select
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
            this.components = new System.ComponentModel.Container();
            this.cB_land = new System.Windows.Forms.ComboBox();
            this.dGV_prominente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMS_Promi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promiBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promiLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_prominent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_prominente)).BeginInit();
            this.cMS_Promi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB_land
            // 
            this.cB_land.FormattingEnabled = true;
            this.cB_land.Location = new System.Drawing.Point(12, 21);
            this.cB_land.Name = "cB_land";
            this.cB_land.Size = new System.Drawing.Size(259, 21);
            this.cB_land.TabIndex = 0;
            this.cB_land.SelectedIndexChanged += new System.EventHandler(this.cB_land_SelectedIndexChanged);
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
            this.dGV_prominente.Location = new System.Drawing.Point(12, 48);
            this.dGV_prominente.MinimumSize = new System.Drawing.Size(127, 0);
            this.dGV_prominente.MultiSelect = false;
            this.dGV_prominente.Name = "dGV_prominente";
            this.dGV_prominente.ReadOnly = true;
            this.dGV_prominente.RowHeadersVisible = false;
            this.dGV_prominente.RowTemplate.ContextMenuStrip = this.cMS_Promi;
            this.dGV_prominente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_prominente.Size = new System.Drawing.Size(259, 335);
            this.dGV_prominente.TabIndex = 1;
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
            // cMS_Promi
            // 
            this.cMS_Promi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promiBearbeitenToolStripMenuItem,
            this.promiLöschenToolStripMenuItem});
            this.cMS_Promi.Name = "cMS_Promi";
            this.cMS_Promi.Size = new System.Drawing.Size(166, 48);
            // 
            // promiBearbeitenToolStripMenuItem
            // 
            this.promiBearbeitenToolStripMenuItem.Name = "promiBearbeitenToolStripMenuItem";
            this.promiBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.promiBearbeitenToolStripMenuItem.Text = "Promi bearbeiten";
            this.promiBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.promiBearbeitenToolStripMenuItem_Click);
            // 
            // promiLöschenToolStripMenuItem
            // 
            this.promiLöschenToolStripMenuItem.Name = "promiLöschenToolStripMenuItem";
            this.promiLöschenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.promiLöschenToolStripMenuItem.Text = "Promi löschen";
            this.promiLöschenToolStripMenuItem.Click += new System.EventHandler(this.promiLöschenToolStripMenuItem_Click);
            // 
            // btn_prominent
            // 
            this.btn_prominent.Location = new System.Drawing.Point(66, 390);
            this.btn_prominent.Name = "btn_prominent";
            this.btn_prominent.Size = new System.Drawing.Size(125, 23);
            this.btn_prominent.TabIndex = 2;
            this.btn_prominent.Text = "Prominente hinzufügen";
            this.btn_prominent.UseVisualStyleBackColor = true;
            this.btn_prominent.Click += new System.EventHandler(this.btn_prominent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Schließen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Land auswählen:";
            // 
            // Form_Prominente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_prominent);
            this.Controls.Add(this.dGV_prominente);
            this.Controls.Add(this.cB_land);
            this.Name = "Form_Prominente";
            this.Text = "Form_Prominente";
            this.Load += new System.EventHandler(this.Form_Prominente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_prominente)).EndInit();
            this.cMS_Promi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_land;
        private System.Windows.Forms.DataGridView dGV_prominente;
        private System.Windows.Forms.Button btn_prominent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cMS_Promi;
        private System.Windows.Forms.ToolStripMenuItem promiBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promiLöschenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
    }
}