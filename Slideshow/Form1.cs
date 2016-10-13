using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class Form_SlideShow : Form
    {
        string FilePath;
        FileInfo[] files;

        public Form_SlideShow()
        {
            InitializeComponent();
            listView_Image.View = View.Details;// Вид отображения
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Play.Enabled = false; //
            button_Left.Enabled = false; // ДеАктивация кнопок
            button_Right.Enabled = false;//

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            listView_Image.Items.Clear();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FilePath = fbd.SelectedPath;
                files = di.GetFiles();
                int i = 0;
                string[] Format;

                foreach (FileInfo file in files)
                {
                    Format = file.Name.Split('.');
                    if (Format[1] == "jpeg" || Format[1] == "jpg" || Format[1] == "JPG" || Format[1] == "JPEG" || Format[1] == "Jpg") // Здесь можно добавить форматы фото
                    {
                        listView_Image.Items.Add(file.Name); // Заполняем ListView

                        double Size = file.Length / 1024;
                        listView_Image.Items[i].SubItems.Add(Size.ToString() + " KB");
                        listView_Image.Items[i].ImageIndex = 0;
                        i++;

                        listView_Image.Focus();
                        listView_Image.Items[0].Selected = true;
                        string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
                        PictureBox1_Show.Load(fullPath);
                        button_Play.Enabled = true; //
                        button_Left.Enabled = true; // Активация кнопок
                        button_Right.Enabled = true;//
                    }
                }
            } 
        }

        private void listView_Image_MouseClick(object sender, MouseEventArgs e)
        {

            string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
            PictureBox1_Show.Load(fullPath);
        }

        private void button_Right_Click(object sender, EventArgs e) // Переключение стрелками
        {
            listView_Image.Focus();
            int i = listView_Image.SelectedItems[0].Index + 1;
            listView_Image.Items[i-1].Selected = false;
            int j = listView_Image.Items.Count - 1;
            if ( i <= j)
            {
                listView_Image.Items[i].Selected = true;
                string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
                PictureBox1_Show.Load(fullPath);
            }
            else
            {
                listView_Image.Items[0].Selected = true;
                string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
                PictureBox1_Show.Load(fullPath);
            }
        }

        private void button_Left_Click(object sender, EventArgs e) // Переключение стрелками
        {
            listView_Image.Focus();
            int i = listView_Image.SelectedItems[0].Index - 1;
            listView_Image.Items[i + 1].Selected = false;
            int j = listView_Image.Items.Count - 1;
            if (i >= 0)
            {
                listView_Image.Items[i].Selected = true;
                string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
                PictureBox1_Show.Load(fullPath);
            }
            else
            {
                listView_Image.Items[j].Selected = true;
                string fullPath = FilePath + "\\" + listView_Image.SelectedItems[0].Text.ToString();
                PictureBox1_Show.Load(fullPath);
            }
        }

        private void button_Play_Click(object sender, EventArgs e) // Включение слайд шоу на весь экран
        {
            if (listView_Image.Items.Count > 0)
            {
                FullShow fs = new FullShow();
                fs.Files = files;
                fs.FilePath = FilePath;
                fs.TimeInterval = trackBar_Speed.Value;
                fs.Show(); 
            }
            else
            {
                MessageBox.Show("Нету єлементов для отображения сначала добавьте жлементы");
            }
        }
    }
}
