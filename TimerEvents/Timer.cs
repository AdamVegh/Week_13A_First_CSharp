using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer t;

        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(progressBar1_Click);
            t.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            Console.WriteLine(progressBar1.Value);
            if (progressBar1.Value == 99)
            {
                t.Stop(); //Close();
            }
        }
    }
}
