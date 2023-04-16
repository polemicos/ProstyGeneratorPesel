using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pesel_MikitaRakovich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string zwrocDateUrodzenia(string pesel1)
        {
            /*
            dla lat 1800 - 1899 - 80
            dla lat 1900 - 1999 - 0
            dla lat 2000 - 2099 - 20
            dla lat 2100 - 2199 - 40
            dla lat 2200 - 2299 - 60
             */


            IDictionary<string, string> data = new Dictionary<string, string>();
            data["rok"] = pesel1.Substring(0, 2);
            data["miesiac"] = pesel1.Substring(2, 2);
            data["dzien"] = pesel1.Substring(4, 2);
            //sprawdzanie odpowiednosci
            string res = "";
            if ((Int32.Parse(data["miesiac"]) < 1 || Int32.Parse(data["miesiac"]) > 92) || (Int32.Parse(data["dzien"]) < 1 || Int32.Parse(data["dzien"]) > 31))
            {
                labelBlad.Text = "Błąd! Szprawdź pierwsze 6 cyfr!";
                labelBlad.Visible = true;
                labelUdane.Visible = false;
                return "";
            }
            //liczenie daty
            if (Int32.Parse(data["miesiac"]) > 12)
            {
                res += data["dzien"] + ".";
                if(Int32.Parse(data["miesiac"]) - 80 <= 12 && Int32.Parse(data["miesiac"]) - 80 >= 0)
                {
                    res += Int32.Parse(data["miesiac"]) - 80 + ".";
                    res += "18" + data["rok"];
                }
                else if (Int32.Parse(data["miesiac"]) - 20 <= 12 && Int32.Parse(data["miesiac"]) - 20 >= 0)
                {
                    res += Int32.Parse(data["miesiac"]) - 20 + ".";
                    res += "20" + data["rok"];
                }
                else if (Int32.Parse(data["miesiac"]) - 40 <= 12 && Int32.Parse(data["miesiac"]) - 40 >= 0)
                {
                    res += Int32.Parse(data["miesiac"]) - 40 + ".";
                    res += "21" + data["rok"];
                }
                else if (Int32.Parse(data["miesiac"]) - 60 <= 12 && Int32.Parse(data["miesiac"]) - 60 >= 0)
                {
                    res += Int32.Parse(data["miesiac"]) - 60 + ".";
                    res += "22" + data["rok"];
                }
                else
                {
                    labelBlad.Text = "Błąd! Szprawdź 3 i 4 cyfry!";
                    labelBlad.Visible = true;
                    labelUdane.Visible = false;
                    return "";
                }
            }
            else if (Int32.Parse(data["miesiac"]) <= 12 && Int32.Parse(data["miesiac"]) >= 1)
            {
                res += data["dzien"] + ".";
                res += Int32.Parse(data["miesiac"]) + ".";
                res += "19" + data["rok"];
            }
            else
            {
                labelBlad.Text = "Błąd! Szprawdź 3 i 4 cyfry!";
                labelUdane.Visible = false;
                labelBlad.Visible = true;
                return "";
            }


            labelBlad.Text = "Błąd! Szprawdź 3 i 4 cyfry!";
            labelUdane.Visible = true;
            labelBlad.Visible = false;
            return res;
        }


        public string zwrocPlec(string pesel1)
        {
            if(textBoxData.Text == "")
            {
                return "";
            }
            int plec = Int32.Parse(pesel1.Substring(9, 1));
            if (plec % 2 == 0)
            {
                return "Kobieta";
            }
            else
            {
                return "Mężczyzna";
            }

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //sprawdz
            textBoxData.Text = "";
            textBoxPlec.Text = "";
            if (Regex.Match(textBoxPesel.Text, @"\d{11}").Success)
            {
                //labelBlad.Visible = false;
                //labelUdane.Visible = true;
                string pesel = textBoxPesel.Text;

                textBoxData.Text = zwrocDateUrodzenia(pesel);
                textBoxPlec.Text = zwrocPlec(pesel);
            }
            else
            {
                labelBlad.Text = "Błąd! Sprawdź czy PESEL zawiera 11 cyfr";
                labelBlad.Visible = true;
                labelUdane.Visible = false;
            }
            
        }

        string phd1 = "1.1.2001";
        string phd2 = "M lub K";
        private void textBoxDataGen_Enter(object sender, EventArgs e)
        {
            //textBoxDataGen.ForeColor = Color.Gray;
            if (textBoxDataGen.Text == phd1)
                textBoxDataGen.Text = "";
        }

        private void textBoxDataGen_Leave(object sender, EventArgs e)
        {
            if (textBoxDataGen.Text == "")
                textBoxDataGen.Text = phd1;
        }

        private void textBoxPlecGen_Enter(object sender, EventArgs e)
        {
            if (textBoxPlecGen.Text == phd2)
                textBoxPlecGen.Text = "";
        }

        private void textBoxPlecGen_Leave(object sender, EventArgs e)
        {
            if (textBoxPlecGen.Text == "")
                textBoxPlecGen.Text = phd2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDataGen.Text = phd1;
            textBoxPlecGen.Text = phd2;
        }

        public void GenerujPesel(string data, string plec)
        {
            //sprawdznie danych

            if(Regex.Match(textBoxDataGen.Text, @"[1-9].[1-9].\d{4}|[1-3]\d.[1-9].\d{4}|[1-9].1[1-2].\d{4}|[1-9].1[1-2].\d{4}").Success)
            {
                if (Regex.Match(textBoxPlecGen.Text, @"M|K").Success)
                {
                    labelBladDataGen.Visible = false;
                    labelBladDataGen.Visible = false;
                    
                /*
                dla lat 1800 - 1899 - 80
                dla lat 1900 - 1999 - 0
                dla lat 2000 - 2099 - 20
                dla lat 2100 - 2199 - 40
                dla lat 2200 - 2299 - 60
                */

                //data
                String[] dt = data.Split('.');
                string dataout = "";
                dataout += dt[2].Substring(2, 2);
                if(Int32.Parse(dt[2]) >= 1800 && Int32.Parse(dt[2]) <= 1899)
                {
                    dataout += (Int32.Parse(dt[1]) + 80).ToString();
                }
                else if(Int32.Parse(dt[2]) >= 1900 && Int32.Parse(dt[2]) <= 1999)
                {
                    if (dt[1].Length == 1)
                    {
                        dataout += "0" + dt[1];
                    }
                    else dataout +=  dt[1];
                }
                else if(Int32.Parse(dt[2]) >= 2000 && Int32.Parse(dt[2]) <= 2099)
                {
                    dataout += (Int32.Parse(dt[1]) + 20).ToString();
                }
                else if (Int32.Parse(dt[2]) >= 2100 && Int32.Parse(dt[2]) <= 2199)
                {
                    dataout += (Int32.Parse(dt[1]) + 40).ToString();
                }
                else if (Int32.Parse(dt[2]) >= 2100 && Int32.Parse(dt[2]) <= 2199)
                {
                    dataout += (Int32.Parse(dt[1]) + 40).ToString();
                }
                else if (Int32.Parse(dt[2]) >= 2200 && Int32.Parse(dt[2]) <= 2299)
                {
                    dataout += (Int32.Parse(dt[1]) + 60).ToString();
                }
                    else
                    {
                        labelUdaneGen.Visible = false;
                        labelBladDataGen.Visible = true;
                        textBoxPeselGen.Text = "";
                    }
            
                if(dt[0].Length == 1)
                {
                    dataout += "0" + dt[0];
                }
                else
                {
                    dataout += dt[0];
                }


                //plec
                string plecout = "";
                if(plec == "K")
                {
                    plecout += randomizer.RandomNumberEven(1000, 9999);
                }
                else
                {
                    plecout += randomizer.RandomNumberOdd(1000, 9999);
                }
                int[] toTotal = new int[10];
                string outStr = dataout + plecout;
                for(int i=0; i < 10; i++)
                {
                    toTotal[i] = Int32.Parse(outStr.Substring(i,1));
                }
                //1 3 7 9 1 3 7 9 1 3
                int total = (10 -(toTotal[0] + toTotal[1] * 3 + toTotal[2] * 7 + toTotal[3] * 9 + toTotal[4] + toTotal[5] * 3 + toTotal[6] * 7 + toTotal[7] * 9 + toTotal[8] + toTotal[9] * 3)%10)%10;
                outStr += total;


                textBoxPeselGen.Text = outStr;
                labelBladDataGen.Visible = false;
                labelBladPlecGen.Visible = false;
                labelUdaneGen.Visible = true;
                }
                else
                {
                    labelUdaneGen.Visible = false;
                    labelBladPlecGen.Visible = true;
                    textBoxPeselGen.Text = "";
                }
            }
            else
            {
                labelUdaneGen.Visible = false;
                labelBladDataGen.Visible = true;
                textBoxPeselGen.Text = "";
            }

            
        }

        private void buttonSubmitGen_Click(object sender, EventArgs e)
        {
            //generuj
            string data = textBoxDataGen.Text;
            string plec = textBoxPlecGen.Text;
            GenerujPesel(data, plec);

        }
    }
}
