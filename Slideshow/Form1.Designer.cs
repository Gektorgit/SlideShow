namespace Slideshow
{
    partial class Form_SlideShow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SlideShow));
            this.MenuStripSlideShow = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox1_Show = new System.Windows.Forms.PictureBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.listView_Image = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStripSlideShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripSlideShow
            // 
            this.MenuStripSlideShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuStripSlideShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStripSlideShow.Location = new System.Drawing.Point(0, 0);
            this.MenuStripSlideShow.Name = "MenuStripSlideShow";
            this.MenuStripSlideShow.Size = new System.Drawing.Size(815, 24);
            this.MenuStripSlideShow.TabIndex = 0;
            this.MenuStripSlideShow.Text = "MenuStripSlideShow";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // PictureBox1_Show
            // 
            this.PictureBox1_Show.Location = new System.Drawing.Point(209, 28);
            this.PictureBox1_Show.Name = "PictureBox1_Show";
            this.PictureBox1_Show.Size = new System.Drawing.Size(594, 444);
            this.PictureBox1_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1_Show.TabIndex = 2;
            this.PictureBox1_Show.TabStop = false;
            // 
            // button_Play
            // 
            this.button_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Play.BackgroundImage")));
            this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Play.Enabled = false;
            this.button_Play.Location = new System.Drawing.Point(13, 377);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(54, 50);
            this.button_Play.TabIndex = 3;
            this.button_Play.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Left
            // 
            this.button_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Left.BackgroundImage")));
            this.button_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Left.Enabled = false;
            this.button_Left.Location = new System.Drawing.Point(87, 377);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(54, 50);
            this.button_Left.TabIndex = 4;
            this.button_Left.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Right.BackgroundImage")));
            this.button_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Right.Enabled = false;
            this.button_Right.Location = new System.Drawing.Point(147, 377);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(55, 50);
            this.button_Right.TabIndex = 5;
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // listView_Image
            // 
            this.listView_Image.BackColor = System.Drawing.Color.Goldenrod;
            this.listView_Image.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileSize});
            this.listView_Image.LargeImageList = this.imageList1;
            this.listView_Image.Location = new System.Drawing.Point(12, 28);
            this.listView_Image.Name = "listView_Image";
            this.listView_Image.Size = new System.Drawing.Size(190, 343);
            this.listView_Image.SmallImageList = this.imageList1;
            this.listView_Image.TabIndex = 6;
            this.listView_Image.UseCompatibleStateImageBehavior = false;
            this.listView_Image.View = System.Windows.Forms.View.Details;
            this.listView_Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Image_MouseClick);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 130;
            // 
            // FileSize
            // 
            this.FileSize.Text = "File Size";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Jpg2.jpg");
            this.imageList1.Images.SetKeyName(1, "Jpg.jpg");
            this.imageList1.Images.SetKeyName(2, "2.jpg");
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.Location = new System.Drawing.Point(13, 427);
            this.trackBar_Speed.Minimum = 1;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(189, 45);
            this.trackBar_Speed.TabIndex = 5;
            this.trackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Speed.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(13, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed Slide Show";
            // 
            // Form_SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(815, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_Speed);
            this.Controls.Add(this.listView_Image);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.PictureBox1_Show);
            this.Controls.Add(this.MenuStripSlideShow);
            this.MainMenuStrip = this.MenuStripSlideShow;
            this.Name = "Form_SlideShow";
            this.Text = "Slide Show";
            this.MenuStripSlideShow.ResumeLayout(false);
            this.MenuStripSlideShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripSlideShow;
        private System.Windows.Forms.PictureBox PictureBox1_Show;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Image;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.Label label1;
    }
}

