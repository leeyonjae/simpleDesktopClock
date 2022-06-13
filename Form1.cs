using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleDesktopClock
{
    public partial class frmMain : Form
    {

        DateTime dateTime = DateTime.Now;
        bool timestyle = true;

        public frmMain()
        {
            InitializeComponent();
        }

        private void updateTime()
        {
            // Update 
            dateTime = DateTime.Now;

            int h = dateTime.Hour;  // need it as int for some processing
            string m = dateTime.Minute.ToString();
            string s = dateTime.Second.ToString();

            // TODO: Add Date Display
            int y = dateTime.Year;
            int mo = dateTime.Month;
            int day = dateTime.Day;

            if (m.Length == 1)
            {
                m = "0" + m;
            }
            if (s.Length == 1)
            {
                s = "0" + s;
            }

            string timestr;
            dateDisplay.Text = dateTime.Date.ToLongDateString();

            if (timestyle)
            {
                string ampm;
                if (h >= 12)
                {
                    ampm = "PM";
                    if (h > 12)  // 13, 14 ... --> 1, 2 ... PM
                        h -= 12;
                } else
                {
                    ampm = "AM"; // 0 = 12 AM
                    if (h == 0)
                        h = 12;
                }

                timestr = h.ToString() + ":" + m.ToString() + ":" + s.ToString() + " " + ampm;

            } else
            {
                timestr = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
            }

            timeDisplay.Text = timestr;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            updateTime();
            this.Height = 200;
        }

        private void time24_CheckedChanged(object sender, EventArgs e)
        {
            if (time24.Checked)
            {
                timestyle = false;
                updateTime();
            }
        }

        private void time12_CheckedChanged(object sender, EventArgs e)
        {
            if (time12.Checked)
            {
                timestyle = true;
                updateTime();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void linksite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/leeyonjae/simpleDesktopClock");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Height = 310;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 200;
        }

        private void alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTop.Checked;
        }

        private void setOpacity_Scroll(object sender, EventArgs e)
        {
            this.Opacity = 0.01 * setOpacity.Value;
            lblCurOpacity.Text = setOpacity.Value.ToString() + "%";
        }
    }
}
