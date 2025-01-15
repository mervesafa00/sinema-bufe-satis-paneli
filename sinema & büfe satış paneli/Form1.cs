namespace sinema___büfe_satış_paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtCay.Text = "";
            TxtSu.Text = "";
            TxtBilet.Text = "";
            TxtMisir.Focus();
        }
         int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, su, bilet,toplam;
            misir = Convert.ToInt32(TxtMisir.Text);
            cay = Convert.ToInt32(TxtCay.Text);
            su = Convert.ToInt32(TxtSu.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);

            toplam = misir * 50 + cay * 25 + su * 15 + bilet * 200;
            label11.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            label12.Text = kasatutar.ToString() + " TL";


        }
    }
}
