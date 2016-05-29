using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;     //Zum lesen der Config-File
using MySql.Data;               //der MySql-Connector
using System.IO;                //zum schreiben der Logfiles

namespace Stempelurhadmintest
{
    public partial class Form1 : Form
    {
        string dbserverconf_global;
        string dbnameconf_global;
        string dbuserconf_global;
        string dbpwconf_global;

        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
        MySql.Data.MySqlClient.MySqlCommand comm = new MySql.Data.MySqlClient.MySqlCommand();

        string logfilename_global;

        public Form1()
        {
            InitializeComponent();
        }

        private void init_logfile()
        {
            logfilename_global = DateTime.Now.Year.ToString("D4") + DateTime.Now.Month.ToString("D2") + DateTime.Now.Day.ToString("D2") + ".log";
            log("Programm gestartet..........................................................................");
            log("Logfile geladen.");

        }

        private void init_config()
        {
            dbserverconf_global = System.Configuration.ConfigurationManager.AppSettings["dbserver"];
            dbnameconf_global = System.Configuration.ConfigurationManager.AppSettings["dbname"];
            dbuserconf_global = System.Configuration.ConfigurationManager.AppSettings["dbuser"];
            dbpwconf_global = System.Configuration.ConfigurationManager.AppSettings["dbpw"];

            log("Config-File gelesen, Datenbankinfos gesetzt.('" + dbserverconf_global + "','" + dbnameconf_global + "','" + dbuserconf_global + "','" + dbpwconf_global + "')");
        }

        private void init_db(string server, string database, string uid, string password)
        {
            conn.ConnectionString = "SERVER = " + server + "; " + "DATABASE = " + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            log("Datenbank ConnectionString initialisiert");
        }

        private bool open_db()
        {
            try
            {
                conn.Open();
                comm.Connection = conn;
                //log("Datenbankverbindung geoeffnet. (" + conn.ToString() + ")"); //nur zu debugzwecken
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                log("Fehler beim oeffnen der Datenbank...");
                log(ex.Message);
                return false;
            }
        }

        private bool close_db()
        {
            try
            {
                conn.Close();
                //log("Datenbankverbindung geschlossen.");  //nur zu debugzwecken
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                log("Fehler beim schliessen der Datenbank...");
                log(ex.Message);
                return false;
            }
        }

