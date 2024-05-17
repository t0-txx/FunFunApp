namespace FunFunApp
{
    public partial class TimeTest : Form
    {
        int count = 1;
        public TimeTest()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            count++;
            if (count == 11)
            {
                timer1.Stop();
            }
        }
    }
}