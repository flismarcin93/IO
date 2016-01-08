using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdjecia
{
    public partial class Form1 : Form
    {
        string[] wczytanePliki;
        int numer = 0;
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
         
        }

        void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == 120)
                obrazek.ZoomIn();
            else if (e.Delta == -120)
                obrazek.ZoomOut(); 
            //throw new NotImplementedException();
        }

        private void obrazek_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void otworzToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.ShowDialog();
            //if (dialog.FileName != "")
            //   obrazek.LoadFromFile(dialog.FileName);
     //       OpenFileDialog open = new OpenFileDialog();
    //        open.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    //        open.Filter = "JPEG Compressed Image (*.jpg|*.jpg" + "|GIF Image(*.gif|*.gif" + "|Bitmap Image(*.bmp|*.bmp";
    //        open.Multiselect = true;
    //        open.FilterIndex = 1;

            // jezeli pomyslnie wybrano pliki to skopiuj nazwy do tablicy wczytanePliki
     //       if (open.ShowDialog() == DialogResult.OK)
       //     {
         //       wczytanePliki = new string[open.FileNames.Length];
           //     open.FileNames.CopyTo(wczytanePliki, 0);
                //obrazek.LoadFromFile(wczytanePliki[0]);
                obrazek.LoadFromFile("C:\\Users\\Marcin\\Desktop\\images.jpg");


            //}

        }

        private void zoominToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obrazek.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obrazek.ZoomOut();
        }
    }
}
