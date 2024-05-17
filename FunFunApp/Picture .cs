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
    public partial class Picture : Form
    {

        int count = 0;
        string[] imagList = { "picture (1).jpg", "picture (2).jpg", "picture (3).jpg", "picture (4).jpg", "picture (5).jpg", "picture (6).jpg", "picture (7).jpg", "picture (8).jpg", "picture (9).jpg", "picture (10).jpg" };
        //int i = 10;

        public Picture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\" + imagList[count]);
            count++;
            if (imagList.Length == count)
            {
                count = 0;
            }

            //count++;
            //pictureBox1.Image = System.Drawing.Image.FromFile("F:\\รูป\\picture (" + count + ").jpg");
            //if (i == count)
            //{
            //    count = 0;
            //}
        }
    }
}
