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
    public partial class DemoProgress : Form
    {
        int i = 0;
        public DemoProgress()
        {
            InitializeComponent();
            progressBar1.Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Step = -10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
            }
        }
    }
}
