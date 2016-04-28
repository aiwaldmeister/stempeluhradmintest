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
            int selectedCellCount = KalenderGrid.SelectedCells.Count;
            for (int i = 0;
                i < selectedCellCount; i++)
            {
                string cellvaluestring = KalenderGrid.SelectedCells[i].Value.ToString();
                cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                if (cellvaluestring != "")
                {
                    MessageBox.Show( cellvaluestring + "." + MonatsPicker.Value.Month.ToString("D2")+ "." + MonatsPicker.Value.Year.ToString("D4"));
                }
            }
        }

        private void markiereTagemitEreignissen(String PersonFilter)
        {
            string cellvaluestring = "";
            string betrachtungsjahr = MonatsPicker.Value.Year.ToString("D4");
            string betrachtungsmonat = MonatsPicker.Value.Month.ToString("D2");

            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    cellvaluestring = KalenderGrid.Rows[actrow].Cells[actcol].Value.ToString();
                    cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                    if (cellvaluestring != "")
                    {   //Aktuelle Zelle enthält einen Tag

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

            KalenderGrid.RowCount = 6;
            KalenderGrid.GridColor = Color.LightGray;

            int i = 1;
            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    if((actrow == 0 && actcol + 1 < Wochentagdesersten) || i > DateTime.DaysInMonth(Betrachtungsjahr,Betrachtungsmonat))
                    {
                        KalenderGrid.Rows[actrow].Cells[actcol].Value = "";
                        KalenderGrid.Rows[actrow].Cells[actcol].Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        KalenderGrid.Rows[actrow].Cells[actcol].Value = i.ToString();
                        KalenderGrid.Rows[actrow].Cells[actcol].Style.BackColor = Color.White;
                        if(actcol + 1 >= 6)
                        {
                            KalenderGrid.Rows[actrow].Cells[actcol].Style.BackColor = Color.Beige;
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
            initKalender(MonatsPicker.Value.Month, MonatsPicker.Value.Year);
            markiereTagemitEreignissen("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initKalender(MonatsPicker.Value.Month, MonatsPicker.Value.Year);
            initPersonPicker();
        }

        private void openEventEditor()
        {
        //TODO Datum und Person festschreiben
        //TODO Panel anzeigen
        //TODO Felder vorbefüllen und auf update-modus stellen falls schon event vorhanden
        }

    }
}
