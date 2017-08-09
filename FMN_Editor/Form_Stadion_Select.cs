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
    public partial class Form_Stadion_Select : Form
    {
        private  MySqlConnection con;
        private DataTable data;
        private  MySqlDataAdapter da;
        private  MySqlCommandBuilder command;
        private String constring;

        public Form_Stadion_Select()
        {
            InitializeComponent();
        }

        private void btn_schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Stadionaendern_Load(object sender, EventArgs e)
        {
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();

            data = new DataTable();

            da = new MySqlDataAdapter("SELECT * FROM countries ", con);
            command = new  MySqlCommandBuilder(da);

            da.Fill(data);
            cB_land.DisplayMember = "Name";
            cB_land.DataSource = data;

        }
    }
}
