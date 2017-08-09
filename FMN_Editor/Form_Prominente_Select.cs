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
    public partial class Form_Prominente_Select : Form
    {
        public Form_Prominente_Select()
        {
            InitializeComponent();
           
        }

       

        private void Form_Prominente_Load(object sender, EventArgs e)
        {
             MySqlConnection con;
            DataTable land1;
             MySqlDataAdapter ld1;
             MySqlCommandBuilder commandland1;
            String constring;

            //Verbindung zu  SQL-Datenbank wird aufgebaut
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();


            // Data Table für die erste Combobox wird erstellt und die Combobox anschließend mit allen Ländern gefüllt.
            land1 = new DataTable();

            ld1 = new  MySqlDataAdapter("SELECT * FROM countries", con);
            commandland1 = new  MySqlCommandBuilder(ld1);

            ld1.Fill(land1);
            cB_land.DisplayMember = "Name";
            cB_land.DataSource = land1;
            con.Close();
        }

        private void btn_prominent_Click(object sender, EventArgs e)
        {

            Form_Prominente_Add_Edit Prominente = new Form_Prominente_Add_Edit();
            Prominente.PromiID = 0;
            Prominente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cB_land_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            String land, constring;
            Int16 land_ID;
            DataTable prominenteland;
             MySqlDataReader DR_LandID;
             MySqlDataAdapter DA_prominenteland;
             MySqlCommandBuilder CB_prominenteland;
             MySqlConnection con;

            //Die Städte des jeweiligen Landes werden in die 1. Stadt Combobox übertragen mithilfe eines anderen SQL-Befehls
            land = cB_land.Text.ToString();
            
           
            //Die Werte für die 2. Combobox abrufen und eintragen in der Combobox
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();

            // ID des Landes abfragen um die Prominenten für das Land auszuwählen
             MySqlCommand command_land = new  MySqlCommand("SELECT * FROM countries WHERE Name = ?Name", con);
            command_land.Parameters.Add("?Name",  MySqlDbType.VarChar).Value = land;
            DR_LandID = command_land.ExecuteReader();
            DR_LandID.Read();
            land_ID = DR_LandID.GetInt16(0);
            DR_LandID.Close();

            prominenteland = new DataTable();
            DA_prominenteland = new  MySqlDataAdapter("SELECT * FROM `prominente` WHERE `Heimatland` ='"+ land_ID + "'", con);
            CB_prominenteland = new  MySqlCommandBuilder(DA_prominenteland);
            DA_prominenteland.Fill(prominenteland);
            
            //Die Werte aus der SQL-Abfrage im DataGrid einfügen und darstellen
            dGV_prominente.AutoGenerateColumns = false;
            dGV_prominente.DataSource = prominenteland;

            ID.DataPropertyName = "ID";
            Vorname.DataPropertyName = "Vorname";
            Nachname.DataPropertyName = "Nachname";
            con.Close();
             
        }

        public void promiBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ID2;
            Int16 ID;
            DataGridViewRow Prominenter = dGV_prominente.SelectedRows[0];
            ID2 = Prominenter.Cells[0].Value.ToString();
            ID = Convert.ToInt16(ID2);

            
            Form_Prominente_Add_Edit promiaendern = new Form_Prominente_Add_Edit();
            promiaendern.PromiID = ID;
            promiaendern.ShowDialog();
           
        }

        public void promiLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Markierte Zeile abspeichern um Sie übergeben zu können

            DataGridViewRow Prominenter =  dGV_prominente.SelectedRows[0];
            String ID, constring;
             MySqlConnection con;

            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();

            ID = Prominenter.Cells[0].Value.ToString();
            
            //Sicherheitsabfrage ob wirklich gelöscht werden soll

          DialogResult result = MessageBox.Show("Wollen sie den Prominenten wirklich löschen?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (result == DialogResult.Yes)
          { 
               MySqlCommand command = new  MySqlCommand("DELETE FROM `prominente` WHERE `ID` = ?id", con);
              command.Parameters.Add("?id",  SqlDbType.Int).Value = ID;
              
              command.ExecuteNonQuery();
              con.Close();
          }
        }

    }
}
