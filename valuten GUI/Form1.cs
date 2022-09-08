namespace valuten_GUI
{
    public partial class FormConvert : Form
    {
        public FormConvert()
        {
            InitializeComponent();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            CurrencyConvert();
        }

        private void numericUpDownAmmount_ValueChanged(object sender, EventArgs e)
        {
            CurrencyConvert();
        }
        private void CurrencyConvert() {

            var amountBGN = this.numericUpDownAmmount.Value; 
            var amountEUR = amountBGN * 1.95583m; 
            this.labelResult.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + " EUR";
        }

    }
}