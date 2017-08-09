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
    public partial class Form_Stadion : Form
    {
        public Form_Stadion()
        {
            InitializeComponent();
        }

        private void btn_stadionschließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_stadionhinzufuegen_Click(object sender, EventArgs e)
        {

        }

        private void Form_Stadion_Load(object sender, EventArgs e)
        {
            
        }

    } 
}
