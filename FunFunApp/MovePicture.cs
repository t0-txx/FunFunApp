using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunFunApp
{
    public partial class MovePicture : Form
    {
        int x, y;

        public MovePicture()
        {
            InitializeComponent();
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
            timer1.Start();
        }
        int xx, yy;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            x = x + 5;
            if (x < 585)
            {
                pictureBox1.Location = new Point(x, y);
                xx = 585;
            }
            else if (y < 285)
            {
                x = 585;
                y = y + 5;
                yy = 285;
                pictureBox1.Location = new Point(x, y);
            }
            else if (xx > 0)
            {

                xx = xx - 6;
                yy = yy - 3;
                pictureBox1.Location = new Point(xx, yy);
            }
            
        }
    }
}