        private void log(String text)
        {
            using (StreamWriter file = new StreamWriter(logfilename_global, true))
            {
                file.WriteLine(DateTime.Now.ToLongTimeString() + ": " + text);
            }
            Console.WriteLine("Log: " + DateTime.Now.ToLongTimeString() + ": " + text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // testevent in liste eintragen für merkierten tag
            int selectedCellCount = KalenderGrid_Kalender.SelectedCells.Count;
            for (int i = 0;
                i < selectedCellCount; i++)
            {
                string cellvaluestring = KalenderGrid_Kalender.SelectedCells[i].Value.ToString();
                
                if (cellvaluestring != "")
                {
                    cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                    //MessageBox.Show( cellvaluestring + "." + MonatsPicker_Kalender.Value.Month.ToString("D2")+ "." + MonatsPicker_Kalender.Value.Year.ToString("D4"));

                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell0 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell4 = new DataGridViewTextBoxCell();

                    cell0.Value = "0001";
                    cell1.Value = cellvaluestring + "." + MonatsPicker_Kalender.Value.Month.ToString("D2");
                    cell2.Value = "7.2";
                    cell3.Value = "0";
                    cell4.Value = "Testeintrag Blablabla";

                    myrow.Cells.Add(cell0);
                    myrow.Cells.Add(cell1);
                    myrow.Cells.Add(cell2);
                    myrow.Cells.Add(cell3);
                    myrow.Cells.Add(cell4);
                    Ereignisgrid_Kalender.Rows.Add(myrow);
                }
            }
        }

        private void markiereTagemitEreignissen(String PersonFilter)
        {
            string cellvaluestring = "";
            string betrachtungsjahr = MonatsPicker_Kalender.Value.Year.ToString("D4");
            string betrachtungsmonat = MonatsPicker_Kalender.Value.Month.ToString("D2");

            string thisevent_vermerk = "";
            string thisevent_tag = "";
            string thisevent_zuordnung = "";
            string thisevent_name = "";
            string thisevent_tooltipprefix = "";

            //select auf kalenderdatenbank mit betrachtungsjahr, betrachtungsmonat
            //wenn event gefunden, die entsprechende cell einfärben und den tooltip setzen

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT eventid, zuordnung, name, jahr, monat, tag, vermerk, urlaubstage_abziehen, sollzeit, storniert" +
                                " FROM kalender left join user on kalender.zuordnung = user.userid" +
                                " where jahr=@jahr AND monat=@monat AND storniert = 0";

            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = betrachtungsjahr;
            comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = betrachtungsmonat;

            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf betrachtet ein gefundenes Ereignis im Betrachtungsmonat
                while (Reader.Read())
                {
                    thisevent_tag = Reader["tag"] + "";
                    thisevent_vermerk = Reader["vermerk"] + "";
                    thisevent_zuordnung = Reader["zuordnung"] + "";
                    thisevent_name = Reader["name"] + "";

                    if (thisevent_name != "") thisevent_tooltipprefix = thisevent_name + ": ";
                   
                    //loop durch alle cellen des Kalendergrids
                    for (int actrow = 0; actrow < 6; actrow++)
                    {
                        for (int actcol = 0; actcol < 7; actcol++)
                        {
                            cellvaluestring = KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Value.ToString();
                            if(cellvaluestring != "")
                            {
                                cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                            }
                            
                            if(thisevent_tag == cellvaluestring)
                            {
                                KalenderGrid_Kalender.Rows[actrow].Cells[actcol].ToolTipText = KalenderGrid_Kalender.Rows[actrow].Cells[actcol].ToolTipText  + thisevent_tooltipprefix + thisevent_vermerk + "\r\n";
                                KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Style.BackColor = Color.Lime;
                            }
                        }
                    }
                    
                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();




        }

        private void refreshKalendergrid()
        {
            int Betrachtungsmonat = MonatsPicker_Kalender.Value.Month;
            int Betrachtungsjahr = MonatsPicker_Kalender.Value.Year;

            DateTime Betrachtungsdatum = new DateTime(Betrachtungsjahr,Betrachtungsmonat,1); //Startdate auf den ersten des Monats stellen
            int Wochentagdesersten = ((int)Betrachtungsdatum.DayOfWeek == 0) ? 7 : (int)Betrachtungsdatum.DayOfWeek; //Nummer des Wochentags des ersten des Monats (Montag = 1, etc...)

            KalenderGrid_Kalender.RowCount = 6;
            KalenderGrid_Kalender.GridColor = Color.LightGray;

            int i = 1;
            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    if((actrow == 0 && actcol + 1 < Wochentagdesersten) || i > DateTime.DaysInMonth(Betrachtungsjahr,Betrachtungsmonat))
                    {
                        KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Value = "";
                        KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Value = i.ToString();
                        KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Style.BackColor = Color.White;
                        if(actcol + 1 >= 6)
                        {
                            KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Style.BackColor = Color.Beige;
                        }
                        i++;
                    }
                    KalenderGrid_Kalender.Rows[actrow].Cells[actcol].ToolTipText = "";
                }
            }

            KalenderGrid_Kalender.ClearSelection();
            markiereTagemitEreignissen("");




            //DataGridViewRow myrow = new DataGridViewRow(); 

            //for (int i = 0; i < Wochentagdesersten -1 ; i++)
            //{
            //    DataGridViewCell mycell = new DataGridViewTextBoxCell();
            //    mycell.Value = "fill";
            //    myrow.Cells.Add(mycell);

            //}
            //dataGridView1.Rows.Add(myrow);

            //dataGridView1.Rows[0].Cells[2].Style.BackColor = Color.Aqua;

            //MessageBox.Show(Wochentagdesersten.ToString());
        }

        private void initPersonPicker_Kalender()
        {
            //TODO Datenbankverbindung herstellen
            //TODO Personen der Personentabelle dem PersonPicker hinzufügen

            string thisperson_userid = "";
            string thisperson_name = "";
            string thisperson_vorname = "";

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT userid, name, vorname FROM user where aktiv = 1";

            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf betrachtet ein gefundenes Ereignis im Betrachtungsmonat
                while (Reader.Read())
                {
                    thisperson_userid = Reader["userid"] + "";
                    thisperson_name = Reader["name"] + "";
                    thisperson_vorname= Reader["vorname"] + "";

                    PersonPicker_Kalender.Items.Add(thisperson_userid + " (" + thisperson_name + " " + thisperson_vorname + ")");
                    comboBox1.SelectedIndex = 0;

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();
        }

        private void MonatsPicker_Kalender_ValueChanged(object sender, EventArgs e)
        {
            refreshKalendergrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Logfile initialisieren
            init_logfile();

            //Config-laden
            init_config();

            //Datenbank initialisieren
            init_db(dbserverconf_global, dbnameconf_global, dbuserconf_global, dbpwconf_global);


            refreshKalendergrid();
            initPersonPicker_Kalender();
            refreshEreignisgrid_Kalender();
        }

        private void openEventEditor()
        {
            //TODO Panel anzeigen
            //TODO Felder vorbefüllen und auf update-modus stellen falls schon event vorhanden
        }

        private void PersonPicker_Kalender_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshEreignisgrid_Kalender();
        }

