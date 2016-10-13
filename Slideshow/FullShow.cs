using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class FullShow : Form
    {
        string filePath;
        FileInfo[] files;
        int timeInterval;
        string[] Format;
        string fullPath;
        int elementFiles = 0;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public FileInfo[] Files
        {
            get { return files; }
            set { files = value; }
        }

        public int TimeInterval
        {
            get { return timeInterval; }
            set { timeInterval = value; }
        }

        public FullShow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; //
            pictureBox_FullShow.Size = this.Size;         // На весь экран
        }

        private void FullShow_Load(object sender, EventArgs e)
        {
            timer1.Interval = TimeInterval * 1000; // Установка таймера
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Выход с окна
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) // Перебор фото
        {
            if (elementFiles < files.Count())
            {
                Format = files[elementFiles].Name.Split('.');
                if (Format[1] == "jpeg" || Format[1] == "jpg")
                {
                    pictureBox_FullShow.Refresh();
                    fullPath = FilePath + "\\" + files[elementFiles].Name;
                    pictureBox_FullShow.Load(fullPath);
                }
                elementFiles++;
            }
            else
            {
                //elementFiles = 0;
                this.Close();// Чтобы закрыть окно по окончанию
            }
        }  
    }
}
