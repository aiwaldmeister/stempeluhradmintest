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

        bool personentab_initialisiert_global = false;
        bool auswertungstab_initialisiert_global = false;
        bool verrechnungstab_initialisiert_global = false;
        bool stempelungstab_initialisiert_global = false;
        bool kalendertab_initialisiert_global = false;

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
                                " where jahr=@jahr AND monat=@monat AND storniert = 0 ORDER BY name";

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

                    thisevent_name = "";
                    thisevent_name = Reader["name"] + "";

                    thisevent_tooltipprefix =  "";
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
                                KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Style.BackColor = Color.Gold;
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
            
        }

        private void refreshPersonPicker_Kalender()
        {
            PersonPicker_Kalender.Items.Clear();
            PersonPicker_Kalender.Items.Add("Allgemein");
            
            //Personen der Personentabelle dem PersonPicker hinzufügen
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

                //jeder Schleifendurchlauf entspricht einer gefundenen Person
                while (Reader.Read())
                {
                    thisperson_userid = Reader["userid"] + "";
                    thisperson_name = Reader["name"] + "";
                    thisperson_vorname= Reader["vorname"] + "";

                    PersonPicker_Kalender.Items.Add(thisperson_userid + " (" + thisperson_name + " " + thisperson_vorname + ")");
                    
                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();

            PersonPicker_Kalender.SelectedIndex = 0;
        }

        private void refreshPersonPicker_Stempelungen()
        {
            PersonPicker_Stempelungen.Items.Clear();

            //Personen der Personentabelle dem PersonPicker hinzufügen
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

                //jeder Schleifendurchlauf entspricht einer gefundenen Person
                while (Reader.Read())
                {
                    thisperson_userid = Reader["userid"] + "";
                    thisperson_name = Reader["name"] + "";
                    thisperson_vorname = Reader["vorname"] + "";

                    PersonPicker_Stempelungen.Items.Add(thisperson_userid + " (" + thisperson_name + " " + thisperson_vorname + ")");

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();

            PersonPicker_Stempelungen.SelectedIndex = 0;
        }

        private void refreshPersonPicker_Personen()
        {
            PersonPicker_Personen.Items.Clear();

            //Personen der Personentabelle dem PersonPicker hinzufügen
            string thisperson_userid = "";
            string thisperson_name = "";
            string thisperson_vorname = "";

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT userid, name, vorname FROM user ORDER BY userid";

            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf entspricht einer gefundenen Person
                while (Reader.Read())
                {
                    thisperson_userid = Reader["userid"] + "";
                    thisperson_name = Reader["name"] + "";
                    thisperson_vorname = Reader["vorname"] + "";

                    PersonPicker_Personen.Items.Add(thisperson_userid + " (" + thisperson_name + " " + thisperson_vorname + ")");
                    

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();

            PersonPicker_Personen.SelectedIndex = 0;
        }

        private void MonatsPicker_Kalender_ValueChanged(object sender, EventArgs e)
        {
            refreshKalendergrid();
            refreshEreignisgrid_Kalender();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Logfile initialisieren
            init_logfile();

            //Config-laden
            init_config();

            //Datenbank initialisieren
            init_db(dbserverconf_global, dbnameconf_global, dbuserconf_global, dbpwconf_global);

            //Kalendertab initialisieren
            //Monatspicker auf ersten des Monats setzen, weil sonst eine Exception auftritt wenn z.B. vom 31. eines monats aus nur der monat auf einen kürzeren verändert wird
            MonatsPicker_Kalender.Value = new DateTime(MonatsPicker_Kalender.Value.Year, MonatsPicker_Kalender.Value.Month, 1);
            refreshKalendergrid();
            refreshPersonPicker_Kalender();
            refreshEreignisgrid_Kalender();
            kalendertab_initialisiert_global = true;



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
            comm.CommandText = "SELECT eventid, tag, monat, vermerk, sollzeit, urlaubstage_abziehen, storniert FROM kalender WHERE jahr=@jahr AND zuordnung=@zuordnung AND storniert=0 ORDER BY monat, tag";

            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = actjahr;
            comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = actzuordnung;

            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf betrachtet ein gefundenes Ereignis im Betrachtungsjahr
                while (Reader.Read())
                {
                    thisevent_id = Reader["eventid"] + "";
                    thisevent_datum = Reader["tag"] + "." + Reader["monat"] + ".";
                    thisevent_sollzeit = Reader["sollzeit"] + "";
                    thisevent_urlaubstage = Reader["urlaubstage_abziehen"] + "";
                    thisevent_vermerk = Reader["vermerk"] + "";
                    thisevent_storniert = (bool)Reader["storniert"];

                    //Eventgrid befüllen
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
            button_Kalender_storniereEintrag.Enabled = false;

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
            string input_jahr = "";
            string input_monat = "";
            string input_tag = "";
            string input_zuordnung = "";

            double input_sollzeit = -1;
            double input_urlaub = 0;
            string input_vermerk = "";
            
            bool fehler = false;
            bool TryParse_Result = false;
            

            //Sammeln der Eingabewerte und ggf. Plausibilitätsprüfung.

            TryParse_Result = double.TryParse(textBox_Kalender_Sollzeit.Text, out input_sollzeit);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Der angegebene wert für die Sollzeit ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TryParse_Result = double.TryParse(textBox_Kalender_Urlaub.Text, out input_urlaub);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Der angegebene Wert für abzuziehende Urlaubstage ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input_vermerk = textBox_Kalender_Bemerkung.Text;
            if(input_vermerk == "")
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Bitte eine Bemerkung eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input_jahr = MonatsPicker_Kalender.Value.Year.ToString("D4");
            input_monat = MonatsPicker_Kalender.Value.Month.ToString("D2");

            if (KalenderGrid_Kalender.SelectedCells.Count == 1)
            {
                input_tag = KalenderGrid_Kalender.SelectedCells[0].Value.ToString();
                if (input_tag != "")
                {
                    input_tag = Int32.Parse(input_tag).ToString("D2");
                }
            }
            
            if(input_tag == "")
            {
                fehler = true;
                MessageBox.Show("Kein gültiger Tag im Kalender ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input_zuordnung = PersonPicker_Kalender.Text;
            if(input_zuordnung != "Allgemein")
            {
                input_zuordnung = input_zuordnung.Substring(0, 6);
            }

            
            //Prüfen ob schon ein anderer Eintrag mit den Werten da ist

            if(fehler == false)
            {
                int count = -1;
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "SELECT count(*) FROM kalender WHERE jahr=@jahr AND monat=@monat AND tag=@tag AND zuordnung=@zuordnung AND storniert = 0";

                comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = input_jahr;
                comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = input_monat;
                comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = input_tag;
                comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = input_zuordnung;

                try
                {
                    //log("SQL:" + comm.CommandText);
                    count = Convert.ToInt32(comm.ExecuteScalar());
                }
                catch (Exception ex) { log(ex.Message); }

                if (count != 0)
                {
                    fehler = true;
                    MessageBox.Show("Für dieses Datum existiert bereits ein Ereignis mit der selben Personenzuordnung.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                close_db();
            }
            

            //Kalendereintrag erstellen
            if (fehler == false)
            {
                //Bestaetigungsdialog vorbereiten
                string dialogtext = "Folgendes Ereignis mit der Zuordnung '" + input_zuordnung +  "' erstellen?\r\n\r\n" +
                                        "Bemerkung: " + input_vermerk + "\r\n" +
                                        "Datum: " + input_tag + "." + input_monat + "." + input_jahr + "\r\n" +
                                        "Sollzeit: " + input_sollzeit + "\r\n" +
                                        "Urlaubstage abziehen: " + input_urlaub;
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "INSERT INTO kalender (zuordnung,jahr,monat,tag,vermerk,urlaubstage_abziehen,sollzeit,storniert) " + 
                                        "VALUES(@zuordnung, @jahr, @monat, @tag, @vermerk, @urlaub, @sollzeit, 0)";

                    comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = input_zuordnung;
                    comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = input_jahr;
                    comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = input_monat;
                    comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = input_tag;
                    comm.Parameters.Add("@vermerk", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30).Value = input_vermerk;
                    comm.Parameters.Add("@sollzeit", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                    comm.Parameters["@sollzeit"].Precision = 10;
                    comm.Parameters["@sollzeit"].Scale = 2;
                    comm.Parameters["@sollzeit"].Value = input_sollzeit;
                    comm.Parameters.Add("@urlaub", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                    comm.Parameters["@urlaub"].Precision = 10;
                    comm.Parameters["@urlaub"].Scale = 2;
                    comm.Parameters["@urlaub"].Value = input_urlaub;
                    
                    log("Erstelle Ereignis-Eintrag: " + input_zuordnung + " " + input_tag + "." +input_monat+ "." + input_jahr + " " +
                           "Sollzeit: " + input_sollzeit + " Urlaubstage: " + input_urlaub + " Vermerk: " + input_vermerk);
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();
                    
                    //Ansicht aktualisieren (um neues event direkt sehen zu können)
                    refreshKalendergrid();
                    refreshEreignisgrid_Kalender();
                }
            }
        }

        private void button_Kalender_halberTagUrlaub_Click(object sender, EventArgs e)
        {
            //Voreinstellungen für halben Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "3,6";
            textBox_Kalender_Urlaub.Text = "0,5";
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
        {//eintrag mit markierter ID stornieren

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Personen"])
            {
                if(personentab_initialisiert_global == false)
                {                    
                    refreshPersonPicker_Personen();
                    initInsertFormular_Personen();
                    personentab_initialisiert_global = true;
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["Kalender"])
            {
                if (kalendertab_initialisiert_global == false)
                {
                    refreshPersonPicker_Kalender();
                    kalendertab_initialisiert_global = true;
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["Stempelungen"])
            {
                if (stempelungstab_initialisiert_global == false)
                {
                    comboBox_Stempelungen_Art.SelectedIndex = 0;
                    refreshPersonPicker_Stempelungen();
                    
                    stempelungstab_initialisiert_global = true;
                }
            }
        }

        private void PersonPicker_Personen_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshUpdateFormular_Personen();
        }

        private void refreshUpdateFormular_Personen()
        {
            string thisperson_userid = "";
            string thisperson_currenttask = "";
            string thisperson_nachname = "";
            string thisperson_vorname = "";
            string thisperson_zeitkonto = "";
            string thisperson_zeitkonto_berechnungsstand = "";
            string thisperson_bonuskonto_ausgezahlt_bis = "";
            string thisperson_bonuszeit_bei_letzter_auszahlung = "";
            string thisperson_jahresurlaub = "";
            bool thisperson_stempelfehler = false;
            bool thisperson_aktiv = false;

            
            thisperson_userid = PersonPicker_Personen.Text;
            if(thisperson_userid.Length >= 6)
            {
                thisperson_userid = thisperson_userid.Substring(0,6);
            }
            
            //Werte zur gewählten Person aus der Datenbank holen
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT * FROM user WHERE userid = @userid";

            comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = thisperson_userid;
            
            try
            {
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();
                Reader.Read();

                thisperson_currenttask = Reader["currenttask"] + "";
                thisperson_nachname = Reader["name"] + "";
                thisperson_vorname = Reader["vorname"] + "";
                thisperson_zeitkonto = Reader["zeitkonto"] + "";
                thisperson_zeitkonto_berechnungsstand = Reader["zeitkonto_berechnungsstand"] + "";
                thisperson_bonuskonto_ausgezahlt_bis = Reader["bonuskonto_ausgezahlt_bis"] + "";
                thisperson_bonuszeit_bei_letzter_auszahlung = Reader["bonuszeit_bei_letzter_auszahlung"] + "";
                thisperson_jahresurlaub = Reader["jahresurlaub"] + "";
                thisperson_stempelfehler = (bool)Reader["stempelfehler"];
                thisperson_aktiv = (bool)Reader["aktiv"];
                
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }
            close_db();

            //Formularfelder_old (linke spalte) füllen -> (zum Vergleich alte Werte -> neue Werte)
            textBox_Personen_Nachname_old.Text = thisperson_nachname;
            textBox_Personen_Vorname_old.Text = thisperson_vorname;
            textBox_Personen_AktAuftrag_old.Text = thisperson_currenttask;
            textBox_Personen_Zeitkonto_old.Text = thisperson_zeitkonto;
            textBox_Personen_ZeitkontoBerechnungsstand_old.Text = thisperson_zeitkonto_berechnungsstand;
            textBox_Personen_Boniausgezahltbis_old.Text = thisperson_bonuskonto_ausgezahlt_bis;
            textBox_Personen_BetragletzterBonus_old.Text = thisperson_bonuszeit_bei_letzter_auszahlung;
            textBox_Personen_Urlaubstage_old.Text = thisperson_jahresurlaub;

            comboBox_Personen_Aktiv_old.SelectedIndex = 0;
            comboBox_Personen_Stempelfehler_old.SelectedIndex = 0;
            if (thisperson_aktiv) { comboBox_Personen_Aktiv_old.SelectedIndex = 1; }
            if (thisperson_stempelfehler) { comboBox_Personen_Stempelfehler_old.SelectedIndex = 1; }

            //eigentliche Formularfelder (rechte spalte) befüllen (mit den selben Werten)
            textBox_Personen_Nachname.Text= thisperson_nachname;
            textBox_Personen_Vorname.Text = thisperson_vorname;
            textBox_Personen_AktAuftrag.Text = thisperson_currenttask;
            textBox_Personen_Zeitkonto.Text = thisperson_zeitkonto;
            textBox_Personen_ZeitkontoBerechnungsstand.Text = thisperson_zeitkonto_berechnungsstand;
            textBox_Personen_Boniausgezahltbis.Text = thisperson_bonuskonto_ausgezahlt_bis;
            textBox_Personen_BetragletzterBonus.Text = thisperson_bonuszeit_bei_letzter_auszahlung;
            textBox_Personen_Urlaubstage.Text = thisperson_jahresurlaub;

            comboBox_Personen_Aktiv.SelectedIndex = 0;
            comboBox_Personen_Stempelfehler.SelectedIndex = 0;
            if(thisperson_aktiv) { comboBox_Personen_Aktiv.SelectedIndex = 1; }
            if(thisperson_stempelfehler) { comboBox_Personen_Stempelfehler.SelectedIndex = 1; }

            //eventuell vorhandene farbliche Hinterlegungen in der rechten Formularhälfte entfernen
            textBox_Personen_Nachname.BackColor = Color.White;
            textBox_Personen_Vorname.BackColor = Color.White;
            textBox_Personen_AktAuftrag.BackColor = Color.White;
            textBox_Personen_Zeitkonto.BackColor = Color.White;
            textBox_Personen_ZeitkontoBerechnungsstand.BackColor = Color.White;
            textBox_Personen_Boniausgezahltbis.BackColor = Color.White;
            textBox_Personen_BetragletzterBonus.BackColor = Color.White;
            textBox_Personen_Urlaubstage.BackColor = Color.White;
            comboBox_Personen_Aktiv.BackColor = Color.White;
            comboBox_Personen_Stempelfehler.BackColor = Color.White;

        }

        private void initInsertFormular_Personen()
        {

            textBox_Personen_Neu_Vorname.Text = "";
            textBox_Personen_Neu_Nachname.Text = "";
            textBox_Personen_Neu_Urlaubstage.Text = "";
            textBox_Personen_Neu_WunschID.Text = "";
            
        }

        private void button_Personen_newPerson_Click(object sender, EventArgs e)
        {
            bool fehler = false;
            bool TryParse_Result = false;
            
            
            //nötige Daten ermitteln & ggf. Plausiprüfung
            string input_userid = textBox_Personen_Neu_WunschID.Text;
            string input_vorname = textBox_Personen_Neu_Vorname.Text;
            string input_nachname = textBox_Personen_Neu_Nachname.Text;
            string input_Jahresurlaub = textBox_Personen_Neu_Urlaubstage.Text;
            double jahresurlaub = 0; //wird weiter unten erst versucht aus dem Formularfeld zu parsen

            DateTime ersterarbeitstag = DatePicker_Personen_neu.Value.Date;
            DateTime tag_vor_arbeitsantritt = ersterarbeitstag.AddDays(-1);
            string tag_vor_arbeitsantritt_string = tag_vor_arbeitsantritt.Year.ToString("D4") + tag_vor_arbeitsantritt.Month.ToString("D2") + tag_vor_arbeitsantritt.Day.ToString("D2");

            if(input_userid.Length != 6 || !input_userid.StartsWith("999"))
            {
                MessageBox.Show("Die gewünschte ID ist nicht gültig. \r\n\r\n Es muss eine 6-Stellige Zahl über 999000 sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fehler = true;
            }

            if(input_vorname == "")
            {
                fehler = true;
                MessageBox.Show("Bitte einen Vornamen eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (input_nachname == "")
            {
                fehler = true;
                MessageBox.Show("Bitte einen Nachnamen eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TryParse_Result = double.TryParse(input_Jahresurlaub, out jahresurlaub);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Der angegebene wert für den Jahresurlaub ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //prüfen ob Person noch nicht existiert
            if (fehler == false)
            {
                int count = -1;
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "SELECT count(*) FROM user WHERE userid=@userid";

                comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = input_userid;

                try
                {
                    count = Convert.ToInt32(comm.ExecuteScalar());
                }
                catch (Exception ex) { log(ex.Message); }

                if (count != 0)
                {
                    fehler = true;
                    MessageBox.Show("Es existiert bereits eine Person mit dieser ID.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                close_db();
            }



            if (fehler == false)
            {
                //Bestätigungsmeldung vorbereiten und anzeigen
                string dialogtext = "Folgende Person erstellen?\r\n\r\n" +
                                        input_userid + ": " + input_vorname + " " + input_nachname + "\r\n\r\n" +
                                        "Jahresurlaub: " + jahresurlaub + " Tage\r\n" +
                                        "Erster Arbeitstag: " + ersterarbeitstag.ToLongDateString();
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Person anlegen
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "INSERT INTO user (userid, currenttask, name, vorname, zeitkonto, zeitkonto_berechnungsstand, " +
                                            "bonuskonto_ausgezahlt_bis, bonuszeit_bei_letzter_auszahlung, jahresurlaub, stempelfehler, aktiv) " +
                                        "VALUES(@userid,'',@nachname,@vorname,0,@tagvorantritt,@tagvorantritt,0,@jahresurlaub,0,1)";

                    comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = input_userid;
                    comm.Parameters.Add("@nachname", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30).Value = input_nachname;
                    comm.Parameters.Add("@vorname", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30).Value = input_vorname;
                    comm.Parameters.Add("@tagvorantritt", MySql.Data.MySqlClient.MySqlDbType.VarChar, 8).Value = tag_vor_arbeitsantritt_string;
                    comm.Parameters.Add("@jahresurlaub", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                    comm.Parameters["@jahresurlaub"].Precision = 10;
                    comm.Parameters["@jahresurlaub"].Scale = 2;
                    comm.Parameters["@jahresurlaub"].Value = jahresurlaub;

                    log("Lege Person an: " + input_userid + "(" + input_vorname + " " + input_nachname + ")");
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();

                    refreshPersonPicker_Personen();
                    initInsertFormular_Personen();

                    kalendertab_initialisiert_global = false;
                    auswertungstab_initialisiert_global = false;
                    stempelungstab_initialisiert_global = false;
                    verrechnungstab_initialisiert_global = false;
                }
            }
        }

        private void button_Personen_Edit_Systemdaten_Click(object sender, EventArgs e)
        {
            //Sicherheitsabfrage vorbereiten und anzeigen
            string dialogtext = "Fehlerhafte Änderungen an Systemdaten können zu Inkonsistenzen führen." +
                                    "\r\n\r\nBearbeitung wirklich aktivieren?";
            DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                groupBox_Personen_Systemdaten.Enabled = true;
                button_Personen_Edit_Systemdaten.Enabled = false;
                button_Personen_Edit_Systemdaten.Visible = false;
            }

        }

        private void button_Personen_writeChanges_Click(object sender, EventArgs e)
        {
            bool fehler = false;
            bool TryParse_Result = false;

            string userid = "";
            
            string new_currenttask = "";
            string new_name = "";
            string new_vorname = "";
            double new_zeitkonto = 0;
            string new_zeitkonto_berechnungsstand = "";
            string new_bonuskonto_ausgezahlt_bis = "";
            double new_bonuszeit_bei_letzter_auszahlung = 0;
            double new_jahresurlaub = 0;
            bool new_stempelfehler = false;
            bool new_aktiv = false;


            //Werte sammeln + ggf. Konvertierungen und Plausiprüfungen

            userid = PersonPicker_Personen.Text;
            if(userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }
            else
            {
                fehler = true;
                MessageBox.Show("Fehler! Die Mitarbeiter-ID ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_currenttask = textBox_Personen_AktAuftrag.Text;
            if(new_currenttask != "" && new_currenttask.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Fehler! Wert für aktuelle Auftragsnummer ungültig. (Auftragsnummern sind 6-Stellig und kleiner als 999000)", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(new_currenttask != "" && int.Parse(new_currenttask) >= 999000)
            {
                fehler = true;
                MessageBox.Show("Fehler! Wert für aktuelle Auftragsnummer ungültig. (Auftragsnummern müssen kleiner als 999000 sein)", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_name = textBox_Personen_Nachname.Text;
            new_vorname = textBox_Personen_Vorname.Text;

            TryParse_Result = double.TryParse(textBox_Personen_Zeitkonto.Text, out new_zeitkonto);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für das Zeitkonto ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TryParse_Result = double.TryParse(textBox_Personen_BetragletzterBonus.Text, out new_bonuszeit_bei_letzter_auszahlung);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Betrag des letzten Bonus ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TryParse_Result = double.TryParse(textBox_Personen_Urlaubstage.Text, out new_jahresurlaub);
            if (TryParse_Result == false)
            {//Wert der Textbox keine gültige double
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Jahresurlaub ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_zeitkonto_berechnungsstand = textBox_Personen_ZeitkontoBerechnungsstand.Text;
            if(new_zeitkonto_berechnungsstand.Length != 8)
            {
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Zeitkonto-Berechnungsstand ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_bonuskonto_ausgezahlt_bis = textBox_Personen_Boniausgezahltbis.Text;
            if(new_bonuskonto_ausgezahlt_bis.Length != 8)
            {
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Bonus-Auszahlungsstand ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_aktiv = false;
            if(comboBox_Personen_Aktiv.Text == "1"){ new_aktiv = true; }

            new_stempelfehler = false;
            if (comboBox_Personen_Stempelfehler.Text == "1") { new_stempelfehler = true; }



            if (fehler == false)
            {
                //Bestaetigungsdialog vorbereiten
                string dialogtext = "Sind Sie sicher, dass Sie die Personenstammdaten in der Datenbank mit den von Ihnen veränderten Daten überschreiben wollen?" +
                                        "\r\nFestgeschriebene Änderungen können nicht Rückgängig gemacht werden.";
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Statement vorbereiten
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "UPDATE user SET " +
                                            "currenttask=@currenttask, " +
                                            "name=@name, " +
                                            "vorname=@vorname, " +
                                            "zeitkonto=@zeitkonto, " +
                                            "zeitkonto_berechnungsstand=@zeitkonto_berechnungsstand, " +
                                            "bonuskonto_ausgezahlt_bis=@bonuskonto_ausgezahlt_bis, " +
                                            "bonuszeit_bei_letzter_auszahlung=@bonuszeit_bei_letzter_auszahlung, " +
                                            "jahresurlaub=@jahresurlaub, " +
                                            "stempelfehler=@stempelfehler, " +
                                            "aktiv=@aktiv " +
                                        "WHERE userid = @userid";

                    comm.Parameters.Add("@currenttask", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = new_currenttask;
                    comm.Parameters.Add("@name", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30).Value = new_name;
                    comm.Parameters.Add("@vorname", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30).Value = new_vorname;
                    comm.Parameters.Add("@zeitkonto", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                        comm.Parameters["@zeitkonto"].Precision = 10;
                        comm.Parameters["@zeitkonto"].Scale = 2;
                        comm.Parameters["@zeitkonto"].Value = new_zeitkonto;
                    comm.Parameters.Add("@zeitkonto_berechnungsstand", MySql.Data.MySqlClient.MySqlDbType.VarChar, 8).Value = new_zeitkonto_berechnungsstand;
                    comm.Parameters.Add("@bonuskonto_ausgezahlt_bis", MySql.Data.MySqlClient.MySqlDbType.VarChar, 8).Value = new_bonuskonto_ausgezahlt_bis;
                    comm.Parameters.Add("@bonuszeit_bei_letzter_auszahlung", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                        comm.Parameters["@bonuszeit_bei_letzter_auszahlung"].Precision = 10;
                        comm.Parameters["@bonuszeit_bei_letzter_auszahlung"].Scale = 2;
                        comm.Parameters["@bonuszeit_bei_letzter_auszahlung"].Value = new_bonuszeit_bei_letzter_auszahlung;
                    comm.Parameters.Add("@jahresurlaub", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                        comm.Parameters["@jahresurlaub"].Precision = 10;
                        comm.Parameters["@jahresurlaub"].Scale = 2;
                        comm.Parameters["@jahresurlaub"].Value = new_jahresurlaub;
                    comm.Parameters.Add("@stempelfehler", MySql.Data.MySqlClient.MySqlDbType.Byte,1).Value = new_stempelfehler;
                    comm.Parameters.Add("@aktiv", MySql.Data.MySqlClient.MySqlDbType.Byte, 1).Value = new_aktiv;
                    comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;

                    //veränderte Daten loggen für nachvollziehbarkeit.
                    log("Update auf Person:" + userid + "..." +
                        "\r\n Name:'" + textBox_Personen_Nachname_old.Text + "'->'" + textBox_Personen_Nachname.Text + "' " +
                        "\r\n Vorname:'" + textBox_Personen_Vorname_old.Text + "'->'" + textBox_Personen_Vorname.Text + "' " +
                        "\r\n Jahresurlaub:'" + textBox_Personen_Urlaubstage_old.Text + "'->'" + textBox_Personen_Urlaubstage.Text + "' " +
                        "\r\n Aktiv:'" + comboBox_Personen_Aktiv_old.Text + "'->'" + comboBox_Personen_Aktiv.Text + "' " +
                        "\r\n Currenttask:'" + textBox_Personen_AktAuftrag_old.Text + "'->'" + textBox_Personen_AktAuftrag.Text + "' " +
                        "\r\n Zeitkonto:'" + textBox_Personen_Zeitkonto_old.Text +"'->'" + textBox_Personen_Zeitkonto.Text +"' " +
                        "\r\n Zeitkonto_Berechnungsstand:'" + textBox_Personen_ZeitkontoBerechnungsstand_old.Text+"'->'" +  textBox_Personen_ZeitkontoBerechnungsstand.Text +"' " +
                        "\r\n Boni_ausgezahlt_bis:'" + textBox_Personen_Boniausgezahltbis_old.Text +"'->'" + textBox_Personen_Boniausgezahltbis.Text +"' " +
                        "\r\n Betrag_letzter_Bonus:'" + textBox_Personen_BetragletzterBonus_old.Text +"'->'" +textBox_Personen_BetragletzterBonus.Text +"' " +
                        "\r\n Stempelfehler:'" + comboBox_Personen_Stempelfehler_old.Text +"'->'" + comboBox_Personen_Stempelfehler.Text 
                        +"' \r\n");
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();

                    //selectierte Person merken, Personpicker refreshen und wieder selbe Person selectieren
                    int selecteduser = PersonPicker_Personen.SelectedIndex; 
                    refreshPersonPicker_Personen();
                    PersonPicker_Personen.SelectedIndex = selecteduser;

                    //weil aktive personen hinzugekommen oder verschwunden sein könnten, müssen tabs ggf. neu initialisiert werden.
                    kalendertab_initialisiert_global = false;
                    stempelungstab_initialisiert_global = false;
                    auswertungstab_initialisiert_global = false;
                    verrechnungstab_initialisiert_global = false;

                }
            }   
        }

        private void textBox_Personen_Vorname_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Personen_Vorname.Text == textBox_Personen_Vorname_old.Text)
            {
                textBox_Personen_Vorname.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_Vorname.BackColor = Color.Gold;
            }

        }

        private void textBox_Personen_Nachname_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_Nachname.Text == textBox_Personen_Nachname_old.Text)
            {
                textBox_Personen_Nachname.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_Nachname.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_Urlaubstage_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_Urlaubstage.Text == textBox_Personen_Urlaubstage_old.Text)
            {
                textBox_Personen_Urlaubstage.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_Urlaubstage.BackColor = Color.Gold;
            }
        }

        private void comboBox_Personen_Aktiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Personen_Aktiv.Text == comboBox_Personen_Aktiv_old.Text)
            {
                comboBox_Personen_Aktiv.BackColor = Color.White;
            }
            else
            {
                comboBox_Personen_Aktiv.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_AktAuftrag_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_AktAuftrag.Text == textBox_Personen_AktAuftrag_old.Text)
            {
                textBox_Personen_AktAuftrag.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_AktAuftrag.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_Zeitkonto_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_Zeitkonto.Text == textBox_Personen_Zeitkonto_old.Text)
            {
                textBox_Personen_Zeitkonto.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_Zeitkonto.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_ZeitkontoBerechnungsstand_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_ZeitkontoBerechnungsstand.Text == textBox_Personen_ZeitkontoBerechnungsstand_old.Text)
            {
                textBox_Personen_ZeitkontoBerechnungsstand.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_ZeitkontoBerechnungsstand.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_Boniausgezahltbis_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_Boniausgezahltbis.Text == textBox_Personen_Boniausgezahltbis_old.Text)
            {
                textBox_Personen_Boniausgezahltbis.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_Boniausgezahltbis.BackColor = Color.Gold;
            }
        }

        private void textBox_Personen_BetragletzterBonus_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Personen_BetragletzterBonus.Text == textBox_Personen_BetragletzterBonus_old.Text)
            {
                textBox_Personen_BetragletzterBonus.BackColor = Color.White;
            }
            else
            {
                textBox_Personen_BetragletzterBonus.BackColor = Color.Gold;
            }
        }

        private void comboBox_Personen_Stempelfehler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Personen_Stempelfehler.Text == comboBox_Personen_Stempelfehler_old.Text)
            {
                comboBox_Personen_Stempelfehler.BackColor = Color.White;
            }
            else
            {
                comboBox_Personen_Stempelfehler.BackColor = Color.Gold;
            }
        }

        private void PersonPicker_Stempelungen_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStempelungsgrid_Stempelungen();
        }

        private void refreshStempelungsgrid_Stempelungen()
        {
            Stempelungsgrid_Stempelungen.Rows.Clear();

            string userid = "";
            string tag = "";
            string monat = "";
            string jahr = "";

            string thisstamp_id = "";
            string thisstamp_art = "";
            string thisstamp_auftrag = "";
            string thisstamp_zeitstempel = "";
            string thisstamp_quelle = "";

            //userid ermitteln
            userid = PersonPicker_Stempelungen.Text;
            if(userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }

            //Datum ermitteln
            tag = DatePicker_Stempelungen.Value.Day.ToString("D2");
            monat = DatePicker_Stempelungen.Value.Month.ToString("D2");
            jahr = DatePicker_Stempelungen.Value.Year.ToString("D4");


            //select ausführen
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT * FROM stamps WHERE userid=@userid AND jahr=@jahr AND monat=@monat AND tag=@tag AND storniert=0 ORDER BY stunde ASC, minute ASC, sekunde ASC, art DESC";

            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = jahr;
            comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = monat;
            comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = tag;
            comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;


            try
            {
                //log("SQL:" + comm.CommandText);
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf betrachtet eine gefundene Stempelung der ausgewählten Person am ausgewählten Datum
                while (Reader.Read())
                {
                    thisstamp_id = Reader["stampid"] + "";
                    thisstamp_art = Reader["art"] + "";
                    thisstamp_auftrag = Reader["task"] + "";
                    thisstamp_zeitstempel = Reader["stunde"] + ":" + Reader["minute"] + ":" + Reader["sekunde"] + "";
                    thisstamp_quelle = Reader["quelle"] + "";
                    
                    //Stempelungsgrid befüllen
                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell_id = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_art = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_auftrag = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_zeitstempel = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_quelle = new DataGridViewTextBoxCell();

                    cell_id.Value = thisstamp_id;
                    cell_art.Value = thisstamp_art;
                    cell_auftrag.Value = thisstamp_auftrag;
                    cell_zeitstempel.Value = thisstamp_zeitstempel;
                    cell_quelle.Value = thisstamp_quelle;

                    myrow.Cells.Add(cell_id);
                    myrow.Cells.Add(cell_art);
                    myrow.Cells.Add(cell_auftrag);
                    myrow.Cells.Add(cell_zeitstempel);
                    myrow.Cells.Add(cell_quelle);

                    Stempelungsgrid_Stempelungen.Rows.Add(myrow);


                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();
            Stempelungsgrid_Stempelungen.ClearSelection();
            
        }

        private void DatePicker_Stempelungen_ValueChanged(object sender, EventArgs e)
        {
            refreshStempelungsgrid_Stempelungen();
        }
    }
}
