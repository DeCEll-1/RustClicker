using RustClicker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RustClicker
{
    public partial class ClickerMain : Form
    {
        public ClickerMain()
        {
            InitializeComponent();

            Statics.db = ss.XMLDeserialiserWS();

            if (Statics.db == null)
            {
                BaseClass dbs = new BaseClass();
                Statics.db = dbs;
            }

            if (Statics.db.BigNumberFuniClickMultiplier == 0)
            {
                Statics.db.BigNumberFuniClickMultiplier++;
            }

            lbl_EverySecondCount.Text = Statics.db.EverySecond.ToString();


            Reset();



            InitTimer();

        }

        public void Reset()
        {
            if (Statics.db.EverySecond != 0)
            {

                int s = 10;

                for (int i = 0; i <= Statics.db.EverySecond; i++)
                {
                    s = Convert.ToInt32(s * 1.5);
                }

                btn_EverySecond.Text = "Buy rustman12 for:\n" + s;

            }
            else
            {
                btn_EverySecond.Text = "Buy rustman12 for:\n" + 10;
            }
        }

        SerilisationStuff ss = new SerilisationStuff();

        public int IntervalThing { get; set; }

        private System.Windows.Forms.Timer timer;

        public void InitTimer()
        {
            timer = new System.Windows.Forms.Timer();

            timer.Tick += new EventHandler(timer_Tick);

            timer.Interval = 50;

            timer.Start();
        }

        private void timer_Tick(Object myObject, EventArgs myEventArgs)
        {
            IntervalThing += 50;
            if (IntervalThing == 1000)
            {
                Statics.db.BigNumberFuni += (ulong)Statics.db.EverySecond * 1;
                IntervalThing = 0;
                pb_Rustman12.Value = pb_Rustman12.Minimum;
            }

            pb_Rustman12.PerformStep();


            btn_Money.Text = Statics.db.BigNumberFuni.ToString();
        }




        private void btn_Money_Click(object sender, EventArgs e)
        {
            Statics.db.BigNumberFuni += (ulong)Statics.db.BigNumberFuniClickMultiplier * 1;
            btn_Money.Text = Statics.db.BigNumberFuni.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ss.Save(Statics.db);
            }
            catch (Exception)
            {
                ss.Save(Statics.db);
            }
        }

        private void ClickerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ss.Save(Statics.db);
            }
            catch (Exception)
            {
                ss.Save(Statics.db);
            }
        }

        private void btn_EverySecond_Click(object sender, EventArgs e)
        {
            if (Statics.db.EverySecond == 0)
            {
                if (Statics.db.BigNumberFuni >= 10)
                {
                    Statics.db.EverySecond++;
                    Statics.db.BigNumberFuni -= 10;
                    btn_Money.Text = Statics.db.BigNumberFuni.ToString();

                    lbl_EverySecondCount.Text = Statics.db.EverySecond.ToString();

                    btn_Save_Click(null, null);

                    Reset();

                }
            }
            else
            {
                int s = 10;

                for (int i = 0; i <= Statics.db.EverySecond; i++)
                {
                    s = Convert.ToInt32(s * 1.5);
                }

                if (Statics.db.BigNumberFuni >= (ulong)s)
                {
                    Statics.db.EverySecond++;
                    Statics.db.BigNumberFuni -= (ulong)s;
                    btn_Money.Text = Statics.db.BigNumberFuni.ToString();

                    lbl_EverySecondCount.Text = Statics.db.EverySecond.ToString();

                    btn_Save_Click(null, null);

                    Reset();

                }
            }
        }
    }
}
