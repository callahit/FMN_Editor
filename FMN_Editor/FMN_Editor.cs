using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;



namespace FMN_Editor
{
    public partial class FMN_Editor : Form
    {
        private MySqlConnection con;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder command;
        private String constring;
        public FMN_Editor()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_TEAMS.ContextMenuStrip = ContextMS_TEAM;
                   
        }

        public void CB_Kontinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
        
         con = new  MySqlConnection(constring);
         con.Open();

         data = new DataTable();
           
         da = new  MySqlDataAdapter("SELECT * FROM countries WHERE Kontinent ='" + CB_Kontinent.SelectedItem.ToString() + "'", con);
         command = new  MySqlCommandBuilder(da);

          
         da.Fill(data);
         lstBx_Laender.DisplayMember = "Name";
         lstBx_Laender.DataSource = data;
        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Spieler Spieler = new Form_Spieler();
            Spieler.ShowDialog();
            
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vereinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Verein Verein = new Form_Verein();
            Verein.ShowDialog();
           
        }

        private void stadionÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Stadion_Select Stadionliste = new Form_Stadion_Select();
            Stadionliste.ShowDialog();
        }

        private void stadionHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Stadion Stadion = new Form_Stadion();
            Stadion.ShowDialog();
        }

        private void hinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sponsoren_Select Sponsor = new Form_Sponsoren_Select();
            Sponsor.ShowDialog();
        }

        private void prominenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Prominente_Select Prominente = new Form_Prominente_Select();
            Prominente.ShowDialog();
        }

        private void teamHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Verein Verein = new Form_Verein();
            Verein.ShowDialog();
        }

        private void teamBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Verein Verein = new Form_Verein();
            Verein.ShowDialog();
        }

        private void sponsorenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sponsoren_Select Sponsor = new Form_Sponsoren_Select();
            Sponsor.ShowDialog();
        }

        

        
    }

       
}
