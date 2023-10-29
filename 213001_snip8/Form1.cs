namespace _213001_snip8
{
    public partial class Form1 : Form
    {
        private object numericUpDownQuatity;

        public Form1() => InitializeComponent();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal price = numericUpDown1.Value;
            int quatity = (int)numericUpDownQuatity.Value;
            decimal total;
            total = price * quatity;
            MessageBox.Show(String.Format("The total price is {0:C}", total));

        }
    } 
}