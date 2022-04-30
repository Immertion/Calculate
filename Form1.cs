namespace WinFormsApp2
{


    public partial class Form1 : Form
    {
        public static double Sqrt(double d)
        {
            return Math.Sqrt(d);
        }
        public static double Square (double d)
        {
            return d * d;
        }
        public Form1()
        {
            InitializeComponent();
        }

        string number;
        string str = "0";
        double first;
        double second;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "1";
            str += number;
            window.Text = str;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "2";
            str += number;
            window.Text = str;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "3";
            str += number;
            window.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "4";
            str += number;
            window.Text = str;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "5";
            str += number;
            window.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "6";
            str += number;
            window.Text = str;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "7";
            str += number;
            window.Text = str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "8";
            str += number;
            window.Text = str;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (str[0] == '0' && str.Length == 1)
            {
                str = "";
            }
            number = "9";
            str += number;
            window.Text = str;
        }

        private void button10_Click(object sender, EventArgs e)
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
            number = "+";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            number = "-";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void X_Click(object sender, EventArgs e)
        {
            number = "x";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            number = "/";
            first = Convert.ToDouble(str);
            str += number;
            window.Text = str;
        }


        private void button11_Click_2(object sender, EventArgs e)
        {
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - 1);
                window.Text = str;
            }
            if (str.Length == 0)
            {
                str = "0";
                window.Text = str;
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            str = "0";
            window.Text = str.ToString();
        }
        private void fiend_Click(object sender, EventArgs e)
        {
            number = ",";
            str += number;
            window.Text = str;
        }

        private void squere_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(str);
            type = Square(type);
            str = Convert.ToString(type);
            window.Text = str;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(str);
            type = Sqrt(type);
            str = Convert.ToString(type);
            window.Text = str;
        }

        private void one_on_number_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(str);
            type = 1 / type;
            str = Convert.ToString(type);
            window.Text = str;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            var type = Convert.ToDouble(str);
            type *= -1;
            str = Convert.ToString(type);
            window.Text = str;
        }
        private void result(object sender, EventArgs e)
        {
            for (int i = 1; i <= str.Length; i++)
            {
                if (str[i] == '+')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first + second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    break;
                }
                if (str[i] == '-')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first - second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    break;
                }
                if (str[i] == 'x')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first * second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    break;
                }
                if (str[i] == '/')
                {
                    str = str.Remove(0, i + 1);
                    second = Convert.ToDouble(str);
                    first = first / second;
                    str = Convert.ToString(first);
                    window.Text = str;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window.Text = str.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}