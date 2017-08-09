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
using System.IO;
using System.Net;

namespace FMN_Editor
{
    public partial class Form_Sponsoren : Form
    {
        private MySqlConnection con;
        private DataTable land1, land2;
        private MySqlDataReader DR_idSponsor;
        private MySqlDataAdapter ld1, ld2, ID;
        private MySqlCommandBuilder commandland1, commandland2;
        private String constring;
        private Int16 SponsorID;

        public Form_Sponsoren()
        {
            InitializeComponent();
        }
        public int SponsorenID
        {
            get;
            set;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Sponsoren_Load(object sender, EventArgs e)
        {
            // Checken ob ein Sponsor hinzugefügt oder aktualisiert werden soll
            if (SponsorenID == 0)
            {

                //Verbindung zu  SQL-Datenbank wird aufgebaut
                constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
                con = new MySqlConnection(constring);
                con.Open();


                // Data Table für die erste Combobox wird erstellt und die Combobox anschließend mit allen Ländern gefüllt.
                land1 = new DataTable();

                ld1 = new MySqlDataAdapter("SELECT * FROM countries ", con);
                commandland1 = new MySqlCommandBuilder(ld1);

                ld1.Fill(land1);

                land2 = new DataTable();
                ld2 = new MySqlDataAdapter("SELECT * FROM countries ", con);
                commandland2 = new MySqlCommandBuilder(ld2);

                ld2.Fill(land2);
                //Abrufen der letzten verwendeten Sponsoren ID
                MySqlCommand commandID = new MySqlCommand("SELECT ID FROM sponsor_stamm ORDER BY ID DESC LIMIT 1", con);
                DR_idSponsor = commandID.ExecuteReader();
                DR_idSponsor.Read();
                SponsorID = DR_idSponsor.GetInt16(0);
                DR_idSponsor.Close();

                //Erhöhen der Sponsoren ID um 1, damit die neue ID angezeigt werden kann
                SponsorID++;
                lbl_sponsor_id.Text = Convert.ToString(SponsorID);

                //Einfügen der aus der DB abgerufenen Ländern Werten
                cB_sponsorland.DisplayMember = "Name";
                cB_sponsorland.DataSource = land1;
                cB_sponsorvereinland.DisplayMember = "Name";
                cB_sponsorvereinland.DataSource = land2;

            }
            else
            {
                // HIER MUSS NOCH DIE LOGIK ZUM SPONSOREN UPDATE IMPLEMENTIERT WERDEN. HIERZU MUSS ZUNÄCHST EIN DATENSATZ ERSTELLT WERDEN UM DAS ZU PRÜFEN
            }   
          
        }

        private void cB_sponsorvereinland_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

            
        }

        private void cB_sponsorland_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wenn Sich das Land des Sponsors ändert werden die zugehörigen Städte aus der DB abgerufen
            String land1short, land;
             MySqlCommand landkurz;
            DataTable staedteland;
             MySqlDataAdapter DA_staedteland;
             MySqlCommandBuilder CB_staedteland;

            //Die Städte des jeweiligen Landes werden in die 1. Stadt Combobox übertragen mithilfe eines anderen SQL-Befehls
            land = cB_sponsorland.Text.ToString();
            landkurz = new MySqlCommand("SELECT Short FROM countries WHERE Name ='" + land + "'", con);
            land1short = landkurz.ExecuteScalar().ToString();

            staedteland = new DataTable();
            DA_staedteland = new  MySqlDataAdapter("SELECT * FROM citys WHERE country = '"+ land1short + "'", con);
            CB_staedteland = new  MySqlCommandBuilder(DA_staedteland);
            DA_staedteland.Fill(staedteland);

            cBx_sponsorstadt.DataSource = staedteland;
            cBx_sponsorstadt.DisplayMember = "city";
            

        }

