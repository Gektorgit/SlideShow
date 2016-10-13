namespace Slideshow
{
    partial class FullShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullShow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.pictureBox_FullShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FullShow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(104)));
            this.buttonStop.Location = new System.Drawing.Point(13, 13);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(39, 32);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // pictureBox_FullShow
            // 
            this.pictureBox_FullShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_FullShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_FullShow.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_FullShow.Name = "pictureBox_FullShow";
            this.pictureBox_FullShow.Size = new System.Drawing.Size(492, 386);
            this.pictureBox_FullShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_FullShow.TabIndex = 0;
            this.pictureBox_FullShow.TabStop = false;
            // 
            // FullShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(517, 411);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.pictureBox_FullShow);
            this.Name = "FullShow";
            this.Text = "FullShow";
            this.Load += new System.EventHandler(this.FullShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FullShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_FullShow;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
    }
}