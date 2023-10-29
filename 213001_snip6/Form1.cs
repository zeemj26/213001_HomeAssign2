namespace _213001_snip6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Name : ");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

    }
}