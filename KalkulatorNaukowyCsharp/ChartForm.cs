using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorNaukowyCsharp
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Draw_Click(object sender, EventArgs e)
        {
            int pom1 = 0;
            int pom2 = 0;
            int pom3 = 0;
            int pom4 = 0;
            double precision = 0.1;
            double indexS = -1;
            double indexE = 1;
            if (Precision.Text != "" && !Precision.Text.StartsWith(","))
            {
                precision = double.Parse(Precision.Text);
            }
            if (IndexE.Text != "")
            {
                indexE = double.Parse(IndexE.Text);
            }
            if (IndexS.Text != "")
            {
                indexS = double.Parse(IndexS.Text);
            }
            string znak1, znak2, znak3, znak4;
            UzupełnijDane();
            WyodrebnijZnak(ref pom1, ref pom2, ref pom3, ref pom4, out znak1, out znak2, out znak3, out znak4);
            double x = 0;
            double y = 0;
            this.Wykres.Series["Func"].Points.Clear();
            this.Wykres.Visible = true;
            for (double i = indexS; i <= indexE; i = i + precision)
            {
                x = i;
                y = ((double.Parse(x4.Text) * Math.Pow(x, 4))
                    + (double.Parse(x3.Text) * (pom4 * Math.Pow(x, 3)))
                    + (double.Parse(x2.Text) * (pom3 * Math.Pow(x, 2)))
                    + ((double.Parse(X.Text)) * (pom2 * Math.Pow(x, 1)))
                    + (double.Parse(c.Text)));
                this.Wykres.Series["Func"].Points.AddXY(x, y);
            }
            string a4 = x4.Text;
            string a3 = x3.Text;
            string a2 = x2.Text;
            string a1 = X.Text;
            string a = c.Text;
            WzorFunckji(znak1, znak2, znak3, znak4, a4, a3, a2, a1, a);
            Txt.ForeColor = System.Drawing.Color.White;
        }
        private void WzorFunckji(string znak1, string znak2, string znak3, string znak4, string a4, string a3, string a2, string a1, string a)
        {
            Txt.Text = "Narysowano wykres funkcji: ";
            if (a4 == "0")
            {
                Txt.Text += "";
            }
            else if (a4 == "1")
            {
                Txt.Text +=   "x ^ 4 " + znak4;
            }
            else
            {
                Txt.Text += a4 + "x ^ 4 " + znak4;
            }
            if (a3 == "0")
            {
                Txt.Text += "";
            }
            else if (a3 == "1")
            {
                Txt.Text += "x ^ 3 " + znak3;
            }
            else
            {
                Txt.Text += a3 + "x ^ 3 " + znak3;
            }
            if (a2 == "0")
            {
                Txt.Text += "";
            }
            else if (a2 == "1")
            {
                Txt.Text += "x ^ 2 " + znak2;
            }
            else
            {
                Txt.Text += a2 + "x ^ 2 " + znak2;
            }
            if (a1 == "0")
            {
                Txt.Text += "";
            }
            else if (a1 == "1")
            {
                Txt.Text += " x " + znak1;
            }
            else
            {
                Txt.Text += a1 + "x " + znak1;
            }
            if (a == "0")
            {
                Txt.Text += "";
            }          
            else
            {
                Txt.Text += a;
            }
        }
        private void UzupełnijDane()
        {
            if (x4.Text == string.Empty)
            {
                x4.Text = "0";
            }
            if (x3.Text == string.Empty)
            {
                x3.Text = "0";
            }
            if (x2.Text == string.Empty)
            {
                x2.Text = "0";
            }
            if (X.Text == string.Empty)
            {
                X.Text = "0";
            }
            if (c.Text == string.Empty)
            {
                c.Text = "0";
            }
        }
        private void WyodrebnijZnak(ref int pom1, ref int pom2, ref int pom3, ref int pom4, out string znak1, out string znak2, out string znak3, out string znak4)
        {
            znak1 = z1.Text;
            znak2 = z2.Text;
            znak3 = z3.Text;
            znak4 = z4.Text;
            if (znak1 == "-")
            {
                pom1 = -1;
            }
            else
            {
                pom1 = 1;
            }
            if (znak2 == "-")
            {
                pom2 = -1;
            }
            else
            {
                pom2 = 1;
            }
            if (znak4 == "-")
            {
                pom4 = -1;
            }
            else
            {
                pom4 = 1;
            }
            if (znak3 == "-")
            {
                pom3 = -1;
            }
            else
            {
                pom3 = 1;
            }
        }
        private void Precision_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',')
            {
                e.Handled = false;                                     
            }
            else
            {
                e.Handled = true;                                    
            }
        } //blokuje przyciski
        private void x4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void x3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void Txt_MouseMove(object sender, MouseEventArgs e)
        {
            Txt.ForeColor = System.Drawing.Color.Black;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            IndexS.Text = ((-1* hScrollBar1.Value)/10).ToString();
            IndexE.Text = (  hScrollBar1.Value/10).ToString();
        }
        private void drawOther_Click(object sender, EventArgs e)
        {
            if (otherX.Text == string.Empty)
            {
                otherX.Text = "1";
            }
            double precision = 0.1;
            double indexS = -1;
            double indexE = 1;
            if (Precision.Text != "" && !Precision.Text.StartsWith(","))
            {
                precision = double.Parse(Precision.Text);
            }
            if (IndexE.Text != "")
            {
                indexE = double.Parse(IndexE.Text);
            }
            if (IndexS.Text != "")
            {
                indexS = double.Parse(IndexS.Text);
            }
            if (other.Text != string.Empty)
            {
                this.Wykres.Visible = true;
                if (other.Text == "Sin (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;                  
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {
                        x = i;
                        y = Math.Sin(x*double.Parse(otherX.Text));
                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Cos (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Cos(x * double.Parse(otherX.Text));

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Tan (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Tan(x * double.Parse(otherX.Text));                                       
                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Sinh (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Sinh(x * double.Parse(otherX.Text));

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Cosh (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Cosh
(x * double.Parse(otherX.Text));

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Tanh (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Tanh(x * double.Parse(otherX.Text));

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Log (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Log10(x * double.Parse(otherX.Text));

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "Ln (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Log(x);

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "a ^ (x)")
                {
                    label9.Text = "a:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Pow(double.Parse(otherX.Text),x);

                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "e ^ (x)")
                {
                    label9.Text = "e:";
                    otherX.Text = Math.E.ToString();
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Pow(Math.E, x);


                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }
                if (other.Text == "sqrt (x)")
                {
                    label9.Text = "x:";
                    double x = 0;
                    double y = 0;
                    this.Wykres.Series["Func"].Points.Clear();
                    this.Wykres.Visible = true;
                    // this.Wykres.Series["Func"].Points.AddY(double.Parse(FunkcjaTxt.Text));
                    for (double i = indexS; i <= indexE; i = i + precision)
                    {

                        x = i;
                        y = Math.Sqrt(x);


                        this.Wykres.Series["Func"].Points.AddXY(x, y);
                    }
                }              
            }
        }
        private void otherX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void IndexS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void IndexE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
