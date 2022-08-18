using System.Data.OleDb;
using System.Media;
namespace AlarmSaatUygulamaası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();


        }
        SoundPlayer soundPlayer1=new SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;
            if (numericUpDown1.Value==DateTime.Now.Hour && numericUpDown2.Value==DateTime.Now.Minute)
            {
                timer1.Stop();
                string ses = Application.StartupPath + "/alarm.mp4"; /// surda hata uzantı hatası
                soundPlayer1.SoundLocation = ses;
                soundPlayer1.PlayLooping();
                MessageBox.Show("alarm","alarm caldı",MessageBoxButtons.OK);

            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled=true;
            soundPlayer1.Stop();
            

        }
        public void Database()
        {
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =baglanti.accdb; Persist Security Info = False;");
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("insert into saatler (saat,dakika) values("+numericUpDown1.Value+","+numericUpDown2.Value+")",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
                
        }

    }
}