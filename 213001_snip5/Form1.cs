namespace _213001_snip5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object MessageBoxButton { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicking Button", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}