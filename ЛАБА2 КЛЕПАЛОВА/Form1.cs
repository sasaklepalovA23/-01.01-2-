namespace ЛАБА2_КЛЕПАЛОВА
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

    }
}
