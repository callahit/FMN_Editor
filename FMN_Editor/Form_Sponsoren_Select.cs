using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace FMN_Editor
{
    public partial class Form_Sponsoren_Select : Form
    {
        public Form_Sponsoren_Select()
        {
            InitializeComponent();
           
        }

        public int SponsorenID
        {
            get;
            set;
        }

        private void btn_schließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sponsor_Click(object sender, EventArgs e)
        {
            Form_Sponsoren Sponsor = new Form_Sponsoren();
            Sponsor.ShowDialog();
            SponsorenID = 0;
        }

        private void Sponsoren_Load(object sender, EventArgs e)
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

            ld1 = new MySqlDataAdapter("SELECT * FROM countries ", con);
            commandland1 = new  MySqlCommandBuilder(ld1);

            ld1.Fill(land1);
            cB_land.DisplayMember = "Name";
            cB_land.DataSource = land1;
            con.Close();
        
        
    }
}
}