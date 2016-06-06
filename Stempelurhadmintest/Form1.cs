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

        ///////////Tab-Übergreifende Funktionen////////////////////////////////

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log("Programm wird beendet.......................................................................");
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Personen"])
            {
                if (personentab_initialisiert_global == false)
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
                    refreshKalendergrid();
                    refreshPersonPicker_Kalender();
                    refreshEreignisgrid_Kalender();
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

            if (tabControl1.SelectedTab == tabControl1.TabPages["Verrechnung"])
            {
                if (verrechnungstab_initialisiert_global == false)
                {
                    refreshAuftragsPicker_Verrechnung_Insert();
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["Auswertungen"])
            {
                if (auswertungstab_initialisiert_global == false)
                {
                    //TODO auswertungstab initialisieren
                    //TODO Auswertung über Tatsächliche Arbeitszeit (Mitarbeiter/Jahr)
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private double ermittleIstZeit(string usercode, string berechnungsjahr, string berechnungsmonat, string berechnungstag)
        {
            double Istzeit_tmp = 0;
            double Pausenzeit_tmp = 0;
            string Fehler = "";

            open_db();
            comm.Parameters.Clear();
            //die sortierung soll sicherstellen dass immer die zusammenpassenden an+abstempelungen nacheinander kommen
            comm.CommandText = "SELECT * FROM stamps WHERE userid = @userid AND jahr = @jahr AND monat = @monat AND tag = @tag  AND storniert = 0 " +
                                "ORDER BY jahr ASC, monat ASC, tag ASC, stunde ASC, minute ASC, sekunde ASC, art ASC";

            comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = usercode;
            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = berechnungsjahr;
            comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungsmonat;
            comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungstag;

            log("\tSQL:" + comm.CommandText);
            MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

            //jeder schleifendurchlauf betrachtet ein paar aus an- und abstempelung
            while (Reader.Read())
            {
                //alle nötigen werte der anstempelung aus dem reader holen
                string an_stunde = Reader["stunde"] + "";
                string an_dezimal = Reader["dezimal"] + "";
                string an_task = Reader["task"] + "";
                double an_uhrzeit_dezimal = double.Parse(an_stunde + "," + an_dezimal);


                Reader.Read();
                //alle nötigen werte der abstempelung aus dem reader holen
                string ab_stunde = Reader["stunde"] + "";
                string ab_dezimal = Reader["dezimal"] + "";
                string ab_task = Reader["task"] + "";
                double ab_uhrzeit_dezimal = double.Parse(ab_stunde + "," + ab_dezimal);

                if (an_task != ab_task)
                {
                    Fehler = "Zeitpaar passt nicht zusammen (verschiedene tasks)";
                    log(Fehler);
                    return -1;
                }

                if (an_task == "888001")
                {   //Pausenstempelung

                    Pausenzeit_tmp = Pausenzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal;
                }



                if (an_task != "888000")
                {   //keine Leerlaufstempelung -> Zeit komplett auf Istzeit anrechnen
                    Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal;
                }
                else
                {
                    //////Leerlaufstempelung -> ///////////start der Fallunterscheidung ////////////////
                    //Leerlaufzeiten zwischen 12:30-13:30 die nicht zur IstZeit angerechnet werden, werden dafür auf die Pausenzeit angerechnet

                    //Fall 1: Anstempelung vor 8, Abstempelung vor 8 -> nix anrechnen
                    if (an_uhrzeit_dezimal <= 8 && ab_uhrzeit_dezimal <= 8)
                    {
                    }
                    else

                    //Fall 2: Anstempelung vor 8, Abstempelung Vormittags -> 8 bis Abstempelung anrechnen
                    if (an_uhrzeit_dezimal <= 8 && ab_uhrzeit_dezimal >= 8 && ab_uhrzeit_dezimal <= 12.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - 8;
                    }
                    else

                    //Fall 3: Anstempelung vor 8, Abstempelung Mittags -> 8 bis 12:30 anrechnen
                    if (an_uhrzeit_dezimal <= 8 && ab_uhrzeit_dezimal >= 12.5 && ab_uhrzeit_dezimal <= 13.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 12.5 - 8;
                        Pausenzeit_tmp = Pausenzeit_tmp + ab_uhrzeit_dezimal - 12.5;
                    }
                    else

                    //Fall 4: Anstempelung vor 8, Abstempelung Nachmittags -> 8 bis Abstempelung anrechnen und 1 Std abziehen
                    if (an_uhrzeit_dezimal <= 8 && ab_uhrzeit_dezimal >= 13.5 && ab_uhrzeit_dezimal <= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - 8 - 1;
                        Pausenzeit_tmp = Pausenzeit_tmp + 1;
                    }
                    else

                    //Fall 5: Anstempelung vor 8, Abstempelung nach 17:30 -> 8 bis 17:30 anrechnen und 1 Std abziehen
                    if (an_uhrzeit_dezimal <= 8 && ab_uhrzeit_dezimal >= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 17.5 - 8 - 1;
                        Pausenzeit_tmp = Pausenzeit_tmp + 1;
                    }
                    else

                    //Fall 6: Anstempelung Vormittags, Abstempelung Vormittags -> Anstempelung bis Abstempelung voll anrechnen
                    if (an_uhrzeit_dezimal >= 8 && an_uhrzeit_dezimal <= 12.5 && ab_uhrzeit_dezimal >= 8 && ab_uhrzeit_dezimal <= 12.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 7: Anstempelung Vormittags, Abstempelung Mittags -> Anstempelung bis 12:30 anrechnen
                    if (an_uhrzeit_dezimal >= 8 && an_uhrzeit_dezimal <= 12.5 && ab_uhrzeit_dezimal >= 12.5 && ab_uhrzeit_dezimal <= 13.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 12.5 - an_uhrzeit_dezimal;
                        Pausenzeit_tmp = Pausenzeit_tmp + ab_uhrzeit_dezimal - 12.5;
                    }
                    else

                    //Fall 8: Anstempelung Vormittags, Abstempelung Nachmittags -> Anstempelung bis Abstempelung anrechnen und 1 Std abziehen
                    if (an_uhrzeit_dezimal >= 8 && an_uhrzeit_dezimal <= 12.5 && ab_uhrzeit_dezimal >= 13.5 && ab_uhrzeit_dezimal <= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal - 1;
                        Pausenzeit_tmp = Pausenzeit_tmp + 1;
                    }
                    else

                    //Fall 9: Anstempelung Vormittags, Abstempelung nach 17:30 -> Anstempelung bis 17:30 anrechnen und 1 Std abziehen
                    if (an_uhrzeit_dezimal >= 8 && an_uhrzeit_dezimal <= 12.5 && ab_uhrzeit_dezimal >= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 17.5 - an_uhrzeit_dezimal - 1;
                        Pausenzeit_tmp = Pausenzeit_tmp + 1;
                    }
                    else

                    //Fall 10: Anstempelung Mittags, Abstempelung Mittags -> nix anrechnen
                    if (an_uhrzeit_dezimal >= 12.5 && an_uhrzeit_dezimal <= 13.5 && ab_uhrzeit_dezimal >= 12.5 && ab_uhrzeit_dezimal <= 13.5)
                    {
                        Pausenzeit_tmp = Pausenzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 11: Anstempelung Mittags, Abstempelung Nachmittags -> 13:30 bis Abstempelung anrechnen
                    if (an_uhrzeit_dezimal >= 12.5 && an_uhrzeit_dezimal <= 13.5 && ab_uhrzeit_dezimal >= 13.5 && ab_uhrzeit_dezimal <= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - 13.5;
                        Pausenzeit_tmp = Pausenzeit_tmp + 13.5 - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 12: Anstempelung Mittags, Abstempelung nach 17:30 -> 13:30 bis 17:30 anrechnen
                    if (an_uhrzeit_dezimal >= 12.5 && an_uhrzeit_dezimal <= 13.5 && ab_uhrzeit_dezimal >= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 17.5 - 13.5;
                        Pausenzeit_tmp = Pausenzeit_tmp + 13.5 - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 13: Anstempelung Nachmittags, Abstempelung Nachmittags -> Anstempelung bis Abstempelung voll anrechnen
                    if (an_uhrzeit_dezimal >= 13.5 && an_uhrzeit_dezimal <= 17.5 && ab_uhrzeit_dezimal >= 13.5 && ab_uhrzeit_dezimal <= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + ab_uhrzeit_dezimal - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 14: Anstempelung Nachmittags, Abstempelung nach 17:30 -> Anstempelung bis 17:30 anrechnen
                    if (an_uhrzeit_dezimal >= 13.5 && an_uhrzeit_dezimal <= 17.5 && ab_uhrzeit_dezimal >= 17.5)
                    {
                        Istzeit_tmp = Istzeit_tmp + 17.5 - an_uhrzeit_dezimal;
                    }
                    else

                    //Fall 15: Anstempelung nach 17:30, Abstempelung nach 17:30 -> nix anrechnen
                    if (an_uhrzeit_dezimal >= 17.5 && ab_uhrzeit_dezimal >= 17.5)
                    { }

                    ///////// Ende der Fallunterscheidungen bei Leerlaufstempelungen

                }
            }
            Reader.Close();
            close_db();
            Istzeit_tmp = Istzeit_tmp - Pausenzeit_tmp;

            //Pausenzeit auf mindestlänge bringen (laut Gesetz mindestens 30min bei mehr als 6Std Arbeit)
            if (Istzeit_tmp >= 6 && Pausenzeit_tmp < 0.5)
            {
                Istzeit_tmp = Istzeit_tmp - (0.5 - Pausenzeit_tmp);
            }

            if (Fehler == "")
            {
                log("Ermittelte Istzeit für " + berechnungstag + "." + berechnungsmonat + "." + berechnungsjahr + ": " + Istzeit_tmp + " Std.");
                return Istzeit_tmp;
            }
            else
            {
                return -1;
            }
        }

        private double ermittleSollZeit(string usercode, string berechnungsjahr, string berechnungsmonat, string berechnungstag)
        {   //sollzeit ermitteln (persoenlicher kalendereintrag > allgemeiner kalendereintrag > fallback(wochenende 0, sonst 7,2)
            double sollzeit = 0;
            object tmp = null;
            string sollzeitquelle = "";
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT sollzeit FROM kalender where zuordnung=@zuordnung " +
                                "AND jahr = @jahr AND monat = @monat AND tag = @tag AND storniert = 0";

            comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = usercode;
            comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = berechnungsjahr;
            comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungsmonat;
            comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungstag;

            log("\tSQL:" + comm.CommandText);
            try
            {
                tmp = comm.ExecuteScalar();
            }
            catch (Exception ex) { log(ex.Message); }
            close_db();

            if (tmp != null)
            {   //es gab einen persönlichen Kalendereintrag -> dessen Sollzeit verwenden
                sollzeit = Convert.ToDouble(tmp);
                sollzeitquelle = "persönlicher Kalendereintrag";
            }
            else
            {   //es gab keinen persönlichen Kalendereintrag -> suche allgemeinen
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "SELECT sollzeit FROM kalender where zuordnung='allgemein' " +
                                    "AND jahr = @jahr AND monat = @monat AND tag = @tag AND storniert = 0";

                comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = berechnungsjahr;
                comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungsmonat;
                comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = berechnungstag;

                log("\tSQL:" + comm.CommandText);
                try
                {
                    tmp = comm.ExecuteScalar();
                }
                catch (Exception ex) { log(ex.Message); }
                close_db();
                if (tmp != null)
                {   //es gab einen allgemeinen Kalendereintrag -> dessen Sollzeit verwenden
                    sollzeit = Convert.ToDouble(tmp);
                    sollzeitquelle = "allgemeiner Kalendereintrag";
                }
                else
                {   //es gab weder einen persönlichen noch einen allgemeinen Kalendereintrag -> Sollzeit hängt vom Wochentag ab
                    DateTime berechnungsdatum = DateTime.ParseExact(berechnungsjahr + berechnungsmonat + berechnungstag, "yyyyMMdd", null);
                    int Wochentagscode = (int)berechnungsdatum.DayOfWeek;
                    if (Wochentagscode == 0 || Wochentagscode == 6)
                    {
                        sollzeit = 0;
                        sollzeitquelle = "normaler Wochenendstag";
                    }
                    else
                    {
                        sollzeit = 7.2;
                        sollzeitquelle = "normaler Werktag";
                    }
                }
            }
            log("Ermittelte Sollzeit für " + berechnungstag + "." + berechnungsmonat + "." + berechnungsjahr + ": " + sollzeit + " Std. (" + sollzeitquelle + ")");
            return sollzeit;

        }


        ///////////Kalender-Tab////////////////////////////////////////////////

        private void markiereTagemitEreignissen(String PersonFilter)
        {
            string cellvaluestring = "";
            string betrachtungsjahr = MonatsPicker_Kalender.Value.Year.ToString("D4");
            string betrachtungsmonat = MonatsPicker_Kalender.Value.Month.ToString("D2");
            string zuordnung = "";

            string thisevent_vermerk = "";
            string thisevent_tag = "";
            string thisevent_zuordnung = "";
            string thisevent_name = "";
            string thisevent_tooltipprefix = "";

            zuordnung = PersonPicker_Kalender.Text;
            if(zuordnung != "Allgemein" && zuordnung !="")
            {
                zuordnung = zuordnung.Substring(0, 6);
            }
            
            //select auf kalenderdatenbank mit betrachtungsjahr, betrachtungsmonat
            //wenn event gefunden, die entsprechende cell einfärben und den tooltip setzen

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT eventid, zuordnung, name, jahr, monat, tag, vermerk, urlaubstage_abziehen, sollzeit, storniert" +
                                " FROM kalender left join user on kalender.zuordnung = user.userid" +
                                " where jahr=@jahr AND monat=@monat AND storniert = 0";

            //Bei allgemein, alles anzeigen... sonst nur die der gewählten person zugeordneten.
            if(zuordnung != "Allgemein")
            {
                comm.CommandText = comm.CommandText + " AND zuordnung=@zuordnung";
                comm.Parameters.Add("@zuordnung", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = zuordnung;
            }
            
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

        private void button_Kalender_Monatzurueck_Click(object sender, EventArgs e)
        {
            MonatsPicker_Kalender.Value = MonatsPicker_Kalender.Value.AddMonths(-1);
        }

        private void button_Kalender_Monatvor_Click(object sender, EventArgs e)
        {
            MonatsPicker_Kalender.Value = MonatsPicker_Kalender.Value.AddMonths(1);
        }

        private void MonatsPicker_Kalender_ValueChanged(object sender, EventArgs e)
        {
            refreshKalendergrid();
            refreshEreignisgrid_Kalender();
        }

        private void PersonPicker_Kalender_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshEreignisgrid_Kalender();
            refreshKalendergrid();
        }

        private void pruefeZeitkontostand()
        {
            //TODO testen ob markiertes Datum später ist als der Zeitkontostand des ausgewählten Mitarbeiters
                //TODO wenn ja, insertbox enablen
                //TODO wenn nein, insertbox disablen und Hinweis setzen

            
            //TODO falls allgemein, prüfen ob markiertes Datum später ist, als die Zeitkontostände aller Mitarbeiter
                //TODO wenn ja, insertbox enablen
                //TODO wenn nein, insertbox disablen

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
            if (PersonPicker_Kalender.Text != null)
            {
                actzuordnung = PersonPicker_Kalender.Text;
            }

            if (actzuordnung.Length >= 6)
            {
                if(actzuordnung != "Allgemein")
                {
                    groupBox_Kalender_AlleEreignisse.Text = "Alle Ereignisse für " + actzuordnung + " in " + actjahr;
                    actzuordnung = actzuordnung.Substring(0, 6);
                }else
                {
                    groupBox_Kalender_AlleEreignisse.Text = "Alle allgemeinen Ereignisse in " + actjahr;
                }
                
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
            if (input_vermerk == "")
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

            if (input_tag == "")
            {
                fehler = true;
                MessageBox.Show("Kein gültiger Tag im Kalender ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input_zuordnung = PersonPicker_Kalender.Text;
            if (input_zuordnung != "Allgemein")
            {
                input_zuordnung = input_zuordnung.Substring(0, 6);
            }

            if(input_zuordnung == "Allgemein" && input_urlaub > 0)
            {
                fehler = true;
                MessageBox.Show("Bei Allgemeinen Ereignissen sollte kein Urlaub abgezogen werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Prüfen ob schon ein anderer Eintrag mit den Werten da ist

            if (fehler == false)
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
                string dialogtext = "Folgendes Ereignis mit der Zuordnung '" + input_zuordnung + "' erstellen?\r\n\r\n" +
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

                    log("Erstelle Ereignis-Eintrag: " + input_zuordnung + " " + input_tag + "." + input_monat + "." + input_jahr + " " +
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

        private void Ereignisgrid_Kalender_SelectionChanged(object sender, EventArgs e)
        {
            if (Ereignisgrid_Kalender.SelectedRows.Count > 0)
            {
                //stornierbutton aktivieren
                button_Kalender_storniereEintrag.Enabled = true;
            }
        }

        private void Ereignisgrid_Kalender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Ereignisgrid_Kalender.SelectedRows.Count > 0)
            {
                //ausgewählte zeile merken
                int selectedrow = Ereignisgrid_Kalender.SelectedCells[0].RowIndex;

                //Kalendergrid-ansicht auf den Monat des markierten ereignisses setzen
                int selectedmonat = int.Parse(Ereignisgrid_Kalender.SelectedCells[1].Value.ToString().Substring(3, 2));
                MonatsPicker_Kalender.Value = new DateTime(MonatsPicker_Kalender.Value.Year, selectedmonat, 1, 0, 0, 0);

                //vorher gemerkte zeile wieder markieren, weil durch das refreshen des kalenders+ereignisgrid die auswahl verloren geht
                Ereignisgrid_Kalender.Rows[selectedrow].Selected = true;

                //Formular mit den werden des markierten eintrags vorbefüllen
                textBox_Kalender_Sollzeit.Text = Ereignisgrid_Kalender.SelectedCells[2].Value.ToString();
                textBox_Kalender_Urlaub.Text = Ereignisgrid_Kalender.SelectedCells[3].Value.ToString();
                textBox_Kalender_Bemerkung.Text = Ereignisgrid_Kalender.SelectedCells[4].Value.ToString();

            }
        }


        ///////////Stempelungen-Tab////////////////////////////////////////////

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

        private void PersonPicker_Stempelungen_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStempelungsgrid_Stempelungen();
            vergleiche_Stempelungstab_Zeikonto_Berechnungsstand_Betrachtungsdatum();
        }

        private void vergleiche_Stempelungstab_Zeikonto_Berechnungsstand_Betrachtungsdatum()
        {
            string userid = "";
            string zeitkonto_berechnungsstand = "";

            DateTime date_selected;
            DateTime date_berechnungsstand;

            int jahr_tmp = 0;
            int monat_tmp = 0;
            int tag_tmp = 0;

            userid = PersonPicker_Stempelungen.Text;
            if (userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }

            //Zeitkonto-Berechnungsstand der gewählten Person ermitteln und in der Textbox anzeigen
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT zeitkonto_berechnungsstand FROM user where userid=@userid";

            comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;

            try
            {
                zeitkonto_berechnungsstand = comm.ExecuteScalar() + "";
            }
            catch (Exception ex) { log(ex.Message); }
            close_db();

            //Prüfen ob der Zeitkonto-Berechnungsstand früher ist, als das Datum das gerade ausgewählt ist
            jahr_tmp = int.Parse(zeitkonto_berechnungsstand.Substring(0, 4));
            monat_tmp = int.Parse(zeitkonto_berechnungsstand.Substring(4, 2));
            tag_tmp = int.Parse(zeitkonto_berechnungsstand.Substring(6, 2));

            date_berechnungsstand = new DateTime(jahr_tmp, monat_tmp, tag_tmp, 0, 0, 0);

            label_Stempelungen_Zeitkonto_Berechnungsstand.Text = date_berechnungsstand.ToShortDateString();


            jahr_tmp = DatePicker_Stempelungen.Value.Year;
            monat_tmp = DatePicker_Stempelungen.Value.Month;
            tag_tmp = DatePicker_Stempelungen.Value.Day;

            date_selected = new DateTime(jahr_tmp, monat_tmp, tag_tmp, 0, 0, 0);

            int result_datumsvergleich = DateTime.Compare(date_selected, date_berechnungsstand);

            if (result_datumsvergleich > 0)
            {//gewähltes Datum ist später als der Zeitkonto-Berechnungsstand -> Stempelungen können editiert werden
                groupBox_Stempelungen_EditierenErstellen.Enabled = true;
                button_Stempelungen_ZeitkontoRueckrechnen.Enabled = false;
                label_Stempelungen_Hinweis.Visible = false;
            }
            else
            {//gewähltes Datum ist gleich oder früher als der Zeitkonto-Berechnungsstand -> Stempelungen dürfen nicht editiert werden
                groupBox_Stempelungen_EditierenErstellen.Enabled = false;
                button_Stempelungen_ZeitkontoRueckrechnen.Enabled = true;
                label_Stempelungen_Hinweis.Text = "Stempelungen vom " + date_selected.ToShortDateString() + " sind erst nach Rückrechnung veränderbar.";
                label_Stempelungen_Hinweis.Visible = true;
            }

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
            if (userid.Length >= 6)
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
            comm.CommandText = "SELECT * FROM stamps WHERE userid=@userid AND jahr=@jahr AND monat=@monat AND tag=@tag AND storniert=0 ORDER BY stunde ASC, minute ASC, sekunde ASC, art ASC";

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
            initEditFormular_Stempelungen();
            sucheStempelfehler_Stempelungen();
        }

        private void DatePicker_Stempelungen_ValueChanged(object sender, EventArgs e)
        {
            refreshStempelungsgrid_Stempelungen();
            vergleiche_Stempelungstab_Zeikonto_Berechnungsstand_Betrachtungsdatum();
        }

        private void Stempelungsgrid_Stempelungen_SelectionChanged(object sender, EventArgs e)
        {
            //Prüfen ob eine Zeile markiert ist und wenn ja das Formular fuellen
            if (Stempelungsgrid_Stempelungen.SelectedRows.Count == 1)
            {
                prefillEditFormular_Stempelungen();
                button_Stempelungen_ueberschreiben.Enabled = true;
                button_Stempelungen_stornieren.Enabled = true;
            }
            else
            {
                initEditFormular_Stempelungen();
                button_Stempelungen_ueberschreiben.Enabled = false;
                button_Stempelungen_stornieren.Enabled = false;
            }

        }

        private void initEditFormular_Stempelungen()
        {
            //Editformular im Stempelungstab leeren
            comboBox_Stempelungen_Art.SelectedIndex = 0;
            textBox_Stempelungen_Auftragsnummer.Text = "";
            TimePicker_Stempelungen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            if (Stempelungsgrid_Stempelungen.SelectedRows.Count == 1)
            {
                button_Stempelungen_ueberschreiben.Enabled = true;
                button_Stempelungen_stornieren.Enabled = true;
            }
            else
            {
                button_Stempelungen_ueberschreiben.Enabled = false;
                button_Stempelungen_stornieren.Enabled = false;
            }

        }

        private void prefillEditFormular_Stempelungen()
        {
            //Editformular im Stempelungstab mit den Werten der markierten Stempelung vorbelegen

            comboBox_Stempelungen_Art.SelectedIndex = 0;
            if (Stempelungsgrid_Stempelungen.SelectedCells[1].Value.ToString() == "ab")
            {
                comboBox_Stempelungen_Art.SelectedIndex = 1;
            }
            textBox_Stempelungen_Auftragsnummer.Text = Stempelungsgrid_Stempelungen.SelectedCells[2].Value.ToString();

            string timefromgrid = Stempelungsgrid_Stempelungen.SelectedCells[3].Value.ToString();
            string hourfromgrid = timefromgrid.Substring(0, 2);
            string minutefromgrid = timefromgrid.Substring(3, 2);
            string secondfromgrid = timefromgrid.Substring(6, 2);
            int hour = int.Parse(hourfromgrid);
            int minute = int.Parse(minutefromgrid);
            int second = int.Parse(secondfromgrid);
            if (second == 60) { second = 59; }   //autostempelungen stempeln eine sekunde nach der letzten anstempelung ab. Deshalb die korrektur um ggf. fehler zu vermeiden

            TimePicker_Stempelungen.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
        }

        private bool sucheStempelfehler_Stempelungen()
        {//durchsucht das Stempelungsgrid nach offensichtlichen Stempelfehlern

            bool Stempelfehler = false;
            string thisrow_art = "";
            string lastrow_art = "";
            string thisrow_task = "";
            string lastrow_task = "";
            string thisrow_quelle = "";
            int rowcount = Stempelungsgrid_Stempelungen.Rows.Count;
            DateTime heute = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime betrachtungsdatum = new DateTime(DatePicker_Stempelungen.Value.Year, DatePicker_Stempelungen.Value.Month, DatePicker_Stempelungen.Value.Day, 0, 0, 0);
            //Nach Problemen suchen und diese markieren (eventuell noch mit message erklären)

            Stempelungsgrid_Stempelungen.ClearSelection();

            if (rowcount > 0)
            {   //Es gibt Stempelungen die es sich zu prüfen lohnt (würde sonst keinen Sinn machen und Fehler verursachen)

                //Test 1: Ist die erste Stempelung keine anstempelung?
                if (Stempelungsgrid_Stempelungen.Rows[0].Cells[1].Value.ToString() != "an")
                {
                    Stempelfehler = true;
                    Stempelungsgrid_Stempelungen.Rows[0].Cells[1].Style.BackColor = Color.Orange;
                    Stempelungsgrid_Stempelungen.Rows[0].Cells[1].ToolTipText = Stempelungsgrid_Stempelungen.Rows[0].Cells[1].ToolTipText + "Erste Stempelung des Tages sollte eine Anstempelung sein!\r\n";
                }

                lastrow_art = "";
                lastrow_task = "";
                for (int actrow = 0; actrow < Stempelungsgrid_Stempelungen.Rows.Count; actrow++)
                {
                    thisrow_art = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[1].Value.ToString();
                    thisrow_task = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[2].Value.ToString();
                    thisrow_quelle = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[4].Value.ToString();


                    //Test 2: kommt nicht immer abwechselnd eine an + eine abstempelung?
                    if (thisrow_art == lastrow_art)
                    {
                        Stempelfehler = true;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[1].Style.BackColor = Color.Orange;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[1].ToolTipText = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[1].ToolTipText + "An- und Ab-Stempelungen sollten sich immer abwechseln!\r\n";
                    }

                    //Test 3: Hat ein Paar aus AN+AB-Stempelung verschiedene Auftragsnummern?
                    if (actrow > 0 && thisrow_art == "ab" && (thisrow_task != lastrow_task))
                    {
                        Stempelfehler = true;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[2].Style.BackColor = Color.Orange;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[2].ToolTipText = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[2].ToolTipText + "Die Abstempelung sollte die selbe Auftragsnummer haben wie die vorherige Anstempelung!\r\n";
                    }

                    //Test 4: unkorrigierte automatische Abstempelung von einem Wartungslauf? (quelle = 'wartung')
                    if (thisrow_quelle == "wartung")
                    {
                        Stempelfehler = true;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[4].Style.BackColor = Color.Orange;
                        Stempelungsgrid_Stempelungen.Rows[actrow].Cells[4].ToolTipText = Stempelungsgrid_Stempelungen.Rows[actrow].Cells[4].ToolTipText + "Automatische Wartungs-Abstempelungen sollten geprüft und manuell korrigiert werden!\r\n";
                    }


                    lastrow_task = thisrow_task;
                    lastrow_art = thisrow_art;
                }

                //Test 5: Datum ist früher als das heutige und letzte Stempelung ist keine Abstempelung?
                thisrow_art = Stempelungsgrid_Stempelungen.Rows[rowcount - 1].Cells[1].Value.ToString();
                if (DateTime.Compare(betrachtungsdatum, heute) < 0 && thisrow_art != "ab")
                {
                    Stempelfehler = true;
                    Stempelungsgrid_Stempelungen.Rows[rowcount - 1].Cells[1].Style.BackColor = Color.Orange;
                    Stempelungsgrid_Stempelungen.Rows[rowcount - 1].Cells[1].ToolTipText = Stempelungsgrid_Stempelungen.Rows[rowcount - 1].Cells[1].ToolTipText + "Die letzte Stempelung eines (vergangenen-) Tages sollte immer eine Abstempelung sein!\r\n";
                }

            }

            return Stempelfehler;

        }

        private void button_Stempelungen_ZeitkontoRueckrechnen_Click(object sender, EventArgs e)
        {
            bool fehler = false;
            string userid = "";
            string zeitkonto_berechnungsstand_db = "";

            double zeitkonto_betrag_db = 0;
            double zeitkonto_betrag_tmp = 0;

            DateTime date_selected;
            DateTime date_berechnungsstand;
            DateTime ZielDatum;
            DateTime BerechnungsDatum_tmp;

            int jahr_tmp = 0;
            int monat_tmp = 0;
            int tag_tmp = 0;

            userid = PersonPicker_Stempelungen.Text;
            if (userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }

            //Zeitkonto-Berechnungsstand der gewählten Person aus Datenbank ermitteln.
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT zeitkonto_berechnungsstand, zeitkonto FROM user where userid=@userid";

            comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;
            try
            {
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();
                Reader.Read();

                zeitkonto_betrag_db = Convert.ToDouble(Reader["zeitkonto"]);
                zeitkonto_berechnungsstand_db = Reader["zeitkonto_berechnungsstand"] + "";
            }
            catch (Exception ex) { log(ex.Message); }
            close_db();

            //date_berechnungsstand setzen
            jahr_tmp = int.Parse(zeitkonto_berechnungsstand_db.Substring(0, 4));
            monat_tmp = int.Parse(zeitkonto_berechnungsstand_db.Substring(4, 2));
            tag_tmp = int.Parse(zeitkonto_berechnungsstand_db.Substring(6, 2));
            date_berechnungsstand = new DateTime(jahr_tmp, monat_tmp, tag_tmp, 0, 0, 0);

            //date_selected setzen
            jahr_tmp = DatePicker_Stempelungen.Value.Year;
            monat_tmp = DatePicker_Stempelungen.Value.Month;
            tag_tmp = DatePicker_Stempelungen.Value.Day;
            date_selected = new DateTime(jahr_tmp, monat_tmp, tag_tmp, 0, 0, 0);

            //while schleife so lange bis Berechnungsstand früher ist als gewähltes datum oder ein Fehler auftritt
            ZielDatum = date_selected.AddDays(-1);
            BerechnungsDatum_tmp = date_berechnungsstand;
            zeitkonto_betrag_tmp = zeitkonto_betrag_db;
            while (DateTime.Compare(BerechnungsDatum_tmp, ZielDatum) > 0 && fehler == false)
            {
                //IST-Zeit und SOLL-Zeit des Tages des Berechnungsstands berechnen
                double istzeit_tmp = -1;
                double sollzeit_tmp = -1;
                double zeitueberschuss_tmp = 0;
                istzeit_tmp = ermittleIstZeit(userid, BerechnungsDatum_tmp.Year.ToString("D4"), BerechnungsDatum_tmp.Month.ToString("D2"), BerechnungsDatum_tmp.Day.ToString("D2"));
                sollzeit_tmp = ermittleSollZeit(userid, BerechnungsDatum_tmp.Year.ToString("D4"), BerechnungsDatum_tmp.Month.ToString("D2"), BerechnungsDatum_tmp.Day.ToString("D2"));

                if (istzeit_tmp == -1 || sollzeit_tmp == -1)
                {
                    //bei einer der Zeitberechnungen trat ein Fehler auf...
                    fehler = true;
                    MessageBox.Show("Fehler bei der Ermittlung der Soll/Ist-Zeiten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Die berechnete Zeitkonto-änderung dieses Tages vom Zeitkontostand abziehen und Berechnungsstand auf einen Tag früher setzen
                    zeitueberschuss_tmp = istzeit_tmp - sollzeit_tmp;                   //Am aktuell betrachteten tag wurde das zeitkonto um so viel erhöht
                    zeitkonto_betrag_tmp = zeitkonto_betrag_tmp - zeitueberschuss_tmp;  //zieht man diesen überschuss wieder ab...
                    BerechnungsDatum_tmp = BerechnungsDatum_tmp.AddDays(-1);            //entspricht der neue Zeitkontostand dem des Vorabends.

                }

            }

            if (DateTime.Compare(BerechnungsDatum_tmp, ZielDatum) == 0)
            {   //Das Zieldatum für die Rückrechnung wurde erreicht -> Die While-Schleife wurde offensichtlich nicht wegen eines Fehlers vorzeitig beendet

                String zeitkonto_berechnungsstand_neu = BerechnungsDatum_tmp.Year.ToString("D4") + BerechnungsDatum_tmp.Month.ToString("D2") + BerechnungsDatum_tmp.Day.ToString("D2");

                //Den neue Datum für den Berechnungsstand und den neuen Betrag des Zeitkotnos in die Datenbank schreiben
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "UPDATE user SET zeitkonto=@zeitkonto, zeitkonto_berechnungsstand=@zeitkonto_berechnungsstand WHERE userid=@userid";

                comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;
                comm.Parameters.Add("@zeitkonto_berechnungsstand", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = zeitkonto_berechnungsstand_neu;
                comm.Parameters.Add("@zeitkonto", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                comm.Parameters["@zeitkonto"].Precision = 10;
                comm.Parameters["@zeitkonto"].Scale = 2;
                comm.Parameters["@zeitkonto"].Value = zeitkonto_betrag_tmp;

                log("setze Zeitkonto zurück. Berechnungsstand:'" + zeitkonto_berechnungsstand_db + "'->'" + zeitkonto_berechnungsstand_neu + "' Zeitkonto:'" + zeitkonto_betrag_db + "'->'" + zeitkonto_betrag_tmp + "'");

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                close_db();
            }

            //alles erledigt -> Status des Formulars sollte entsprechend aktualisiert werden
            vergleiche_Stempelungstab_Zeikonto_Berechnungsstand_Betrachtungsdatum();
            personentab_initialisiert_global = false; //systemdaten einer person haben sich geändert

        }

        private void button_Stempelungen_stornieren_Click(object sender, EventArgs e)
        {//Stempelung mit markierter ID stornieren

            //ID ermitteln
            string markierteID = "";
            markierteID = Stempelungsgrid_Stempelungen.SelectedCells[0].Value.ToString();

            //Bestaetigungsdialog vorbereiten
            string dialogtext = "Die Stempelung mit der ID:" + markierteID + " wirklich stornieren?";
            DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Stempelung stornieren
                open_db();
                comm.Parameters.Clear();
                comm.CommandText = "UPDATE stamps SET storniert=1 where stampid = @stampid";

                comm.Parameters.Add("@stampid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = markierteID;

                log("storniere Stempelung mit ID:" + markierteID);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                close_db();
            }
            refreshStempelungsgrid_Stempelungen();
            verrechnungstab_initialisiert_global = false; //gestempelte Zeit auf einem Auftrag kann sich geändert haben

        }

        private void button_Stempelungen_ueberschreiben_Click(object sender, EventArgs e)
        {
            bool fehler = false;

            string markierteID = "";
            string task = "";
            string art = "";
            string stunde = "";
            string minute = "";
            string sekunde = "";
            string dezimal = "";

            int stunde_int = 0;
            int minute_int = 0;
            int sekunde_int = 0;
            int dezimal_int = 0;

            //nötige Werte ermitteln
            markierteID = Stempelungsgrid_Stempelungen.SelectedCells[0].Value.ToString();
            task = textBox_Stempelungen_Auftragsnummer.Text;
            art = comboBox_Stempelungen_Art.Text;
            stunde_int = TimePicker_Stempelungen.Value.Hour;
            minute_int = TimePicker_Stempelungen.Value.Minute;
            sekunde_int = TimePicker_Stempelungen.Value.Second;
            dezimal_int = ((minute_int * 60) + sekunde_int) / 36;
            stunde = stunde_int.ToString("D2");
            minute = minute_int.ToString("D2");
            sekunde = sekunde_int.ToString("D2");
            dezimal = dezimal_int.ToString("D2");

            //ggf. Plausibilitätsprüfungen
            if (task.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Fehler! die Auftragsnummer muss eine 6-Stellige Nummer unter 999000 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (fehler == false)
            {
                //Bestaetigungsdialog vorbereiten
                string dialogtext = "Die Stempelung mit der ID:" + markierteID + " wirklich mit den eingegebenen Werten überschreiben?";
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Stempelung stornieren
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "UPDATE stamps SET task=@task, art=@art, stunde=@stunde, minute=@minute, sekunde=@sekunde, dezimal=@dezimal, quelle='admin' WHERE stampid = @stampid";

                    comm.Parameters.Add("@stampid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = markierteID;
                    comm.Parameters.Add("@task", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = task;
                    comm.Parameters.Add("@art", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = art;
                    comm.Parameters.Add("@stunde", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = stunde;
                    comm.Parameters.Add("@minute", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = minute;
                    comm.Parameters.Add("@sekunde", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = sekunde;
                    comm.Parameters.Add("@dezimal", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = dezimal;

                    log("Ändere Stempelung mit ID:" + markierteID + "..." +
                        "\r\n task:'" + task + "' " +
                        "\r\n art:'" + art + "' " +
                        "\r\n stunde:'" + stunde + "' " +
                        "\r\n minute:'" + minute + "' " +
                        "\r\n sekunde:'" + sekunde + "' " +
                        "\r\n dezimal:'" + dezimal + "' " +
                        "' \r\n");
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();
                }
                refreshStempelungsgrid_Stempelungen();
                verrechnungstab_initialisiert_global = false; //gestempelte Zeit auf einem Auftrag kann sich geändert haben
            }
        }

        private void button_Stempelungen_neueStempelung_Click(object sender, EventArgs e)
        {
            bool fehler = false;

            string userid = "";
            string task = "";
            string art = "";
            string jahr = "";
            string monat = "";
            string tag = "";
            string stunde = "";
            string minute = "";
            string sekunde = "";
            string dezimal = "";

            int stunde_int = 0;
            int minute_int = 0;
            int sekunde_int = 0;
            int dezimal_int = 0;

            //nötige Werte ermitteln
            userid = PersonPicker_Stempelungen.Text;
            if (userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }

            task = textBox_Stempelungen_Auftragsnummer.Text;
            art = comboBox_Stempelungen_Art.Text;

            jahr = DatePicker_Stempelungen.Value.Year.ToString("D4");
            monat = DatePicker_Stempelungen.Value.Month.ToString("D2");
            tag = DatePicker_Stempelungen.Value.Day.ToString("D2");

            stunde_int = TimePicker_Stempelungen.Value.Hour;
            minute_int = TimePicker_Stempelungen.Value.Minute;
            sekunde_int = TimePicker_Stempelungen.Value.Second;
            dezimal_int = ((minute_int * 60) + sekunde_int) / 36;
            stunde = stunde_int.ToString("D2");
            minute = minute_int.ToString("D2");
            sekunde = sekunde_int.ToString("D2");
            dezimal = dezimal_int.ToString("D2");

            //Plausibilitätsprüfung der Auftragsnummer
            if (task.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Fehler! die Auftragsnummer muss eine 6-Stellige Nummer unter 999000 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (fehler == false)
            {
                //Bestaetigungsdialog vorbereiten
                string dialogtext = "Eine neue Stempelung mit diesen Werten erstellen?";
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Stempelung stornieren
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "INSERT INTO stamps (userid,task,art,jahr,monat,tag,stunde,minute,sekunde,dezimal,quelle,storniert) " +
                                        "VALUES(@userid,@task,@art,@jahr,@monat,@tag,@stunde,@minute,@sekunde,@dezimal,'admin',0)";

                    comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;
                    comm.Parameters.Add("@task", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = task;
                    comm.Parameters.Add("@art", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = art;
                    comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = jahr;
                    comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = monat;
                    comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = tag;
                    comm.Parameters.Add("@stunde", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = stunde;
                    comm.Parameters.Add("@minute", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = minute;
                    comm.Parameters.Add("@sekunde", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = sekunde;
                    comm.Parameters.Add("@dezimal", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = dezimal;


                    log("Erstelle neue Stempelung für user " + userid + "..." +
                        "\r\n task:'" + task + "' " +
                        "\r\n art:'" + art + "' " +
                        "\r\n jahr:'" + jahr + "' " +
                        "\r\n monat:'" + monat + "' " +
                        "\r\n tag:'" + tag + "' " +
                        "\r\n stunde:'" + stunde + "' " +
                        "\r\n minute:'" + minute + "' " +
                        "\r\n sekunde:'" + sekunde + "' " +
                        "\r\n dezimal:'" + dezimal + "' " +
                        "' \r\n");
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();
                }
                refreshStempelungsgrid_Stempelungen();
                verrechnungstab_initialisiert_global = false; //gestempelte Zeit auf einem Auftrag kann sich geändert haben
            }
        }

        private void button_Stempelungen_Tagzurueck_Click(object sender, EventArgs e)
        {
            //Datepicker auf einen Tag früher setzen
            DatePicker_Stempelungen.Value = DatePicker_Stempelungen.Value.AddDays(-1);
        }

        private void button_Stempelungen_Tagvorwaerts_Click(object sender, EventArgs e)
        {
            //Datepicker auf einen Tag später setzen
            DatePicker_Stempelungen.Value = DatePicker_Stempelungen.Value.AddDays(1);
        }


        ///////////Verrechnung-Tab/////////////////////////////////////////////

        private void Auftragspicker_Verrechnung_Insert_Click(object sender, EventArgs e)
        {
            refreshAuftragsPicker_Verrechnung_Insert();
        }

        private void refreshAuftragsPicker_Verrechnung_Insert()
        {
            string thistaskid = "";

            Auftragspicker_Verrechnung_Insert.Items.Clear();

            open_db();
            comm.Parameters.Clear();

            //Das Ergebnis sollte alle Auftragsnummern enthalten, zu denen es für mindestens eine Person zwar Stempelungen aber keine Verrechnungen gibt.
            //Dafür ist besonders wichtig, dass die bedingung und auch die gruppierung nach task UND userid gemacht werden

            comm.CommandText = "SELECT DISTINCT a.task from stamps a where a.storniert = 0 AND NOT EXISTS (SELECT NULL" +
                                " FROM verrechnung b WHERE a.task = b.auftrag AND a.userid = b.person AND b.storniert = 0)" +
                                " GROUP BY a.task, a.userid ORDER BY a.task";

            try
            {
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf entspricht einer Auftragsnummer
                while (Reader.Read())
                {
                    thistaskid = Reader["task"] + "";

                    Auftragspicker_Verrechnung_Insert.Items.Add(thistaskid);

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }


            close_db();

            PersonPicker_Kalender.SelectedIndex = 0;
        }

        private void Auftragspicker_Verrechnung_Insert_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ausgewählte Auftragsnummer in Auftragsnummern-Eingabefeld übernehmen
            textBox_Verrechnung_Auftragsnummer.Text = Auftragspicker_Verrechnung_Insert.Text;
            //dadurch triggert auch textBox_Verrechnung_Auftragsnummer_TextChanged()
        }

        private void textBox_Verrechnung_Auftragsnummer_TextChanged(object sender, EventArgs e)
        {   
            if(textBox_Verrechnung_Auftragsnummer.Text.Length == 6)
            {
                //nach Problemen mit den Stempelungen des Auftrags suchen
                if(sucheStempelfehler_Verrechnung() == true)
                {
                    //TODO gut sichtbares Warn-Label anzeigen mit Hinweis dass die angezeigten Zeiten vermutlich nicht stimmen.
                }

                //linke seite refreshen
                refreshInsertFormular_Verrechnung();

                //rechte seite refreshen
                refreshUpdateFormular_Verrechnung();
            }
        }

        private bool sucheStempelfehler_Verrechnung()
        {
            bool fehler = false;

            //TODO nach offensichtlichen Problemen in den Stempelungen zum Auftrag suchen und warnen
            //Testfall 1 (anzahlen der ab/an stempelungen einer person an einem tag passen nicht zusammen)?
            //Testfall 2 (unkorrigierte Wartungsstempelung vorhanden)

            //vergleich: Tests aus der vergleichbaren funktion im Stempelungstab
                //Test 1: Ist die erste Stempelung keine anstempelung?
                //Test 2: kommt nicht immer abwechselnd eine an + eine abstempelung?
                //Test 3: Hat ein Paar aus AN+AB-Stempelung verschiedene Auftragsnummern?
                //Test 4: unkorrigierte automatische Abstempelung von einem Wartungslauf? (quelle = 'wartung')
                //Test 5: Datum ist früher als das heutige und letzte Stempelung ist keine Abstempelung?


            // -> ausgeben an welchem tag bei welcher person das Problem besteht

            return fehler;

        }

        private void refreshInsertFormular_Verrechnung()//linke seite
        {
            string this_userid = "";
            string this_name = "";
            string this_ancount = "";
            string this_abcount = "";
            string this_laststamp = "";
            string this_summezeiten = "";

            Verrechnungsgrid_Verrechnungen_Insert.Rows.Clear();

            //für den gewählten Auftrag je Mitarbeiter die summe der abstempelungen und anstempelungen ermitteln 
            string Auftragsnummer = textBox_Verrechnung_Auftragsnummer.Text;

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "select an.userid, user.name, an.count as ancount, ab.count as abcount, laststamp, round(sum_ab-sum_an, 2) as summezeiten " +
                                    "from " +
                                        "(select userid, sum(stunde) + sum(dezimal) / 100 as sum_ab, max(concat(jahr, monat, tag)) as laststamp, count(stunde) as count " +
                                            "from stamps where art = 'ab' and task = @task and storniert = 0 group by userid) ab," +
                                        "(select userid, sum(stunde) + sum(dezimal) / 100 as sum_an, count(stunde) as count " +
                                            "from stamps where art = 'an' and task = @task and storniert = 0 group by userid) an " +
                                    "left join user on an.userid = user.userid " +
                                    "WHERE ab.userid = an.userid " +
                                    "AND NOT EXISTS (SELECT * FROM verrechnung v WHERE v.person=an.userid AND v.auftrag = @task AND storniert = 0)";

            comm.Parameters.Add("@task", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = Auftragsnummer;

            try
            {
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf/ErgebnisZeile betrachtet die Stempelungen einer Person auf den Auftrag
                while (Reader.Read())
                {
                    this_userid = Reader["userid"] + "";
                    this_name = Reader["name"] + "";
                    this_ancount = Reader["ancount"] + "";
                    this_abcount = Reader["abcount"] + "";
                    this_laststamp = Reader["laststamp"] + "";
                    this_summezeiten = Reader["summezeiten"] + "";

                    //datum in leserliches Format bringen
                    this_laststamp = this_laststamp.Substring(6, 2) + "." + this_laststamp.Substring(4, 2) + "." + this_laststamp.Substring(0, 4);

                    //Stempelungsgrid befüllen
                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell_userid = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_name = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_laststamp = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_summezeiten = new DataGridViewTextBoxCell();

                    cell_userid.Value = this_userid;
                    cell_name.Value = this_name;
                    cell_laststamp.Value = this_laststamp;
                    cell_summezeiten.Value = this_summezeiten;

                    myrow.Cells.Add(cell_userid);
                    myrow.Cells.Add(cell_name);
                    myrow.Cells.Add(cell_laststamp);
                    myrow.Cells.Add(cell_summezeiten);

                    Verrechnungsgrid_Verrechnungen_Insert.Rows.Add(myrow);

                    if (this_abcount != this_ancount)
                    {
                        //zeiten markieren in zeilen in denen ancount von abcount abweicht
                        int actrow = Verrechnungsgrid_Verrechnungen_Insert.Rows.Count - 1;

                        Verrechnungsgrid_Verrechnungen_Insert.Rows[actrow].Cells[3].ToolTipText = "Anzahl An-/Ab-Stempelungen passt nichtzusammen.\r\nAngezeigte Zeit stimmt vermutlich nicht!";
                        Verrechnungsgrid_Verrechnungen_Insert.Rows[actrow].Cells[3].Style.BackColor = Color.Orange;
                    }

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }

            close_db();
            Verrechnungsgrid_Verrechnungen_Insert.ClearSelection();

        }

        private void refreshUpdateFormular_Verrechnung()//rechte seite
        {
            Verrechnungsgrid_Verrechnungen_Update.Rows.Clear();

            string this_satzid = "";
            string this_userid = "";
            string this_name = "";
            string this_datum = "";
            string this_stunden = "";
            string this_gesamtzeit = "";

            //Fuellen der Anzeige mit der gesamten auf den Auftrag verrechneten Zeit
            string Auftragsnummer = textBox_Verrechnung_Auftragsnummer.Text;

            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT SUM(stunden) FROM verrechnung WHERE auftrag=@auftrag AND storniert = 0";

            comm.Parameters.Add("@auftrag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = Auftragsnummer;

            try
            {
                this_gesamtzeit = comm.ExecuteScalar() + "";
            }
            catch (Exception ex) { log(ex.Message); }

            close_db();

            textBox_Verrechnung_StundenGesamt.Text = this_gesamtzeit;


            //Fuellen des Grids mit den einzelnen Verrechnungssaetzen
            open_db();
            comm.Parameters.Clear();
            comm.CommandText = "SELECT a.satzid, a.person, b.name, a.jahr, a.monat, a.tag, a.stunden " +
                                "FROM verrechnung a LEFT JOIN user b ON a.person = b.userid " +
                                "WHERE auftrag=@auftrag AND storniert = 0" ;

            comm.Parameters.Add("@auftrag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = Auftragsnummer;

            try
            {
                MySql.Data.MySqlClient.MySqlDataReader Reader = comm.ExecuteReader();

                //jeder Schleifendurchlauf/ErgebnisZeile betrachtet die Stempelungen einer Person auf den Auftrag
                while (Reader.Read())
                {
                    this_satzid = Reader["satzid"] + "";
                    this_userid = Reader["person"] + "";
                    this_name = Reader["name"] + "";
                    this_datum = Reader["tag"] + "." + Reader["monat"] + "." + Reader["jahr"];
                    this_stunden = Reader["stunden"] + "";

                    //Stempelungsgrid befüllen
                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell_satzid = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_userid = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_name = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_datum = new DataGridViewTextBoxCell();
                    DataGridViewCell cell_stunden = new DataGridViewTextBoxCell();

                    cell_satzid.Value = this_satzid;
                    cell_userid.Value = this_userid;
                    cell_name.Value = this_name;
                    cell_datum.Value = this_datum;
                    cell_stunden.Value = this_stunden;

                    myrow.Cells.Add(cell_satzid);
                    myrow.Cells.Add(cell_userid);
                    myrow.Cells.Add(cell_name);
                    myrow.Cells.Add(cell_datum);
                    myrow.Cells.Add(cell_stunden);

                    Verrechnungsgrid_Verrechnungen_Update.Rows.Add(myrow);

                }
                Reader.Close();
            }
            catch (Exception ex) { log(ex.Message); }

            close_db();

            Verrechnungsgrid_Verrechnungen_Update.ClearSelection();

        }

        private void Verrechnungsgrid_Verrechnungen_Insert_SelectionChanged(object sender, EventArgs e)
        {
            //prüfen ob eine Zeile markiert ist und wenn ja das insert-Formular fuellen
            if (Verrechnungsgrid_Verrechnungen_Insert.SelectedRows.Count == 1)
            {
                prefillInsertFormular_Verrechnung();

            }
            else
            {   //nichts markiert... insert formular leeren
                clearInsertFormular_Verrechnung();
            }
        }

        private void clearInsertFormular_Verrechnung()
        {
            //insert-formular leeren, Datepicker auf heutiges datum setzen
            textBox_Verrechnungen_Mitarbeiter_Insert.Text = "";
            textBox_Verrechnungen_Stunden_Insert.Text = "";
            DatePicker_Verrechnung_Insert.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        }

        private void prefillInsertFormular_Verrechnung()
        {
            //Insert-Formular mit den Werten der Markierung vorbelegen 
            //(Stunde wird absichtlich nicht vorgefüllt -> dieser wert soll bewusst eingetragen werden)

            textBox_Verrechnungen_Mitarbeiter_Insert.Text = Verrechnungsgrid_Verrechnungen_Insert.SelectedCells[0].Value.ToString();

            int selection_tag_laststamp = int.Parse(Verrechnungsgrid_Verrechnungen_Insert.SelectedCells[2].Value.ToString().Substring(0, 2));
            int selection_monat_laststamp = int.Parse(Verrechnungsgrid_Verrechnungen_Insert.SelectedCells[2].Value.ToString().Substring(3, 2));
            int selection_jahr_laststamp = int.Parse(Verrechnungsgrid_Verrechnungen_Insert.SelectedCells[2].Value.ToString().Substring(6, 4));
            DatePicker_Verrechnung_Insert.Value = new DateTime(selection_jahr_laststamp, selection_monat_laststamp, selection_tag_laststamp, 0, 0, 0);

        }

        private void button_Verrechnungen_SatzErstellen_Click(object sender, EventArgs e)
        {
            bool fehler = false;

            string insert_auftragsnummer = "";
            string insert_userid = "";
            string insert_tag = "";
            string insert_monat = "";
            string insert_jahr = "";
            string insert_stunden = "";
            int tmp_intout = 0;
            double tmp_doubleout = 0;

            //Werte sammeln
            insert_auftragsnummer = textBox_Verrechnung_Auftragsnummer.Text;
            insert_userid = textBox_Verrechnungen_Mitarbeiter_Insert.Text;
            insert_tag = DatePicker_Verrechnung_Insert.Value.Day.ToString("D2");
            insert_monat = DatePicker_Verrechnung_Insert.Value.Month.ToString("D2");
            insert_jahr = DatePicker_Verrechnung_Insert.Value.Year.ToString("D4");
            insert_stunden = textBox_Verrechnungen_Stunden_Insert.Text;

            //Werte plausibilisieren

            if (insert_auftragsnummer.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Die eingegebene Auftragsnummer ist nicht 6-Stellig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(insert_auftragsnummer, out tmp_intout) == false)
            {
                fehler = true;
                MessageBox.Show("Die eingegebene Auftragsnummer ist keine Zahl.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (insert_userid.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Die eingegebene Mitarbeiternummer ist nicht 6-Stellig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tmp_intout = 0;
            if (int.TryParse(insert_userid, out tmp_intout) == false)
            {
                fehler = true;
                MessageBox.Show("Die eingegebene Mitarbeiternummer ist keine Zahl!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tmp_intout < 999000)
            {
                fehler = true;
                MessageBox.Show("Die Mitarbeiternummer darf nicht kleiner als 999000 sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tmp_doubleout = 0;
            if (double.TryParse(insert_stunden, out tmp_doubleout) == false)
            {
                fehler = true;
                MessageBox.Show("Die eingegebene Zeit ist keine Zahl!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (fehler == false)
            {
                //Bestaetigungsdialog vorbereiten
                string dialogtext = "Folgendes Verrechnungssatz für den Auftrag'" + insert_auftragsnummer + "' erstellen?\r\n\r\n" +
                                        "Mitarbeiternummer: " + insert_userid + "\r\n" +
                                        "Verrechnungsdatum: " + insert_tag + "." + insert_monat + "." + insert_jahr + "\r\n" +
                                        "Verrechenbare Zeit: " + insert_stunden + " Stunden";
                DialogResult dialogResult = MessageBox.Show(dialogtext, "Sicher?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //insert auf Datenbank
                    open_db();
                    comm.Parameters.Clear();
                    comm.CommandText = "INSERT INTO verrechnung (auftrag, person, stunden, jahr, monat, tag, storniert) " +
                                        "VALUES(@auftrag, @person, @stunden, @jahr, @monat, @tag, 0)";

                    comm.Parameters.Add("@auftrag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = insert_auftragsnummer;
                    comm.Parameters.Add("@person", MySql.Data.MySqlClient.MySqlDbType.VarChar, 9).Value = insert_userid;
                    comm.Parameters.Add("@jahr", MySql.Data.MySqlClient.MySqlDbType.VarChar, 4).Value = insert_jahr;
                    comm.Parameters.Add("@monat", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = insert_monat;
                    comm.Parameters.Add("@tag", MySql.Data.MySqlClient.MySqlDbType.VarChar, 2).Value = insert_tag;
                    comm.Parameters.Add("@stunden", MySql.Data.MySqlClient.MySqlDbType.Decimal, 10);
                    comm.Parameters["@stunden"].Precision = 10;
                    comm.Parameters["@stunden"].Scale = 2;
                    comm.Parameters["@stunden"].Value = insert_stunden;

                    log("Erstelle Verrechnungssatz zu Auftrag " + insert_auftragsnummer + " am " + insert_tag + "." + insert_monat + "." + insert_jahr + " " +
                           "Mitarbeiter: " + insert_userid + " Stunden: " + insert_stunden);
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex) { log(ex.Message); }
                    close_db();

                    //nach erfolgreichem anlegen des Verrechnungssatzes beide seiten aktualisieren
                    refreshInsertFormular_Verrechnung();
                    refreshUpdateFormular_Verrechnung();

                }
            }
        }

        private void clearUpdateFormular_Verrechnung()
        {
            //TODO
        }

        private void prefillUpdateFormular_Verrechnung()
        {
            //TODO Felder mit den Daten des Markierten Satzes vorbefuellen
        }

        private void button_Verrechnungen_SatzStornieren_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button_Verrechnungen_SatzUeberschreiben_Click(object sender, EventArgs e)
        {
            //TODO
        }

        
        ///////////Personen-Tab////////////////////////////////////////////////

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
            if (thisperson_userid.Length >= 6)
            {
                thisperson_userid = thisperson_userid.Substring(0, 6);
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
            textBox_Personen_Nachname.Text = thisperson_nachname;
            textBox_Personen_Vorname.Text = thisperson_vorname;
            textBox_Personen_AktAuftrag.Text = thisperson_currenttask;
            textBox_Personen_Zeitkonto.Text = thisperson_zeitkonto;
            textBox_Personen_ZeitkontoBerechnungsstand.Text = thisperson_zeitkonto_berechnungsstand;
            textBox_Personen_Boniausgezahltbis.Text = thisperson_bonuskonto_ausgezahlt_bis;
            textBox_Personen_BetragletzterBonus.Text = thisperson_bonuszeit_bei_letzter_auszahlung;
            textBox_Personen_Urlaubstage.Text = thisperson_jahresurlaub;

            comboBox_Personen_Aktiv.SelectedIndex = 0;
            comboBox_Personen_Stempelfehler.SelectedIndex = 0;
            if (thisperson_aktiv) { comboBox_Personen_Aktiv.SelectedIndex = 1; }
            if (thisperson_stempelfehler) { comboBox_Personen_Stempelfehler.SelectedIndex = 1; }

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

            if (input_userid.Length != 6 || !input_userid.StartsWith("999"))
            {
                MessageBox.Show("Die gewünschte ID ist nicht gültig. \r\n\r\n Es muss eine 6-Stellige Zahl über 999000 sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fehler = true;
            }

            if (input_vorname == "")
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
            if (userid.Length >= 6)
            {
                userid = userid.Substring(0, 6);
            }
            else
            {
                fehler = true;
                MessageBox.Show("Fehler! Die Mitarbeiter-ID ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_currenttask = textBox_Personen_AktAuftrag.Text;
            if (new_currenttask != "" && new_currenttask.Length != 6)
            {
                fehler = true;
                MessageBox.Show("Fehler! Wert für aktuelle Auftragsnummer ungültig. (Auftragsnummern sind 6-Stellig und kleiner als 999000)", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (new_currenttask != "" && int.Parse(new_currenttask) >= 999000)
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
            if (new_zeitkonto_berechnungsstand.Length != 8)
            {
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Zeitkonto-Berechnungsstand ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_bonuskonto_ausgezahlt_bis = textBox_Personen_Boniausgezahltbis.Text;
            if (new_bonuskonto_ausgezahlt_bis.Length != 8)
            {
                fehler = true;
                MessageBox.Show("Fehler! Der angegebene Wert für den Bonus-Auszahlungsstand ist ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new_aktiv = false;
            if (comboBox_Personen_Aktiv.Text == "1") { new_aktiv = true; }

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
                    comm.Parameters.Add("@stempelfehler", MySql.Data.MySqlClient.MySqlDbType.Byte, 1).Value = new_stempelfehler;
                    comm.Parameters.Add("@aktiv", MySql.Data.MySqlClient.MySqlDbType.Byte, 1).Value = new_aktiv;
                    comm.Parameters.Add("@userid", MySql.Data.MySqlClient.MySqlDbType.VarChar, 6).Value = userid;

                    //veränderte Daten loggen für nachvollziehbarkeit.
                    log("Update auf Person:" + userid + "..." +
                        "\r\n Name:'" + textBox_Personen_Nachname_old.Text + "'->'" + textBox_Personen_Nachname.Text + "' " +
                        "\r\n Vorname:'" + textBox_Personen_Vorname_old.Text + "'->'" + textBox_Personen_Vorname.Text + "' " +
                        "\r\n Jahresurlaub:'" + textBox_Personen_Urlaubstage_old.Text + "'->'" + textBox_Personen_Urlaubstage.Text + "' " +
                        "\r\n Aktiv:'" + comboBox_Personen_Aktiv_old.Text + "'->'" + comboBox_Personen_Aktiv.Text + "' " +
                        "\r\n Currenttask:'" + textBox_Personen_AktAuftrag_old.Text + "'->'" + textBox_Personen_AktAuftrag.Text + "' " +
                        "\r\n Zeitkonto:'" + textBox_Personen_Zeitkonto_old.Text + "'->'" + textBox_Personen_Zeitkonto.Text + "' " +
                        "\r\n Zeitkonto_Berechnungsstand:'" + textBox_Personen_ZeitkontoBerechnungsstand_old.Text + "'->'" + textBox_Personen_ZeitkontoBerechnungsstand.Text + "' " +
                        "\r\n Boni_ausgezahlt_bis:'" + textBox_Personen_Boniausgezahltbis_old.Text + "'->'" + textBox_Personen_Boniausgezahltbis.Text + "' " +
                        "\r\n Betrag_letzter_Bonus:'" + textBox_Personen_BetragletzterBonus_old.Text + "'->'" + textBox_Personen_BetragletzterBonus.Text + "' " +
                        "\r\n Stempelfehler:'" + comboBox_Personen_Stempelfehler_old.Text + "'->'" + comboBox_Personen_Stempelfehler.Text
                        + "' \r\n");
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
            if (textBox_Personen_Vorname.Text == textBox_Personen_Vorname_old.Text)
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
            //fokus von der combobox nehmen, damit man die goldene markierung sehen kann
            this.ActiveControl = null;
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
            //fokus von der combobox nehmen, damit man die goldene markierung sehen kann
            this.ActiveControl = null;
        }

        
        ///////////////////////////////////////////////////////////////////////

    }
}
