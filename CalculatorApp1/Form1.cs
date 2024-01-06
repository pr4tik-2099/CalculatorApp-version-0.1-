namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ans_lbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)          //This method is for addition//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;

            if (Num1 == "" || Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else
            {
                double num1 = double.Parse(Num1);
                double num2 = double.Parse(Num2);
                double ans = num1 + num2;
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)           //This method is for Subtraction//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;

            if (Num1 == "" || Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else
            {
                double num1 = double.Parse(Num1);
                double num2 = double.Parse(Num2);
                double ans = num1 - num2;
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)           //This method is for Division//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;

            if (Num1 == "" || Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else
            {
                double num1 = double.Parse(Num1);
                double num2 = double.Parse(Num2);
                double ans = num1 / num2;
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)         //This method is for multiplication//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;

            if (Num1 == "" || Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else
            {
                double num1 = double.Parse(Num1);
                double num2 = double.Parse(Num2);
                double ans = num1 * num2;
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)          //This method is for Square//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;
            if (Num1 == "" && Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else if (Num2 == "")
            {
                double num1 = double.Parse(Num1);
                // double num2 = double.Parse(Num2); //
                double ans = num1 * num1;
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)           //This method is for square root//
        {
            string Num1 = Num1_txt.Text;
            string Num2 = Num2_txt.Text;
            if (Num1 == "" && Num2 == "")
            {
                Ans_lbl.Text = "Empty";
                Ans_lbl.Show();
            }
            else if (Num2 == "")
            {
                double num1 = double.Parse(Num1);
                // double num2 = double.Parse(Num2); //
                double ans = Math.Sqrt(num1);
                string Ans = ans.ToString();
                Ans_lbl.Text = Ans;
                Ans_lbl.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)          //This is for Erase all
        {
            Num1_txt.Text = "";
            Num2_txt.Text = "";
            Ans_lbl.Hide();


        }

        private void Num2_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                Num1_txt.Text = "";
                Num2_txt.Text = "";
                Ans_lbl.Hide();
            }
        }
    }
}