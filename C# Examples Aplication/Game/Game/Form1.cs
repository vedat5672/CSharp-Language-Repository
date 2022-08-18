namespace Game
{
    public partial class Form1 : Form
    {
        Siparis siparis=new Siparis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          

        }

       

        private void MasaNoTextBox_TextChanged(object sender, EventArgs e)
        {
            siparis._no = Convert.ToInt32(MasaNoTextBox.Text);
            MasaNoTextBox.Focus();
            
            
        }

        private void MusteriAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            siparis._musteriAdi=MusteriAdiTextBox.Text;
        }

        private void MusteriSoyadýTextbox_TextChanged(object sender, EventArgs e)
        {
            siparis._musteriSoyadi = MusteriAdiTextBox.Text;
        }

        private void IstekUrunTextBox_TextChanged(object sender, EventArgs e)
        {
            siparis._ýstenenUrun=IstekUrunTextBox.Text;
        }

        private void MýktarTextbox_TextChanged(object sender, EventArgs e)
        {
            siparis._miktar=Convert.ToInt32(MýktarTextbox.Text);
        }

        private void SureTextbox_TextChanged(object sender, EventArgs e)
        {
            siparis.saniye = Convert.ToInt32(SureTextbox.Text);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void SureTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               Form form=new Form();
                

            }
        }
    }
}