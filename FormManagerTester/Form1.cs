using FormManagerdll;
using FormManagerTester.Pages;
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

namespace FormManagerTester
{
    public partial class Form1 : Form
    {
        private FormManager fm1,fm2,fm3,fm4;

        private void Group1(object sender, EventArgs e)
        {
            var obj = sender as Button;
            switch (obj.Name) {
                case "G1_P1":
                    fm1.AddPage("P1", new P1());
                    fm1.SetPage("P1");
                    break;
                case "G1_P2":
                    fm1.AddPage("P2", new P2());
                    fm1.SetPage("P2");
                    break;
                case "G1_P3":
                    fm1.AddPage("P3", new P3());
                    fm1.SetPage("P3");
                    break;
                case "G1_P4":
                    fm1.AddPage("P4", new P4());
                    fm1.SetPage("P4");
                    break;
            }            
        }
        private void Group2(object sender, EventArgs e)
        {
            var obj = sender as Button;
            switch (obj.Name)
            {
                case "G2_P1":
                    fm2.AddPage("P1", new P1());
                    fm2.SetPage("P1");
                    break;
                case "G2_P2":
                    fm2.AddPage("P2", new P2());
                    fm2.SetPage("P2");
                    break;
                case "G2_P3":
                    fm2.AddPage("P3", new P3());
                    fm2.SetPage("P3");
                    break;
                case "G2_P4":
                    fm2.AddPage("P4", new P4());
                    fm2.SetPage("P4");
                    break;
            }
        }

        private void Group3(object sender, EventArgs e)
        {
            var obj = sender as Button;
            switch (obj.Name)
            {
                case "G3_P1":
                    fm3.AddPage("P1", new P1());
                    fm3.SetPage("P1");
                    break;
                case "G3_P2":
                    fm3.AddPage("P2", new P2());
                    fm3.SetPage("P2");
                    break;
                case "G3_P3":
                    fm3.AddPage("P3", new P3());
                    fm3.SetPage("P3");
                    break;
                case "G3_P4":
                    fm3.AddPage("P4", new P4());
                    fm3.SetPage("P4");
                    break;
            }
        }

        private void Group4(object sender, EventArgs e)
        {
            var obj = sender as Button;
            switch (obj.Name)
            {
                case "G4_P1":
                    fm4.AddPage("P1", new P1());
                    fm4.SetPage("P1");
                    break;
                case "G4_P2":
                    fm4.AddPage("P2", new P2());
                    fm4.SetPage("P2");
                    break;
                case "G4_P3":
                    fm4.AddPage("P3", new P3());
                    fm4.SetPage("P3");
                    break;
                case "G4_P4":
                    fm4.AddPage("P4", new P4());
                    fm4.SetPage("P4");
                    break;
            }
        }



        public Form1()
        {
            InitializeComponent();
            Init();
            //CustomTimer();
        }

        private void Init() { 

            fm1 = new FormManager(flowLayoutPanel1,"Context1");
            fm2 = new FormManager(flowLayoutPanel1, "Context2");
            fm3 = new FormManager(flowLayoutPanel1, "Context3");
            fm4 = new FormManager(flowLayoutPanel1, "Context4");
        }

        /*

        private void CustomTimer() {
            Thread th = new Thread(() => {
                while(true) {
                    Thread.Sleep(100);
                    this.BeginInvoke(new EventHandler(delegate { 
                        label1.Text = fm.GetNowPageName();
                        label2.Text = fm2.GetNowPageName();
                    }));
                }                
            });
            th.IsBackground = true;
            th.Start();
        }
        */

    }
}
