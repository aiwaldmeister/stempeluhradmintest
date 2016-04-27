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
            initCalendar(DateTime.Now.Month,DateTime.Now.Year);

            //dataGridView1.RowCount = 5;
            //dataGridView1.Rows[0].Cells[0].Value = "";
            //dataGridView1.Rows[0].Cells[1].Value = "1";

        }

        private void initCalendar(int Betrachtungsmonat, int Betrachtungsjahr)
        {
            DateTime Betrachtungsdatum = new DateTime(Betrachtungsjahr,Betrachtungsmonat,1); //Startdate auf den ersten des Monats stellen
            int Wochentagdesersten = ((int)Betrachtungsdatum.DayOfWeek == 0) ? 7 : (int)Betrachtungsdatum.DayOfWeek; //Nummer des Wochentags des ersten des Monats (Montag = 1, etc...)

            dataGridView1.RowCount = 6;

            int i = 1;
            for (int actrow = 0; actrow < 6; actrow++)
            {
                for (int actcol = 0; actcol < 7; actcol++)
                {
                    if((actrow == 0 && actcol + 1 < Wochentagdesersten) || i > DateTime.DaysInMonth(Betrachtungsjahr,Betrachtungsmonat))
                    {
                        dataGridView1.Rows[actrow].Cells[actcol].Value = "";
                        dataGridView1.Rows[actrow].Cells[actcol].Style.BackColor =Color.LightGray;
                    }
                    else
                    {
                        dataGridView1.Rows[actrow].Cells[actcol].Value = i.ToString();
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
    }
}
