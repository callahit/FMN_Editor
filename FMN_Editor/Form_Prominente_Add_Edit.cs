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
    public partial class Form_Prominente_Add_Edit : Form
    {
        private  MySqlConnection con;
        private DataTable land1, land2;
        private  MySqlDataAdapter ld1, ld2;
        private  MySqlCommandBuilder commandland1, commandland2;
        private String constring;

        public Form_Prominente_Add_Edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int PromiID
        {
            get;
            set;
        }

        private void Form_prominentehinzufuegen_Load(object sender, EventArgs e)
        {
            //Verbindung zu  SQL-Datenbank wird aufgebaut
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;
            con = new  MySqlConnection(constring);
            con.Open();

            // Data Table für die erste Combobox wird erstellt und die Combobox anschließend mit allen Ländern gefüllt.
            land1 = new DataTable();

            ld1 = new MySqlDataAdapter("SELECT * FROM countries ", con);
            commandland1 = new  MySqlCommandBuilder(ld1);

            ld1.Fill(land1);
            cB_prominentheimatland.DisplayMember = "Name";
            cB_prominentheimatland.DataSource = land1;

            // Data Table für die Auswwahl des Landes des Liblingsclub wird erstellt und die zugehörige Combobox anschließend mit allen Ländern gefüllt.
            land2 = new DataTable();

            ld2 = new MySqlDataAdapter("SELECT * FROM countries ", con);
            commandland2 = new  MySqlCommandBuilder(ld2);

            ld2.Fill(land2);
            cB_prominentlieblingsland.DisplayMember = "Name";
            cB_prominentlieblingsland.DataSource = land2;
            con.Close();

            //Eingabe der Comboboxen beschränken auf vorhandene Werte
            cB_JAHRGB.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_MONATGB.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_prominentbranche.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_prominentheimatland.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_prominentlieblingsclub.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_prominentlieblingsland.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_TAGGB.DropDownStyle = ComboBoxStyle.DropDownList;


            //Vorauswahl bei Promi-Update wird eingeführt
            if (PromiID != 0)
            {
                Int16 Heimatland;
                String Vorname, Nachname, Lieblingsverein, Branche, Tag, Monat, Jahr,  Heimatland_String;
                 MySqlDataReader DR_Prominenter, DR_Land;

                con = new  MySqlConnection(constring);
                con.Open();

                // Werte werden anhand der ID aus der Datenbank ausgelesen und anschließend den einzelen Feldern zugewiesen, so dass eine Bearbeitung ermöglicht wird

                 MySqlCommand command = new  MySqlCommand("SELECT * FROM `prominente` WHERE `ID` = ?id", con);
                command.Parameters.Add("?id",  MySqlDbType.Int16).Value = PromiID;
                DR_Prominenter = command.ExecuteReader();
                DR_Prominenter.Read();
                Vorname = DR_Prominenter.GetString(1);
                Nachname = DR_Prominenter.GetString(2);
                Tag = DR_Prominenter.GetString(3);
                Monat = DR_Prominenter.GetString(4);
                Jahr = DR_Prominenter.GetString(5);
                Branche = DR_Prominenter.GetString(7);
                Lieblingsverein = DR_Prominenter.GetString(8);
                

                //Werte aus dem DataReader zuweisen

                tB_promintvorname.Text = Convert.ToString(Vorname);
                tB_prominentnachname.Text = Convert.ToString(Nachname);
                cB_TAGGB.Text = Convert.ToString(Tag);
                cB_MONATGB.Text = Convert.ToString(Monat);
                cB_JAHRGB.Text = Convert.ToString(Jahr);
                cB_prominentbranche.Text = Convert.ToString(Branche);
                cB_prominentlieblingsclub.Text = Convert.ToString(Lieblingsverein);

                // Name des Heimatlandes aus Tabelle auslesen

                Heimatland = DR_Prominenter.GetInt16(6);
                 MySqlCommand commandld = new  MySqlCommand("SELECT Name FROM `laneder` WHERE `ID` = ?id", con);
                commandld.Parameters.Add("?id",  MySqlDbType.Int16).Value = Heimatland;
                DR_Land = commandld.ExecuteReader();
                DR_Land.Read();
                Heimatland_String = DR_Land.GetString(0);
                DR_Land.Close();
                DR_Prominenter.Close();
                //Wert für das Heimatland hinzufügen
                cB_prominentheimatland.Text = Convert.ToString(Heimatland_String); 

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String Vorname, Nachname, Heimatland, Lieblingsverein, Branche, Tag, Monat, Jahr, cmdprominent, constring;
            Int32 Tag2, Monat2, Jahr2, Pruefvariable;
            Int16 Heimatland_ID;
             MySqlConnection con;
             MySqlDataReader DR_LandID;
            constring = ConfigurationManager.ConnectionStrings["FMH_Editor"].ConnectionString;

            //Zuweisen der im Formular eigegebenen Werte an die Variablen
            Vorname = tB_promintvorname.Text.ToString();
            Nachname = tB_prominentnachname.Text.ToString();
            Heimatland = cB_prominentheimatland.Text.ToString();
            Lieblingsverein = cB_prominentlieblingsclub.Text.ToString();
            Branche = cB_prominentbranche.Text.ToString();
            Tag = cB_TAGGB.Text;
            Monat = cB_MONATGB.Text;
            Jahr = cB_JAHRGB.Text;
            Pruefvariable = 0;

            con = new  MySqlConnection(constring);
            con.Open();

            // Werte werden anhand der ID aus der Datenbank ausgelesen und anschließend den einzelen Feldern zugewiesen, so dass eine Bearbeitung ermöglicht wird

            MySqlCommand command = new MySqlCommand("SELECT * FROM countries WHERE Name = ?Name", con);
            command.Parameters.Add("?Name",  MySqlDbType.VarChar).Value = Heimatland;
            DR_LandID = command.ExecuteReader();
            DR_LandID.Read();
            Heimatland_ID = DR_LandID.GetInt16(0);
            DR_LandID.Close();



            //Fehlerabfrage um leere Daten in der Datenbank zu verhindern
            if (string.IsNullOrEmpty(tB_promintvorname.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte einen Vornamen eingeben");
            }
            if (string.IsNullOrEmpty(tB_prominentnachname.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Nachnamen eingeben");
            }
            if (string.IsNullOrEmpty(cB_TAGGB.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Geburtstag auswählen");
            }
            if (string.IsNullOrEmpty(cB_MONATGB.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Geburtstag auswählen");
            }
            if (string.IsNullOrEmpty(cB_JAHRGB.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Geburtstag auswählen");
            }
            if (string.IsNullOrEmpty(cB_prominentheimatland.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Heimatland auswählen");
            }
            if (string.IsNullOrEmpty(cB_prominentbranche.Text))
            {
                Pruefvariable = 1;
                MessageBox.Show("Bitte Branche auswählen");
            }

            if (Pruefvariable == 0)
            {

                Tag2 = Convert.ToInt32(Tag);
                Monat2 = Convert.ToInt32(Monat);
                Jahr2 = Convert.ToInt32(Jahr);
           if (PromiID != 0)
                {//SQL-Befehl erstellen und Werte hinzufügen
                     MySqlCommand prominenthinzufuegen = con.CreateCommand();
                    cmdprominent = "UPDATE Prominente  Set Vorname = '"+ Vorname +"',Nachname='"+Nachname+"', Geburtstag='"+Tag2+"',Geburtsmonat='"+Monat2+"',Geburtsjahr='"+Jahr2+"',Heimatland='"+Heimatland_ID+"',Branche='"+Branche+"',Lieblingsverein='"+Lieblingsverein+"'WHERE ID ='"+PromiID+"'";
                    prominenthinzufuegen.CommandText = cmdprominent;
                    
                    //SQL-Befehl ausführen
                    prominenthinzufuegen.ExecuteNonQuery();

                    //SQL-Verbindung schließen
                    con.Close();

                }
          else
                {
                    //SQL-Befehl erstellen und Werte hinzufügen
                     MySqlCommand prominenthinzufuegen = con.CreateCommand();
                    cmdprominent = "INSERT INTO Prominente (Vorname , Nachname, Geburtstag, Geburtsmonat, Geburtsjahr,Heimatland, Branche, Lieblingsverein) VALUES(?Vorname , ?Nachname, ?Geburtstag, ?Geburtsmonat, ?Geburtsjahr,?Heimatland, ?Branche, ?Lieblingsverein)";
                    prominenthinzufuegen.CommandText = cmdprominent;
                    prominenthinzufuegen.Parameters.Add("?Vorname",  MySqlDbType.VarChar).Value = Vorname;
                    prominenthinzufuegen.Parameters.Add("?Nachname",  MySqlDbType.VarChar).Value = Nachname;
                    prominenthinzufuegen.Parameters.Add("?Geburtstag",  MySqlDbType.Int16).Value = Tag2;
                    prominenthinzufuegen.Parameters.Add("?Geburtsmonat",  MySqlDbType.Int16).Value = Monat2;
                    prominenthinzufuegen.Parameters.Add("?Geburtsjahr",  MySqlDbType.Int16).Value = Jahr2;
                    prominenthinzufuegen.Parameters.Add("?Heimatland",  MySqlDbType.Int16).Value = Heimatland_ID;
                    prominenthinzufuegen.Parameters.Add("?Branche",  MySqlDbType.VarChar).Value = Branche;
                    prominenthinzufuegen.Parameters.Add("?Lieblingsverein",  MySqlDbType.VarChar).Value = Lieblingsverein;

                    //SQL-Befehl ausführen
                    prominenthinzufuegen.ExecuteNonQuery();

                    //SQL-Verbindung schließen
                    con.Close();
                }
                //Fenster wieder schließen
            this.Close();
            }

        }
    }
}
