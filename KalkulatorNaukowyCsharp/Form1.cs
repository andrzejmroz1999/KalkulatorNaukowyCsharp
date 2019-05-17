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
    public partial class Form1 : Form
    {
        int pomView = 1;
        string Operator;
        double firstNumber;
        public Form1()
        {
            InitializeComponent();
        }
        protected void ButtonX(object sender,EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
            }

            Button click = (Button)sender;
            if (click.Text == " ,")
            {
               Display.Text = Display.Text.Replace(",","");
                Display.Text += click.Text.Replace(" ","");
            }
         else   if (click.Text == "AC")
            {
                Display.Clear();
                Display.Text += "0";
            }
          else  if (click.Text == "C")
            {
                int index = Display.Text.Length;
                

                if (index != 0)
                {
                    index--;
                    Display.Text = Display.Text.Remove(index);
                    if (Display.Text == "0")
                    {
                        Display.Text = "0";
                    }
                }
                if (index == 1 || index == 0)
                {
                    Display.Text = "0";
                }

            }
            else if (click.Text == "+")
            {
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
            }
            else if (click.Text == "-")
            {
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
            }
            else if (click.Text == "*")
            {
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
            }
            else if (click.Text == " /")
            {
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
            }
            else if (click.Text == " %")
            {
                Display.Text = (double.Parse(Display.Text) / 100).ToString();
            }
            else if (click.Text == "exp")
            {
                Operations.Text = "EXP" ;
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
                Operations.Location = new Point(Display.Right - Operations.Width + 10);
            }
            else if (click.Text == "mod")
            {
                Operations.Text = "MOD";
                if (Display.Text != string.Empty)
                {
                    firstNumber = double.Parse(Display.Text);
                }
                Operator = click.Text.Replace(" ", "");
                Display.Clear();
                Operations.Location = new Point(Display.Right - Operations.Width + 10);
            }
            else if (click.Text == " =")
            {
                switch (Operator)
                {
                    case "+":
                        Display.Text = (firstNumber + (double.Parse(Display.Text))).ToString();
                        break;
                    case "*":
                        Display.Text = (firstNumber * (double.Parse(Display.Text))).ToString();
                        break;
                    case "-":
                        Display.Text = (firstNumber - (double.Parse(Display.Text))).ToString();
                        break;
                    case "/":
                        Display.Text = (firstNumber / (double.Parse(Display.Text))).ToString();
                        break;
                    case "%":
                        Display.Text = (((double.Parse(Display.Text)) / firstNumber) * 100).ToString();
                        break;
                    case "exp":
                        double pow = double.Parse(Display.Text);
                        double ans = Math.Exp(pow * Math.Log(firstNumber * 4));
                        Display.Text = ans.ToString();                      
                        break;
                    case "mod":
                        Display.Text = (firstNumber % double.Parse(Display.Text)).ToString();                       
                        break;
                }               
            }
            else
            {
                Display.Text += click.Text.Replace(" ","");
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
                Display.Text = e.KeyCode.ToString();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void View_Click(object sender, EventArgs e)
        {
            pomView++;
            if (pomView % 2 == 0 )
            {
                this.Width = 1500;
                Exit.Location = new Point(1444, 3);
            }
            else
            {
                this.Width = 375;
                Exit.Location = new Point(319, 3);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 375;
            this.Height = 633;
            Operations.Text = string.Empty;
        }
        private void PI_Click(object sender, EventArgs e)
        {
            Operations.Text = string.Empty;
            double val = Math.PI;
            Display.Text = val.ToString();
            Operations.Text = "PI";
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void Log_Click(object sender, EventArgs e)
        {           
            double val = double.Parse(Display.Text);
            Operations.Text = "Log (" + val + ")";
            val = Math.Log10(val);
            Display.Text = val.ToString();           
            Operations.Location = new Point(Display.Right- Operations.Width+10);
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "Sqrt (" + val + ")";
            val = Math.Sqrt(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void xPow2_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = val + " ^ 2";
            val = Math.Pow(val, 2);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void pow_Click(object sender, EventArgs e)
        {
            potega.Visible = true;
            pomView++;
            if (pomView % 2 != 0)
            {
                potega.Visible = true;
            }
            else
            {
                potega.Visible = false;
            }

        }
        private void potega_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            double val = double.Parse(Display.Text);
            if (potega.Text != "" && int.TryParse(potega.Text, out i))
            {
                val = Math.Pow(val, int.Parse(potega.Text));
                Display.Text = val.ToString();
            }
            Operations.Text = val + " ^ " + potega.Text;
            Operations.Location = new Point(Display.Right - Operations.Width + 10);

        }
        private void sinh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "SinH (" + val + ")";
            val = Math.Sinh(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void cosh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "CosH (" + val + ")";
            val = Math.Cosh(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void tanh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "TanH (" + val + ")";
            val = Math.Tanh(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void sin_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "Sin (" + val + ")";
            val = Math.Sin(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void cos_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "Cos (" + val + ")";
            val = Math.Cos(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void tan_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "Tan (" + val + ")";
            val = Math.Tan(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }  
        private void dec_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Display.Text);
                Operations.Text = "DEC (" + Display.Text + ")";
                Display.Text = System.Convert.ToString(a, 10);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void hex_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Display.Text);
                Operations.Text = "HEX (" + Display.Text + ")";
                Display.Text = System.Convert.ToString(a, 16);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void odw_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "1 / " + val; 
            val = 1/val;
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void bin_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Display.Text);
                Operations.Text = "BIN (" + Display.Text + ")";
                Display.Text = System.Convert.ToString(a, 2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void ln_Click(object sender, EventArgs e)
        {
            double val = double.Parse(Display.Text);
            Operations.Text = "Ln (" + val + ")";
            val = Math.Log(val);
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void e_Click(object sender, EventArgs e)
        {
            Operations.Text = string.Empty;
            double val = Math.E;
            Operations.Text = "e";
            Display.Text = val.ToString();
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void oct_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Display.Text);
                Operations.Text = "OCT (" + Display.Text + ")";
                Display.Text = System.Convert.ToString(a, 8);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Błąd " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Operations.Location = new Point(Display.Right - Operations.Width + 10);
        }
        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            Wynik.Clear();
            float number = 0f;
            if (numberTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Proszę podadaj numer do obliczenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                number = Convert.ToSingle(numberTxt.Text);
            }
            catch 
            {
                MessageBox.Show("Niewłaściwy numer", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                Wynik.Text += number + " * " + i + " = " + number * i + "\n";
            }
        }
        private void Resetuj_Click(object sender, EventArgs e)
        {
            Wynik.Clear();
            numberTxt.Clear();
            numberTxt.Focus();
        }
        private void Konwertuj_Click(object sender, EventArgs e)
        {
            Tdisp.Clear();
            float number = 0f;
            if (TempToConvert.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Proszę podadaj temperature którą chcesz konwertować", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                number = Convert.ToSingle(TempToConvert.Text);
            }
            catch 
            {
                MessageBox.Show("Niewłaściwy numer", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CtoF.Checked)
            {
                Tdisp.Text = ((number * 9 / 5) + 32).ToString();
            }
            if (FtoC.Checked)
            {
                Tdisp.Text = ((number - 32) * 5 / 9).ToString();
            }
            if (KtoC.Checked)
            {
                Tdisp.Text = (number - 273.15).ToString();
            }
            if (KtoF.Checked)
            {
                Tdisp.Text = ((number - 273.15)* 9 / 5 +32).ToString();
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            TempToConvert.Clear();
            Tdisp.Clear();
            TempToConvert.Focus();
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Display.Text == string.Empty)
            {
                Display.Text = "0";
            }
        }
        private void Display_TextChanged(object sender, EventArgs e)
        {
            Common.history.Add(Display.Text);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Historia f = new Historia();
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChartForm f = new ChartForm();
                f.Show();
        }
        private void numberTxt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TempToConvert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ','|| e.KeyChar == '-')
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
