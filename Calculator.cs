namespace WinFormsApp2
{


    public partial class Calculator : Form
    {
        public static double Sqrt(double d)
        {
            return Math.Sqrt(d);
        }
        public static double Square (double d)
        {
            return d * d;
        }
        public Calculator()
        {
            InitializeComponent();
        }
               
        string number;
        string string_calc = "0";
        string history = "";
        double first;
        double second;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D0) number_0.PerformClick();
            if (keyData == Keys.D1) number_1.PerformClick();
            if (keyData == Keys.D2) number_2.PerformClick();
            if (keyData == Keys.D3) number_3.PerformClick();
            if (keyData == Keys.D4) number_4.PerformClick();
            if (keyData == Keys.D5) number_5.PerformClick();
            if (keyData == Keys.D6) number_6.PerformClick();
            if (keyData == Keys.D7) number_7.PerformClick();
            if (keyData == Keys.D8) number_8.PerformClick();
            if (keyData == Keys.D9) number_9.PerformClick();
            if (keyData == Keys.Oemplus) plus.PerformClick();
            if (keyData == Keys.OemMinus) minus.PerformClick();
            if (keyData == Keys.Back) DELETE.PerformClick();
            if (keyData == Keys.OemPipe) division.PerformClick();
            if (keyData == Keys.Multiply) X.PerformClick();
            if (keyData == Keys.OemPeriod) comma.PerformClick();
            if (keyData == Keys.Enter) equally.PerformClick();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void add_number_1(object sender, EventArgs e)
        {
            
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "1";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_2(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "2";
            string_calc += number;
            window.Text = string_calc;
        }

        private void add_number_3(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "3";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_4(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "4";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_5(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "5";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_6(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "6";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_7(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "7";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_8(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "8";
            string_calc += number;
            window.Text = string_calc;
        }

        private void add_number_9(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "9";
            string_calc += number;
            window.Text = string_calc;
        }
        private void add_number_0(object sender, EventArgs e)
        {
            if (string_calc[0] == '0' && string_calc.Length == 1)
            {
                string_calc = "";
            }
            number = "0";
            string_calc += number;
            window.Text = string_calc;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '+') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '*')
            {
                string_calc = string_calc[..^1];
                string_calc += "+";
                window.Text = string_calc;
                return;
            }
            if (string_calc[string_calc.Length - 1] != '-' || string_calc[string_calc.Length - 1] != '/' || string_calc[string_calc.Length - 1] != '*')
            {
                result(sender, e);
            }
            number = "+";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            window.Text = string_calc;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '-') return;
            if (string_calc[string_calc.Length - 1] == '+' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '*')
            {
                string_calc = string_calc[..^1];
                string_calc += "-";
                window.Text = string_calc;
                return;
            }
            if (string_calc[string_calc.Length - 1] != '+' || string_calc[string_calc.Length - 1] != '/' || string_calc[string_calc.Length - 1] != '*')
            {
                result(sender, e);
            }
            number = "-";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            window.Text = string_calc;
        }
        private void X_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '*') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '+')
            {
                string_calc = string_calc[..^1];
                string_calc += "*";
                window.Text = string_calc;
                return;
            }
            if (string_calc[string_calc.Length - 1] != '-' || string_calc[string_calc.Length - 1] != '/' || string_calc[string_calc.Length - 1] != '+')
            {
                result(sender, e);
            }
            number = "*";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            window.Text = string_calc;
        }
        private void divison_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '/') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '*' || string_calc[string_calc.Length - 1] == '+')
            {
                string_calc = string_calc[..^1];
                string_calc += "/";
                window.Text = string_calc;
                return;
            }
            if (string_calc[string_calc.Length - 1] != '-' || string_calc[string_calc.Length - 1] != '+' || string_calc[string_calc.Length - 1] != '*')
            {
                result(sender, e);
            }
            number = "/";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            window.Text = string_calc;
        }
        private void delete_last_number(object sender, EventArgs e)
        {
            if (string_calc.Length > 1)
            {
                string_calc = string_calc.Remove(string_calc.Length - 1);
                window.Text = string_calc;
            }
            else if (string_calc.Length == 1 || string_calc.Length == 0)
            {
                string_calc = "0";
                window.Text = string_calc;
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            string_calc = "0";
            window.Text = string_calc;
        }
        private void CE_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '+' || string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    window.Text = string_calc.ToString();
                    return;
                }
            }
            string_calc = "0";
            window.Text = string_calc.ToString();
        }
        private void add_comma(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '*' || string_calc[string_calc.Length - 1] == '+')
            {
                string_calc += "0";
            }
            number = ",";
            string_calc += number;
            window.Text = string_calc;
        }
        private void squere_Click(object sender, EventArgs e)
        {
            history += $"Square({string_calc}) = ";
            var type = Convert.ToDouble(string_calc);
            type = Square(type);
            string_calc = Convert.ToString(type);
            history += string_calc + '\n';
            window.Text = string_calc;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            history += $"Sqrt({string_calc}) = ";
            var type = Convert.ToDouble(string_calc);
            type = Sqrt(type);
            type = (Math.Round(type, 10));
            string_calc = Convert.ToString(type);
            history += string_calc + '\n';
            window.Text = string_calc;
        }

        private void one_on_number_Click(object sender, EventArgs e)
        {
            history += $"1/{string_calc} = ";
            var type = Convert.ToDouble(string_calc);
            type = 1 / type;
            type = (Math.Round(type, 10));
            string_calc = Convert.ToString(type);
            history += string_calc + '\n';
            window.Text = string_calc;
        }
        private void proc_Click(object sender, EventArgs e)
        {
            history += $"({string_calc})%= ";
            var type = Convert.ToDouble(string_calc);
            type = type / 100;
            string_calc = Convert.ToString(type);
            history += string_calc + '\n';
            window.Text = string_calc;
        }
        private void change_sign(object sender, EventArgs e)
        {
            history += $"{string_calc}*-1 = ";
            var type = Convert.ToDouble(string_calc);
            type *= -1;
            string_calc = Convert.ToString(type);
            history += string_calc + '\n';
            window.Text = string_calc;
        }

        private void result(object sender, EventArgs e)
        {
            history += string_calc;
            history += " = ";
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '+')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first + second;
                    string_calc = Convert.ToString(first);
                    window.Text = string_calc;
                    history += string_calc;
                    break;
                }
                if (string_calc[i] == '-')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first - second;
                    string_calc = Convert.ToString(first);
                    window.Text = string_calc;
                    history += string_calc;
                    break;
                }
                if (string_calc[i] == '*')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first * second;
                    string_calc = Convert.ToString(first);
                    window.Text = string_calc;
                    history += string_calc;
                    break;
                }
                if (string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first / second;
                    first = (Math.Round(first, 10));
                    string_calc = Convert.ToString(first);
                    window.Text = string_calc;
                    history += string_calc;
                    break;
                }
            }
            history += '\n';
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            window.Text = string_calc.ToString();
        }

        public void History_Click(object sender, EventArgs e)
        {
            History History = new History();
            History.window.Text += history;  
            History.Show();
        }


    }
}