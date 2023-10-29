namespace _213001_snip7
{
    public partial class Form1 : Form
    {
        private object checkBox2;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string items = String.Empty;
            if (checkBox1.Checked)
                items + = "\n Pencil ";
            if (!checkBox2.Checked)
            {
                items + = "\n eraser ";
            MessageBox.Show("The things you buy " + items);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string Gender;
            if(radioButton1.Checked == true)
            {
                Gender = "male";
            }
            else
            {
                Gender = "Female";
            }
            MessageBox.Show(Gender.ToString());
        }
    }
}