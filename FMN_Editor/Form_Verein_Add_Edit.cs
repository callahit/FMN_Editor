using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ColorComboBoxApp;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FMN_Editor
{

   
    public partial class Form_Verein : Form
    { 
        public Form_Verein()
        {
            InitializeComponent();
        }

        private void btn_schließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Verein_Load(object sender, EventArgs e)
        {
            

         }

        private void btn_bezTicker_Click(object sender, EventArgs e)
        {

        }

        private void btn_bezArt_Click(object sender, EventArgs e)
        {

        }

        private void btn_stadionhin_Click(object sender, EventArgs e)
        {

        }

       
     }
}
