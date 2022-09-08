namespace valuten_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void numericUpDownAmount_SelectedItemChanged(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var amountBGN = this.numericUpDown1.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.label1.Text = amountBGN + "BGN = " + Math.Round(amountEUR, 2) + "EUR";
        }
        private void label3_Click(object sender, EventArgs e)
        {
          numericUpDown1_ValueChanged(sender, e);
        }
    }
}