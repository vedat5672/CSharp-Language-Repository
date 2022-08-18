namespace UcanTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5;
        int yerY = 5;
        int can = 3;
      
        private void CarpaOlayý()
        {
            if (ball.Top<=label2.Bottom)
            {
                yerY = yerY *- 1;
            }
            if (ball.Bottom >= ControlButton.Top && ball.Left >= ControlButton.Left && ball.Right <= ControlButton.Right)
            {
                yerY = yerY* -1;
            }
           
            if (ball.Right>=label3.Left)
            {
                yerX = yerX * -1;
            }
            if (ball.Left <=label1.Right)
            {
                yerX = yerX * -1;
            }
        }
        private void YanmaOlayý(object sender,EventArgs e)
        {
            if (ball.Top>=label3.Bottom)
            {
                if (can>0)
                {
                    timer1.Stop ();
                    can--;
                    MessageBox.Show("kalan can", can.ToString());
                    Form1_Load(sender,e);
                    ball.Location = new Point(200,200);
                }
                if (can==0)
                {
                    timer1.Stop();
                    MessageBox.Show("oyun bitti ","",MessageBoxButtons.OK);
                    
                }
            }
            label5.Text=can.ToString(); 

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                ControlButton.Left = e.X;
            }
           
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X+yerX,ball.Location.Y+yerY);
            CarpaOlayý();
            YanmaOlayý(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            can = 3;
            ball.Location = new Point(200, 200);
           

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        
           
        }

 
    }
}