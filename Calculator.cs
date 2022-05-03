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
        string str = "0";
        string history = "";
        double first;
        double second;

        private void add_number_1(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "1";
            str += number;
            window.Text = str;
        }
        private void add_number_2(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "2";
            str += number;
            window.Text = str;
        }

        private void add_number_3(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "3";
            str += number;
            window.Text = str;
        }
        private void add_number_4(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "4";
            str += number;
            window.Text = str;
        }
        private void add_number_5(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "5";
            str += number;
            window.Text = str;
        }
        private void add_number_6(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "6";
            str += number;
            window.Text = str;
        }
        private void add_number_7(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "7";
            str += number;
            window.Text = str;
        }
        private void add_number_8(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "8";
            str += number;
            window.Text = str;
        }

        private void add_number_9(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "9";
            str += number;
            window.Text = str;
        }
        private void add_number_0(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "0";
            str += number;
            window.Text = str;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (str[str.Length - 1] == '+') return;
            number = "+";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '*' || str[i] == '/')
                {
                    number = "-";
                    str += number;
                    window.Text = str;
                    return;
                }
        }
            number = "-";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void X_Click(object sender, EventArgs e)
        {
            if (str[str.Length - 1] == '*') return;
            number = "*";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void divison_Click(object sender, EventArgs e)
        {
            if (str[str.Length - 1] == '/') return;
            number = "/";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void delete_last_number(object sender, EventArgs e)
        {
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - 1);
                window.Text = str;
            }
            else if (str.Length == 0)
            {
                str = "0";
                window.Text = str;
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            str = "0";
            window.Text = str;
        }
        private void CE_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    str = str.Remove(i + 1, str.Length - i - 1);
                    window.Text = str.ToString();
                    return;
                }
            }
            str = "0";
            window.Text = str.ToString();
        }
        private void add_comma(object sender, EventArgs e)
        {
            number = ",";
            str += number;
            window.Text = str;
        }
        private void squere_Click(object sender, EventArgs e)
        {
            history += $"Square({str}) = ";
            var type = Convert.ToDouble(str);
            type = Square(type);
            str = Convert.ToString(type);
            history += str + '\n';
            window.Text = str;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            history += $"Sqrt({str}) = ";
            var type = Convert.ToDouble(str);
            type = Sqrt(type);
            type = (Math.Round(type, 10));
            str = Convert.ToString(type);
            history += str + '\n';
            window.Text = str;
        }

        private void one_on_number_Click(object sender, EventArgs e)
        {
            history += $"1/{str} = ";
            var type = Convert.ToDouble(str);
            type = 1 / type;
            type = (Math.Round(type, 10));
            str = Convert.ToString(type);
            history += str + '\n';
            window.Text = str;
        }
        private void proc_Click(object sender, EventArgs e)
        {
            history += $"({str})%= ";
            var type = Convert.ToDouble(str);
            type = type / 100;
            str = Convert.ToString(type);
            history += str + '\n';
            window.Text = str;
        }
        private void change_sign(object sender, EventArgs e)
        {
            history += $"{str}*-1 = ";
            var type = Convert.ToDouble(str);
            type *= -1;
            str = Convert.ToString(type);
            history += str + '\n';
            window.Text = str;
        }

        private void result(object sender, EventArgs e)
        {
            history += str;
            history += " = ";
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '+')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first + second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    history += str;
                    break;
                }
                if (str[i] == '-')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first - second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    history += str;
                    break;
                }
                if (str[i] == '*')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first * second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    history += str;
                    break;
                }
                if (str[i] == '/')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first / second;
                    first = (Math.Round(first, 10));
                    str = Convert.ToString(first);
                    window.Text = str;
                    history += str;
                    break;
                }
            }
            history += '\n';
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window.Text = str.ToString();
        }

        public void History_Click(object sender, EventArgs e)
        {
            History History = new History();
            History.window.Text += history;  
            History.Show();
        }


    }
}