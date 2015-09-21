namespace ScreenClock
{
    partial class Transparency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarTransparent = new System.Windows.Forms.TrackBar();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparent)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTransparent
            // 
            this.trackBarTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarTransparent.LargeChange = 10;
            this.trackBarTransparent.Location = new System.Drawing.Point(0, 0);
            this.trackBarTransparent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarTransparent.Maximum = 100;
            this.trackBarTransparent.Minimum = 10;
            this.trackBarTransparent.Name = "trackBarTransparent";
            this.trackBarTransparent.Size = new System.Drawing.Size(267, 56);
            this.trackBarTransparent.TabIndex = 0;
            this.trackBarTransparent.Value = 10;
            this.trackBarTransparent.ValueChanged += new System.EventHandler(this.trackBarTransparent_ValueChanged);
            this.trackBarTransparent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarTransparent_MouseUp);
            // 
            // timerHide
            // 
            this.timerHide.Interval = 500;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // Transparency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 69);
            this.Controls.Add(this.trackBarTransparent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transparency";
            this.ShowInTaskbar = false;
            this.Text = "属性";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarTransparent;
        private System.Windows.Forms.Timer timerHide;
    }
}