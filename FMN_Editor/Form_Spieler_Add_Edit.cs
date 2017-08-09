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
    public partial class Form_Spieler : Form
    {
        private  MySqlConnection con;
        private DataTable data, data2, datasprache1, datasprache2, datasprache3;
        private  MySqlDataAdapter dalaender, daSprache;
        private  MySqlCommandBuilder commandlaender, commandsprache;
        private String constring;

        public Form_Spieler()
        {
            InitializeComponent();
        }

        private void Form_Spieler_Load(object sender, EventArgs e)
        {
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();

            data = new DataTable();
            data2 = new DataTable();
            datasprache1 = new DataTable();
            datasprache2 = new DataTable();
            datasprache3 = new DataTable();
            dalaender = new MySqlDataAdapter("SELECT GER FROM countries ", con);
            daSprache = new MySqlDataAdapter("SELECT Sprache FROM countries", con);
            commandlaender = new  MySqlCommandBuilder(dalaender);
            commandsprache = new  MySqlCommandBuilder(daSprache);
            
            dalaender.Fill(data);
            dalaender.Fill(data2);
            daSprache.Fill(datasprache1);
            daSprache.Fill(datasprache2);
            daSprache.Fill(datasprache3);

            cb_Natio1.DisplayMember = "GER";
            cb_Natio1.DataSource = data;
            cb_Natio1.SelectedIndex = 1;
            CB_Natio2.DisplayMember = "GER";
            CB_Natio2.DataSource = data2;
            CB_Natio2.SelectedIndex = 0;

            CB_Sprache1.DisplayMember = "Sprache";
            CB_Sprache1.DataSource = datasprache1;
            cb_Sprache2.DisplayMember = "Sprache";
            cb_Sprache2.DataSource = datasprache2;
            cb_Sprache3.DisplayMember = "Sprache";
            cb_Sprache3.DataSource = datasprache3;

        }
        public void Cbx_Spielerstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_Spielerstatus.Text == "ist verliehen")
            {
                grp_verliehen.Visible = true;
                grp_wverliehen.Visible = false;
                grp_Verletzung.Visible = false;
                grp_verkauft.Visible = false;
            }

            if (Cbx_Spielerstatus.Text == "wird verliehen")
            {
                grp_verliehen.Visible = false;
                grp_wverliehen.Visible = true;
                grp_Verletzung.Visible = false;
                grp_verkauft.Visible = false;
                grp_gesperrt.Visible = false;
            }
            if (Cbx_Spielerstatus.Text == "-")
            {
                grp_verliehen.Visible = false;
                grp_wverliehen.Visible = false;
                grp_Verletzung.Visible = false;
                grp_verkauft.Visible = false;
                grp_gesperrt.Visible = false;
            }
            if (Cbx_Spielerstatus.Text == "wird verkauft")
            {
                grp_verliehen.Visible = false;
                grp_wverliehen.Visible = false;
                grp_Verletzung.Visible = false;
                grp_verkauft.Visible = true;
                grp_gesperrt.Visible = false;
            }

            if (Cbx_Spielerstatus.Text == "Verletzt")
            {
                grp_verliehen.Visible = false;
                grp_wverliehen.Visible = false;
                grp_Verletzung.Visible = true;
                grp_verkauft.Visible = false;
                grp_gesperrt.Visible = false;
            }
            if (Cbx_Spielerstatus.Text == "Gesperrt")
            {
                grp_verliehen.Visible = false;
                grp_wverliehen.Visible = false;
                grp_Verletzung.Visible = false;
                grp_verkauft.Visible = false;
                grp_gesperrt.Visible = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Verein_waehlen_Click(object sender, EventArgs e)
        {

        }

        private void bt_Verein_waehlen3_Click(object sender, EventArgs e)
        {

        }

        private void bt_verein_auswaehlen2_Click(object sender, EventArgs e)
        {

        }

        private void btn_station_hinzufuegen_Click(object sender, EventArgs e)
        {

        }

        private void bt_zufall_Click(object sender, EventArgs e)
        {

        }

        private void bt_minus15_Click(object sender, EventArgs e)
        {

        }

        private void bt_minus10_Click(object sender, EventArgs e)
        {

        }

        private void bt_minus5_Click(object sender, EventArgs e)
        {

        }

        private void bt_plus15_Click(object sender, EventArgs e)
        {

        }

        private void bt_plus10_Click(object sender, EventArgs e)
        {

        }

        private void bt_plus5_Click(object sender, EventArgs e)
        {

        }


       
       

       
      
      

        
    }
}
