using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stempelurhadmintest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Messagebox für jede selectierte zelle
            int selectedCellCount = KalenderGrid_Kalender.SelectedCells.Count;
            for (int i = 0;
                i < selectedCellCount; i++)
            {
                string cellvaluestring = KalenderGrid_Kalender.SelectedCells[i].Value.ToString();
                
                if (cellvaluestring != "")
                {
                    cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                    MessageBox.Show( cellvaluestring + "." + MonatsPicker_Kalender.Value.Month.ToString("D2")+ "." + MonatsPicker_Kalender.Value.Year.ToString("D4"));

                    DataGridViewRow myrow = new DataGridViewRow();
                    DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                    DataGridViewCell cell4 = new DataGridViewTextBoxCell();

                    cell1.Value = cellvaluestring + "." + MonatsPicker_Kalender.Value.Month.ToString("D2");
                    myrow.Cells.Add(cell1);

                    cell2.Value = "7.2";
                    myrow.Cells.Add(cell2);

                    cell3.Value = "0";
                    myrow.Cells.Add(cell3);

                    cell4.Value = "Testeintrag Blablabla";
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

            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    
                    if (cellvaluestring != "")
                    {   //Aktuelle Zelle enthält einen Tag

                        cellvaluestring = KalenderGrid_Kalender.Rows[actrow].Cells[actcol].Value.ToString();
                        cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");

                        //TODO
                        //select auf kalenderdatenbank mit betrachtungsjahr, betrachtungsmonat, betrachtungstag(cellvaluestring)
                        //wenn ereignis für diesen Tag gefunden, die cell einfärben und den tooltip setzen


                        //dataGridView1.Rows[actrow].Cells[actcol].ToolTipText = "test\r\ntest";
                    }
                    else
                    {   //Aktuelle Zelle enthält keinen Tag
                        
                    }
                }
            }
        }

        private void initKalender(int Betrachtungsmonat, int Betrachtungsjahr)
        {
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
                }
            }




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

        private void initPersonPicker()
        {
            //TODO Datenbankverbindung herstellen
            //TODO Personen der Personentabelle dem PersonPicker hinzufügen
        }

        private void MonatsPicker_ValueChanged(object sender, EventArgs e)
        {
            initKalender(MonatsPicker_Kalender.Value.Month, MonatsPicker_Kalender.Value.Year);
            markiereTagemitEreignissen("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initKalender(MonatsPicker_Kalender.Value.Month, MonatsPicker_Kalender.Value.Year);
            initPersonPicker();
        }

        private void openEventEditor()
        {
            //TODO Datum und Person festschreiben
            //TODO Panel anzeigen
            //TODO Felder vorbefüllen und auf update-modus stellen falls schon event vorhanden
        }

        private void PersonPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PersonPicker_Kalender.SelectedValue != null && PersonPicker_Kalender.SelectedValue.ToString()=="Allgemein")
            {
                //TODO Ausgewählte Person auf "" setzen
                //Personenanzeige auf Allgemein setzen
            }else
            {
                //TODO Namen und Nachnamen aus der Datenbank holen und Personenanzeige setzen
            }

        }

        private void button_Kalender_ganzerTagUrlaub_Click(object sender, EventArgs e)
        {   
            //Voreinstellungen für ganzen Urlaubstag setzen...
            textBox_Kalender_Sollzeit.Text = "0";
            textBox_Kalender_Urlaub.Text = "1";
            textBox_Kalender_Bemerkung.Text = "Urlaub";

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
    }
}
