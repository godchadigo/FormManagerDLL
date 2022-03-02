using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormManagerTester.Pages
{
    public partial class Home : UserControl
    {
        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (this != null)
            {
                this.Dispose();
            }

            base.OnHandleDestroyed(e);
        }

        private int i = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(() =>
            {
                while (this.IsHandleCreated)
                {
                    i++;
                    
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        label1.Text = i.ToString();
                        label2.Text = i.ToString();
                        label3.Text = i.ToString();
                        label4.Text = i.ToString();
                        label5.Text = i.ToString();
                        label6.Text = i.ToString();
                        label7.Text = i.ToString();
                        label8.Text = i.ToString();
                        label9.Text = i.ToString();
                        label10.Text = i.ToString();
                        label11.Text = i.ToString();
                        
                    }));

                    Console.WriteLine(i.ToString());
                    //   await Task.Delay(1);
                    Thread.Sleep(1);
                }
            });
            th.IsBackground = true; 
            th.Start();
        }
    }
}
