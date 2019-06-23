using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PanoramaViewer
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //Присваимание переменной img значение начальной картинки Samole.png
            img = new Bitmap(@"Panoramas\Sample.png");

            //Присваимание переменной PanoramaOpenFileDialog.Filter значения допустимых форматов для открытия понорамм учитывая локализацию
            PanoramaOpenFileDialog.Filter = Program.LocaleOther[0] + " (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|" + Program.LocaleOther[1] + " (*.PNR)|*.PNR";

            //Вычесление DPI'я обьекта DPIGraphics
            PictureBox HelpingPB = new PictureBox();
            Graphics DPIGraphics = HelpingPB.CreateGraphics();

            //Присваивание перименным ImgDpiX-Y и PbDpiX-Y значение DPI открытого изображения и Picture Box
            ImgDpiX = Convert.ToInt32(img.HorizontalResolution);
            ImgDpiY = Convert.ToInt32(img.VerticalResolution);
            PbDpiX = Convert.ToInt32(DPIGraphics.DpiX);
            PbDpiY = Convert.ToInt32(DPIGraphics.DpiY);

            //Присваивание переменным currentX и currentY значений, размеров левой/верхней невидимой части изображения по оси X или Y
            currentX = -(img.Width * PbDpiX / ImgDpiX - PanoramaPictureBox.Width) / 2;
            currentY = -(img.Height * PbDpiY / ImgDpiY - PanoramaPictureBox.Height) / 2;

            //Обновление параметра Text у всех обьектов на форме MainForm учитывая локализацию
            PanoramaNameLabel.Text = Program.LocaleLabelsMF[0];
            FileToolStripMenuItem.Text = Program.LocaleBtns[0];
            OpenPanoramaToolStripMenuItem.Text = Program.LocaleBtns[1];
            ClearToolStripMenuItem.Text = Program.LocaleBtns[2];
            SettingsToolStripMenuItem.Text = Program.LocaleBtns[3];
            AboutToolStripMenuItem.Text = Program.LocaleBtns[4];

            //Обновление параметра Text у форма MainForm учитывая локализацию
            Text = Program.LocaleWindowsNames[0];

            ShowPanoramaName(Program.ShowPanoramaName);
        }

        //Создание переменных, важных для подсчёта точки перемещения изображения img
        private Bitmap img;
        int lastX = 0, lastY = 0;
        int currentX = 0, currentY = 0;

        //Создание переменных, отвечающих за хранение DPI изображения img
        int ImgDpiX;
        int ImgDpiY;

        //Создание переменных, отвечающих за хранение DPI Picture Box PanoramaPictureBox
        int PbDpiX;
        int PbDpiY;

        //Создание переменной, отвечающюю за хранение стандартных (эталонных) размеров панораммы
        Size StandardPanoramaSize = new Size(3600, 1800);

        private void PanoramaPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastX = e.X;
                lastY = e.Y;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.LocaleMessageBoxes[3], Program.LocaleMessageBoxes[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenPanoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PanoramaOpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Bitmap NewImage = new Bitmap(PanoramaOpenFileDialog.FileName);

            if(NewImage.Width < StandardPanoramaSize.Width || NewImage.Height < StandardPanoramaSize.Height)
            {
                if(Program.ResizeImage)
                {
                    img = new Bitmap(NewImage, StandardPanoramaSize.Width, StandardPanoramaSize.Height);
                }
                else
                {
                    MessageBox.Show(Program.LocaleMessageBoxes[1], Program.LocaleMessageBoxes[0], MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            else
            {
                img = NewImage;
            }


            ImgDpiX = Convert.ToInt32(img.HorizontalResolution);
            ImgDpiY = Convert.ToInt32(img.VerticalResolution);

            currentX = -(img.Width * PbDpiX / ImgDpiX - PanoramaPictureBox.Width) / 2;
            currentY = -(img.Height * PbDpiY / ImgDpiY - PanoramaPictureBox.Height) / 2;

            PanoramaNameLabel.Text = PanoramaOpenFileDialog.SafeFileName;
            
            PanoramaPictureBox.Invalidate();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img.Dispose();
            img = new Bitmap(@"Panoramas\Sample.png");

            ImgDpiX = Convert.ToInt32(img.HorizontalResolution);
            ImgDpiY = Convert.ToInt32(img.VerticalResolution);

            currentX = -(img.Width * PbDpiX / ImgDpiX - PanoramaPictureBox.Width) / 2;
            currentY = -(img.Height * PbDpiY / ImgDpiY - PanoramaPictureBox.Height) / 2;

            PanoramaNameLabel.Text = Program.LocaleLabelsMF[0];

            PanoramaPictureBox.Invalidate();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SettingsF = new SettingsForm();
            Program.SettingsF.Visible = true;
        }

        private void PanoramaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, currentX, currentY);

            if (img.Width * PbDpiX / ImgDpiX - Math.Abs(currentX) < PanoramaPictureBox.Width)
            {
                e.Graphics.DrawImage(img, currentX + img.Width * PbDpiX / ImgDpiX, currentY);
            }
            if (currentX > 0)
            {
                e.Graphics.DrawImage(img, currentX + -img.Width * PbDpiX / ImgDpiX, currentY);
            }
        }

        private void PanoramaPictureBox_MouseMove(object sender, MouseEventArgs e) 
        {
            if(e.Button == MouseButtons.Left)
            {
                if (PanoramaPictureBox.Capture)
                {
                    int dx = e.X - lastX;
                    int dy = e.Y - lastY;
                    currentX += dx;
                    currentY += dy; 
                    lastX = e.X;
                    lastY = e.Y;

                    if (currentY > 0)
                    {
                        currentY = 0;  
                    }
                    else if (currentY < -(img.Height * PbDpiY / ImgDpiY - PanoramaPictureBox.Height))
                    {
                        currentY = -(img.Height * PbDpiY / ImgDpiY - PanoramaPictureBox.Height);
                    }
                    if (2 * img.Width * PbDpiX / ImgDpiX - Math.Abs(currentX) < PanoramaPictureBox.Width) //Формула контроля расстояния до крайней правой точки второго изображения от правой границы области просмотра.
                    {
                        currentX += img.Width * PbDpiX / ImgDpiX;
                    }
                    if (img.Width * PbDpiX / ImgDpiX - currentX - PanoramaPictureBox.Width < -PanoramaPictureBox.Width)
                    {
                        currentX -= img.Width * PbDpiX / ImgDpiX;
                    }

                    PanoramaPictureBox.Invalidate();
                }
            }
        }

        public void ShowPanoramaName(bool show)
        {
            PanoramaNameLabel.Visible = show;
        }
    }
}