        private void refreshEreignisgrid_Kalender()
        {   //Alle Ereignisse zu ausgewählter Person und Jahr auflisten

            Ereignisgrid_Kalender.Rows.Clear();

            string actzuordnung = "";
            string actjahr = "";

            string thisevent_id = "";
            string thisevent_datum = "";
            string thisevent_sollzeit = "";
            string thisevent_urlaubstage = "";
            string thisevent_vermerk = "";
            bool thisevent_storniert = false;

            actjahr = MonatsPicker_Kalender.Value.Year.ToString("D4");
            if(PersonPicker_Kalender.Text != null)
            {
                actzuordnung = PersonPicker_Kalender.Text;
            }

            if(actzuordnung != "Allgemein")
            {
                actzuordnung = actzuordnung.Substring(0, 6);
            }

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT eventid, tag, monat, vermerk, sollzeit, urlaubstage_abziehen, storniert FROM kalender WHERE jahr=@jahr AND zuordnung=@zuordnung AND storniert=0 ORDER BY eventid";

            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = actjahr;
            comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = actzuordnung;

            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf betrachtet ein gefundenes Ereignis im Betrachtungsmonat
                while (Reader.Read())
                {
                    thisevent_id = Reader["eventid"] + "";
                    thisevent_datum = Reader["tag"] + "." + Reader["monat"] + ".";
                    thisevent_sollzeit = Reader["sollzeit"] + "";
                    thisevent_urlaubstage = Reader["urlaubstage_abziehen"] + "";
                    thisevent_vermerk = Reader["vermerk"] + "";
                    thisevent_storniert = (bool)Reader["storniert"];

                    //TODO Eventgrid befüllen
                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell_id = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_datum = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_sollzeit = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_urlaubstage = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_vermerk = new DataGridViewTextBoxCell();

                    cell_id.Value = thisevent_id;
                    cell_datum.Value = thisevent_datum;
                    cell_sollzeit.Value = thisevent_sollzeit;
                    cell_urlaubstage.Value = thisevent_urlaubstage;
                    cell_vermerk.Value = thisevent_vermerk;

                    myrow.Cells.Add(cell_id);
                    myrow.Cells.Add(cell_datum);
                    myrow.Cells.Add(cell_sollzeit);
                    myrow.Cells.Add(cell_urlaubstage);
                    myrow.Cells.Add(cell_vermerk);

                    Ereignisgrid_Kalender.Rows.Add(myrow);


                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();
            Ereignisgrid_Kalender.ClearSelection();

        }

        private void button_Kalender_ganzerTagUrlaub_Click(object sender, EventArgs e)
        {   
            //Voreinstellungen für ganzen Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "0";
            textBox_Kalender_Urlaub.Text = "1";
            textBox_Kalender_Bemerkung.Text = "Urlaub";

        }

        private void button_Kalender_erstelleEintrag_Click(object sender, EventArgs e)
        {
            //TODO Plausiprüfung der Werte

            //TODO Prüfen ob schon ein anderer Eintrag mit den Werten da ist
            //TODO Kalendereintrag erstellen
            //TODO Ansicht aktualisieren

        }

        private void button_Kalender_halberTagUrlaub_Click(object sender, EventArgs e)
        {
            //Voreinstellungen für halben Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "3.6";
            textBox_Kalender_Urlaub.Text = "0.5";
            textBox_Kalender_Bemerkung.Text = "Halber Tag Urlaub";

        }

        private void button_Kalender_Krankheitstag_Click(object sender, EventArgs e)
        {
            //Voreinstellungen für halben Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "0";
            textBox_Kalender_Urlaub.Text = "0";
            textBox_Kalender_Bemerkung.Text = "Krankheitstag";

        }

        private void button_Kalender_Feiertag_Click(object sender, EventArgs e)
        {
            //Voreinstellungen für halben Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "0";
            textBox_Kalender_Urlaub.Text = "0";
            textBox_Kalender_Bemerkung.Text = "Feiertag";

        }

        private void button_Kalender_storniereEintrag_Click(object sender, EventArgs e)
        {
            //TODO eintrag mit markierter ID stornieren

            //ID ermitteln
            string markierteID = "";
            markierteID = Ereignisgrid_Kalender.SelectedCells[0].Value.ToString();

            //Bestaetigungsdialog vorbereiten
            string dialogtext = "Das Ereignis mit ID:" + markierteID + " wirklich stornieren?";
            DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //ereignis stornieren
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "UPDATE kalender SET storniert=1 where eventid = @eventid";

                comm.Parameters.Add("@eventid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = markierteID;

                log("storniere Ereignis mit ID:" + markierteID);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                close_db();
            }
            refreshKalendergrid();
            refreshEreignisgrid_Kalender();
            
        }

        private void Abwesenheiten_Click(object sender, EventArgs e)
        {

        }

        private void KalenderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ereignisgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log("Programm wird beendet.......................................................................");
        }

        private void Ereignisgrid_Kalender_SelectionChanged(object sender, EventArgs e)
        {
            if(Ereignisgrid_Kalender.SelectedRows.Count > 0)
            {
                button_Kalender_storniereEintrag.Enabled = true;
            }
        }
    }
}
