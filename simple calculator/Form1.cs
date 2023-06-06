namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double sum = num1 + num2;
                label2.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double subtract = num1 - num2;
                label2.Text = subtract.ToString();
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double multiply = num1 * num2;
                label2.Text = multiply.ToString();
            }
            else
            {
                MessageBox.Show("NOT VALID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Can't Divided to Zero");
                }
                else
                {
                    double divide = num1 / num2;
                    label2.Text = divide.ToString();
                }
            }
            else
            {
                MessageBox.Show("NOT VALID");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if (num1 == 0 && num2 == 0)
                {
                    MessageBox.Show("NOT VALID ");
                }
                else
                {
                    double reminder = num2 % num1;
                    label2.Text = reminder.ToString();
                }

            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = Math.Pow(num1, num2);
                label2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}