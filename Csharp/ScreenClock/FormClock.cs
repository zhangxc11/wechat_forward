using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace ScreenClock
{
    public partial class FormClock : Form
    {
        /// <summary>
        /// 表示正在移动窗口
        /// </summary>
        private bool moving = true;

        /// <summary>
        /// 用于移动窗口时的坐标换算
        /// </summary>
        private Point mouseOffset;
        static public Random ra = new Random();
        static private Color[] clist = 
        { 
            Color.FromArgb(0x66, 0x66, 0x66), 
            Color.FromArgb(0xC1, 0x00, 0x66), 
            Color.FromArgb(0xCC, 0x00, 0x00), 
            Color.FromArgb(0xE6, 0x3F, 0x00), 
            Color.FromArgb(0xEE7700), 
            Color.FromArgb(0xDDAA00), 
            Color.FromArgb(0xEEEE00), 
            Color.FromArgb(0x99DD00), 
            Color.FromArgb(0x66DD00), 
            Color.FromArgb(0x00DD00), 
            Color.FromArgb(0x00DD77), 
            Color.FromArgb(0x00DDAA), 
            Color.FromArgb(0x00DDDD), 
            Color.FromArgb(0x0000CC), 
            Color.FromArgb(0x4400CC), 
            Color.FromArgb(0x5500DD), 
            Color.FromArgb(0x7700BB), 
            Color.FromArgb(0x5500DD), 
            Color.FromArgb(0xA500CC), 
            Color.FromArgb(0xCC00CC), 
        };

        /// <summary>
        /// 设置透明度的对话框
        /// </summary>
        //private Transparency transparency = new Transparency();

        public FormClock(int hight, string text)
        {
            InitializeComponent();
            //this.Top = Screen.GetWorkingArea(this).Top - this.Height;
            //this.Left = Screen.GetWorkingArea(this).Left;
            hight = ra.Next() % Screen.GetWorkingArea(this).Bottom + 300;
            hight = hight % Screen.GetWorkingArea(this).Bottom;
            this.Top = Screen.GetWorkingArea(this).Top - this.Height + hight;
            this.Left = Screen.GetWorkingArea(this).Right;
            //timerUpdate_Tick(null, null);
            labelTime.Width = text.Length * 50;
            this.Size = labelTime.Size;
            this.Width = text.Length * 50;
            labelTime.Text = text;
            labelTime.ForeColor = clist[ra.Next() % 20];
        }

        

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //labelTime.Text = String.Format("{0}年{1}月{2}日\n{3}\n{4}:{5}:{6}",
            //    dt.Year, dt.Month.ToString().PadLeft(2, ' '),
            //    dt.Day.ToString().PadLeft(2, ' '),
            //    dt.DayOfWeek,
            //    dt.Hour.ToString().PadLeft(2, ' '),
            //    dt.Minute.ToString().PadLeft(2, '0'),
            //    dt.Second.ToString().PadLeft(2, '0'));
            this.Left -= 3;
            if (moving)
            {
                this.Left -= 3;
            }
            if (this.Right < Screen.GetWorkingArea(this).Left)
            {
                //this.Close();
            }

        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            //this.Top+=3;
            //if (this.Opacity < 0.7)
            //{
            //    this.Opacity += 0.01;
            //}
            //if (this.Top > 0)
            //{
            //    timerFadeIn.Stop();
            //}
        }

        /// <summary>
        /// 不响应Alt+Tab
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt-Tab
                return cp;
            }
        }

        private void labelTime_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    moving = true;
            //    mouseOffset = new Point(-e.X, -e.Y);
            //}
            //if (e.Button == MouseButtons.Middle)
            //{
            //    Application.Exit();
            //}
        }

        private void labelTime_MouseMove(object sender, MouseEventArgs e)
        {
            //if (moving)
            //{
            //    Point mouseSet = Control.MousePosition;
            //    mouseSet.Offset(mouseOffset);
            //    Location = mouseSet;
            //}
        }

        private void labelTime_MouseUp(object sender, MouseEventArgs e)
        {
            //moving = false;
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //transparency.ShowDialog(this);
        }

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            //FontDialog fd = new FontDialog();
            //fd.Font = labelTime.Font;
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    labelTime.Font = fd.Font;
            //}
            //this.Size = labelTime.Size;
        }

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            //ColorDialog cd = new ColorDialog();
            //cd.Color = labelTime.ForeColor;
            //if (cd.ShowDialog() == DialogResult.OK)
            //{
            //    if (cd.Color == this.TransparencyKey)
            //    {
            //        this.BackColor = labelTime.ForeColor;
            //        this.TransparencyKey = labelTime.ForeColor;
            //    }
            //    labelTime.ForeColor = cd.Color;
            //}
        }
    }
}
