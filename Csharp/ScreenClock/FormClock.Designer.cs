namespace ScreenClock
{
    partial class FormClock
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStripFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenuStripFormat;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(274, 58);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "hello world";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseDown);
            this.labelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseMove);
            this.labelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseUp);
            // 
            // contextMenuStripFormat
            // 
            this.contextMenuStripFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFont,
            this.ToolStripMenuItemColor});
            this.contextMenuStripFormat.Name = "contextMenuStripFormat";
            this.contextMenuStripFormat.Size = new System.Drawing.Size(141, 52);
            // 
            // ToolStripMenuItemFont
            // 
            this.ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
            this.ToolStripMenuItemFont.Size = new System.Drawing.Size(140, 24);
            this.ToolStripMenuItemFont.Text = "字体(&F)...";
            this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
            // 
            // ToolStripMenuItemColor
            // 
            this.ToolStripMenuItemColor.Name = "ToolStripMenuItemColor";
            this.ToolStripMenuItemColor.Size = new System.Drawing.Size(140, 24);
            this.ToolStripMenuItemColor.Text = "颜色(&C)...";
            this.ToolStripMenuItemColor.Click += new System.EventHandler(this.ToolStripMenuItemColor_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Interval = 10;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClock";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.contextMenuStripFormat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFormat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColor;
    }
}

