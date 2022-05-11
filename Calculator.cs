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
        string string_calc = "";
        string output = ""; 
        string history = "";
        string memory_number = "0";
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

            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "1";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_2(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "2";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }

        private void add_number_3(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "3";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_4(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "4";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_5(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "5";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_6(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "6";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_7(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "7";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_8(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "8";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }

        private void add_number_9(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "9";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void add_number_0(object sender, EventArgs e)
        {
            if (string_calc == "0") string_calc = "";
            if (output == "0") output = "";
            number = "0";
            string_calc += number;
            output += number;
            last_calculate.Text = output;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '+') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '*')
            {
                string_calc = string_calc[..^1];
                string_calc += "+";
                calculate.Text = string_calc;
                return;
            }
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    result(sender, e);

                }
            }
            number = "+";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            output = "0";
            last_calculate.Text = output;
            calculate.Text = string_calc;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '-') return;
            if (string_calc[string_calc.Length - 1] == '+' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '*')
            {
                string_calc = string_calc[..^1];
                string_calc += "-";
                calculate.Text = string_calc;
                return;
            }
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    result(sender, e);

                }
            }
            number = "-";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            output = "0";
            last_calculate.Text = output;
            calculate.Text = string_calc;
        }
        private void X_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '*') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '/' || string_calc[string_calc.Length - 1] == '+')
            {
                string_calc = string_calc[..^1];
                string_calc += "*";
                calculate.Text = string_calc;
                return;
            }
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    result(sender, e);

                }
            }
            number = "*";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            output = "0";
            last_calculate.Text = output;
            calculate.Text = string_calc;
        }
        private void divison_Click(object sender, EventArgs e)
        {
            if (string_calc[string_calc.Length - 1] == '/') return;
            if (string_calc[string_calc.Length - 1] == '-' || string_calc[string_calc.Length - 1] == '*' || string_calc[string_calc.Length - 1] == '+')
            {
                string_calc = string_calc[..^1];
                string_calc += "/";
                calculate.Text = string_calc;
                return;
            }

            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    result(sender, e);

                }
            }
            number = "/";
            first = Convert.ToDouble(string_calc);
            string_calc += number;
            output = "0";
            last_calculate.Text = output;
            calculate.Text = string_calc;
        }
        private void delete_last_number(object sender, EventArgs e)
        {
            if (output.Length > 1)
            {
                string_calc = string_calc.Remove(string_calc.Length - 1);
                output = output.Remove(output.Length - 1);
                last_calculate.Text = output;
            }
            else
            {
                string_calc = "0";
                output = "0";
                last_calculate.Text = output;
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            string_calc = "0";
            output = "0";
            calculate.Text = "";
            last_calculate.Text= output;

        }
        private void CE_Click(object sender, EventArgs e)
        {
            output = "0";
            last_calculate.Text = output;
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '+' || string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    calculate.Text = string_calc;
                    return;
                }
            }
            string_calc = "0";
        }
        private void add_comma(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == ',') counter++;
                if (counter >= 1) return;
            }
            number = ",";
            output += number;
            string_calc += number;
            last_calculate.Text = output;
        }
        private void squere_Click(object sender, EventArgs e)
        {
            history += $"Square({output}) = ";
            var type = Convert.ToDouble(output);
            type = Square(type);
            output = Convert.ToString(type);
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += output;
                    history += output + '\n';
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            history += output + '\n';
            last_calculate.Text = output;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            history += $"Sqrt({output}) = ";
            var type = Convert.ToDouble(output);
            type = Sqrt(type);
            output = Convert.ToString(type);
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += output;
                    history += output + '\n';
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            history += output + '\n';
            last_calculate.Text = output;

        }

        private void one_on_number_Click(object sender, EventArgs e)
        {
            history += $"1/{output} = ";
            var type = Convert.ToDouble(output);
            type = 1/(type);
            output = Convert.ToString(type);
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += output;
                    history += output + '\n';
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            history += output + '\n';
            last_calculate.Text = output;
        }
        private void proc_Click(object sender, EventArgs e)
        {
            history += $"({output})%= ";
            var type = Convert.ToDouble(output);
            type = (type) / 100;
            output = Convert.ToString(type);
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += output;
                    history += output + '\n';
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            history += output + '\n';
            last_calculate.Text = output;
        }
        private void change_sign(object sender, EventArgs e)
        {
            history += $"{output}*-1 = ";
            var type = Convert.ToDouble(output);
            type = type * -1;
            output = Convert.ToString(type);
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += output;
                    history += output + '\n';
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            history += output + '\n';
            last_calculate.Text = output;
        }
        private void MC_Click(object sender, EventArgs e)
        {
            memory_number = "0";
        }
        private void MR_Click(object sender, EventArgs e)
        {
            output = memory_number;
            for (int i = 1; i < string_calc.Length; i++)
            {
                if (string_calc[i] == '-' || string_calc[i] == '*' || string_calc[i] == '+' || string_calc[i] == '/')
                {
                    string_calc = string_calc.Remove(i + 1, string_calc.Length - i - 1);
                    string_calc += memory_number;
                    last_calculate.Text = output;
                    return;
                }
            }
            string_calc = output;
            last_calculate.Text = output;
        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(output);
            var type_memory = Convert.ToDouble(memory_number);
            type = type_memory + type;
            memory_number = Convert.ToString(type);
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(output);
            var type_memory = Convert.ToDouble(memory_number);
            type = type_memory - type;
            memory_number = Convert.ToString(type);
        }

        private void MS_Click(object sender, EventArgs e)
        {
            memory_number = output;
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
                    output = string_calc;
                    last_calculate.Text = output;
                    calculate.Text = "";
                    history += string_calc;
                    break;
                }
                if (string_calc[i] == '-')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first - second;
                    string_calc = Convert.ToString(first);
                    output = string_calc;
                    last_calculate.Text = output;
                    calculate.Text = "";
                    history += string_calc;
                    break;
                }
                if (string_calc[i] == '*')
                {
                    string_calc = string_calc.Remove(0, i + 1);
                    second = Convert.ToDouble(string_calc);
                    first = first * second;
                    string_calc = Convert.ToString(first);
                    output = string_calc;
                    last_calculate.Text = output;
                    calculate.Text = "";
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
                    output = string_calc;
                    last_calculate.Text = output;
                    calculate.Text = "";
                    history += string_calc;
                    break;
                }
            }
            history += '\n';
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            calculate.Text = string_calc.ToString();
        }

        public void History_Click(object sender, EventArgs e)
        {
            History History = new History();
            History.window.Text += history;  
            History.Show();
        }


    }
}