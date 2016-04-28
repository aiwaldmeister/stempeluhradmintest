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
            int selectedCellCount = dataGridView1.SelectedCells.Count;
            for (int i = 0;
                i < selectedCellCount; i++)
            {
                string cellvaluestring = dataGridView1.SelectedCells[i].Value.ToString();
                cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");

                if (cellvaluestring != "")
                {
                    MessageBox.Show( cellvaluestring + "." + dateTimePicker1.Value.Month.ToString("D2")+ "." + dateTimePicker1.Value.Year.ToString("D4"));
                }
            }
        }

        private void markiereBesondereTage()
        {
            string cellvaluestring = "";
            string betrachtungsjahr = dateTimePicker1.Value.Year.ToString("D4");
            string betrachtungsmonat = dateTimePicker1.Value.Month.ToString("D2");

            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    cellvaluestring = dataGridView1.Rows[actrow].Cells[actcol].Value.ToString();
                    cellvaluestring = Int32.Parse(cellvaluestring).ToString("D2");
                    if (cellvaluestring != "")
                    {   //select auf kalenderdatenbank mit betrachtungsjahr, betrachtungsmonat, betrachtungstag(cellvaluestring)
                        //wenn ereignis für diesen Tag gefunden, die cell einfärben und den tooltip setzen
                        
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void initKalender(int Betrachtungsmonat, int Betrachtungsjahr)
        {
            DateTime Betrachtungsdatum = new DateTime(Betrachtungsjahr,Betrachtungsmonat,1); //Startdate auf den ersten des Monats stellen
            int Wochentagdesersten = ((int)Betrachtungsdatum.DayOfWeek == 0) ? 7 : (int)Betrachtungsdatum.DayOfWeek; //Nummer des Wochentags des ersten des Monats (Montag = 1, etc...)

            dataGridView1.RowCount = 6;
            dataGridView1.GridColor = Color.LightGray;

            int i = 1;
            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    if((actrow == 0 && actcol + 1 < Wochentagdesersten) || i > DateTime.DaysInMonth(Betrachtungsjahr,Betrachtungsmonat))
                    {
                        dataGridView1.Rows[actrow].Cells[actcol].Value = "";
                        dataGridView1.Rows[actrow].Cells[actcol].Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        dataGridView1.Rows[actrow].Cells[actcol].Value = i.ToString();
                        dataGridView1.Rows[actrow].Cells[actcol].Style.BackColor = Color.White;
                        dataGridView1.Rows[actrow].Cells[actcol].ToolTipText = "test\r\ntest";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            initKalender(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initKalender(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
        }
    }
}
