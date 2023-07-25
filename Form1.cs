using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h, m, s;

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
        //Остановка таймера
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            textBoxH.Text = label4.Text;
            textBoxM.Text = label5.Text;
            textBoxS.Text = label6.Text;
        }
        //Сброс таймера
        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            textBoxH.Text = "0";
            textBoxM.Text= "0";
            textBoxS.Text="0";
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        

            private void timer_Tick(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);

            s = s - 1;
            if (s == -1)
            {
                m-=1;
                s = 59;
            }
            if (m == -1)
            {
                h-=1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer.Stop();
                MessageBox.Show("Костяныч, завязывай работать");
            }
           
            
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
           
            h = Convert.ToInt32(textBoxH.Text);
            m = Convert.ToInt32(textBoxM.Text);
            s = Convert.ToInt32(textBoxS.Text);
            timer.Start();
        }
    }
}
