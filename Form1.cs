namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 / num2;
            textBox3.Text = result.ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int result = num1 * num1;
            textBox3.Text = result.ToString();
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int result = num1 * num1 * num1;
            textBox3.Text = result.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int length = int.Parse(textBox5.Text);
            int breadth = int.Parse(textBox4.Text);
            int result = 2*(length+breadth);
            textBox6.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = int.Parse(textBox5.Text);
            int breadth = int.Parse(textBox4.Text);
            int result = length*breadth;
            textBox6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBox5.Text);
            double breadth = double.Parse(textBox4.Text);
            double result = Math.Sqrt(length * length + breadth * breadth);
            textBox6.Text = result.ToString();
        }
    }
}