        private void btn_sponsorenhinzufuegen_Click(object sender, EventArgs e)
        {
            //Über diesen Button wird der Sponsor in die Datenbank eingefügt, hierzu werden zunächst die Werte aus den Eingabefeldern an Variablen übergeben,
            //diese werden dann genutzt um die Daten in die DB zu schreiben.
            String Name, Branche, Land, Stadt, Verein;
            Int16 Groesse, Verbreitung, Hauptsponsor, Topsponsor, Mediumsegment, Kleinsponsor, Bandenwerbung, Spielsponsor, Medienpartner, Ausruester, Stadionname; //Farbe1, Farbe2;
            Boolean Hauptsponsor_Boolean, Topsponsor_Boolean, Mediumsegment_Boolean, Kleinsponsor_Boolean, Bandenwerbung_Boolean, Spielsponsor_Boolean, Medienpartner_Boolean, Ausruester_Boolean, Stadionname_Boolean, Logo, Bande1, Bande2;

            Name = tB_sponsorname.Text;
            Branche = cBx_sponsorbranche.Text;
            Groesse = Convert.ToInt16(cBx_sponsorgroesse.SelectedIndex);
            Land = cB_sponsorland.Text;
            Stadt = cBx_sponsorstadt.Text;
            Verein = cB_sponsorverein.Text;
            Verbreitung = Convert.ToInt16(cB_sponsorverbreitung.SelectedIndex);
            Hauptsponsor_Boolean = chB_sponsorarthaupt.Checked;
            Topsponsor_Boolean = chB_sponsorarttop.Checked;
            Mediumsegment_Boolean = chB_sponsorartmedium.Checked;
            Kleinsponsor_Boolean = chB_sponsorartklein.Checked;
            Bandenwerbung_Boolean = chB_sponsorartbande.Checked;
            Spielsponsor_Boolean = chB_sponsorartspiel.Checked;
            Medienpartner_Boolean = chB_sponsorartmedien.Checked;
            Ausruester_Boolean = chB_sponsorartausruester.Checked;
            Stadionname_Boolean = chB_sponsorartstadion.Checked;

            //Festlegung der Werte für die DB bzgl. der Sponsorenart die für den jeweiligen Sponsor in Frage kommt

            if (Hauptsponsor_Boolean == true)
            {
                Hauptsponsor = 1;
            }
            else
            {
                Hauptsponsor = 0;
            }
            if (Topsponsor_Boolean == true)
            {
                Topsponsor = 1;
            }
            else
            {
                Topsponsor = 0;
            }
            if (Mediumsegment_Boolean == true)
            {
                Mediumsegment = 1;
            }
            else
            {
                Mediumsegment = 0;
            }
            if (Kleinsponsor_Boolean == true)
            {
                Kleinsponsor = 1;
            }
            else
            {
                Kleinsponsor = 0;
            }
            if (Bandenwerbung_Boolean == true)
            {
                Bandenwerbung = 1;
            }
            else
            {
                Bandenwerbung = 0;
            }
            if (Spielsponsor_Boolean == true)
            {
                Spielsponsor = 1;
            }
            else
            {
                Spielsponsor = 0;
            }
            if (Medienpartner_Boolean == true)
            {
                Medienpartner = 1;
            }
            else
            {
                Medienpartner = 0;
            }
            if (Ausruester_Boolean == true)
            {
                Ausruester = 1;
            }
            else
            {
                Ausruester = 0;
            }
            if (Stadionname_Boolean == true)
            {
                Stadionname = 1;
            }
            else
            {
                Stadionname = 0;
            }

            //Hier wird überprüft welche Grafiken für den jeweiligen Sponsor ausgewählt wurden um eine korrekte Zuordnung in der DB zu ermöglichen

            if (pB_sponsorlogo.Image == null)
            {
                Logo = false;
            }
            else
            {
                Logo = true;
            }

            if (pB_sponsorbande1.Image == null)
            {
                Bande1 = false;
            }
            else
            {
                Bande1 = true;
            }

            if (pB_sponsorbande2.Image == null)
            {
                Bande2 = false;
            }
            else
            {
                Bande2 = true;
            }
    //Upload der Werte in SQL-Datenbank

            
        }


        private void bt_logoauswaehlen_Click(object sender, EventArgs e)
        {

            Stream  Stream = null;
            OpenFileDialog Logo_auswaehlen = new OpenFileDialog();
            Image Logo;
            Int16 High, Width;

            //Logo_auswaehlen.OpenFile();
            Logo_auswaehlen.InitialDirectory = "C:\\";
            Logo_auswaehlen.Filter = "png files (*.png)|*.png";
            Logo_auswaehlen.FilterIndex = 1;
            Logo_auswaehlen.RestoreDirectory = true;
   if(Logo_auswaehlen.ShowDialog() == DialogResult.OK)
    {
        try
        {
            if (( Stream = Logo_auswaehlen.OpenFile()) != null)
            {
                using ( Stream)
               {

                 Logo= Image.FromStream( Stream);
                 Width = Convert.ToInt16(Logo.Width);
                 High = Convert.ToInt16(Logo.Height);

                 if (Width == 256 && High == 256)
                 {
                     pB_sponsorlogo.Image = Logo;
                 }
                 else
                 {
                     MessageBox.Show("Fehler: Die Größe des Bildes stimmt nicht mit den geforderten Maßen überein!");                    
                 }

               }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }

     }
    }

        private void btn_Farbe2_Click(object sender, EventArgs e)
        {
        
        if (ColDialog_Farbe2.ShowDialog() == DialogResult.OK)
            {
                picBox_Farbe2.BackColor = ColDialog_Farbe2.Color;

            }
        }

        private void btn_Farbe1_Click(object sender, EventArgs e)
        {
            if (colDialog_Farbe1.ShowDialog() == DialogResult.OK)
            {
                picBox_Farbe1.BackColor = colDialog_Farbe1.Color;

            }
        }

        private void btn_sponsorbande2_Click(object sender, EventArgs e)
        {
            Stream Stream = null;
            OpenFileDialog Logo_auswaehlen = new OpenFileDialog();
            
            Image gifimage;
            Int16 High, Width;

            //Logo_auswaehlen.OpenFile();
            Logo_auswaehlen.InitialDirectory = "C:\\";
            Logo_auswaehlen.Filter = ".png files (*.png)|*.png|.gif file(*.gif)|*.gif";
            Logo_auswaehlen.FilterIndex = 1;
            Logo_auswaehlen.RestoreDirectory = true;
            if (Logo_auswaehlen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((Stream = Logo_auswaehlen.OpenFile()) != null)
                    {
                        using (Stream)
                        {

                            gifimage = Image.FromStream(Stream);
                            Width = Convert.ToInt16(gifimage.Width);
                            High = Convert.ToInt16(gifimage.Height);

                            if (Width == 256 && High == 256)
                            {
                            pB_sponsorbande2.Image = gifimage;
                            }
                            else
                            {
                                MessageBox.Show("Fehler: Die Größe des Bildes stimmt nicht mit den geforderten Maßen überein!");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void btn_sponsorbande1_Click(object sender, EventArgs e)
        {

        }
    }
}