using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdjecia
{
    /**\file
     * /
     /**\class MyPictureBox
     *\brief MyPictureBox sluzy do wyswietlania obrazkow
     */
    class MyPictureBox:Panel
    {
        //! \brief kontrolak odpowiadajaca za wyswietlanie obrazkow
        private PictureBox pic;
        const int MAXZOOM = 5;
        //! \brief konstruktor odpowiadajacy za tworzenie obiektu MyPictureBox oraz kontrolki
        public MyPictureBox()
        {
            InitializeComponent();
            this.Controls.Add(pic);
        }
        //! \brief funkcja ustawiajaca parametry kontrolki takie jak m.in. kolor tla
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Black;
            this.pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 500);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // MyPictureBox
            // 
            this.AutoScroll = true;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }
        //! \brief funkcja odpowiadajaca za wczytywanie z pliku
        public void LoadFromFile(string txt)
        {
            try
            {
                pic.Load(txt);
            }
            catch
            {
                MessageBox.Show("Nie można odczytać pliku", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pic.Size = pic.Image.Size;
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            dopasuj();
        }
         //! \brief funkcja odpowiadajaca za dopasowywanie kontrolki do obrazka
        private void dopasuj()
        {
            if (pic.Width < this.Width &&
                pic.Height < this.Height)
            {
                pic.Location = new System.Drawing.Point(
                    (this.Width - pic.Width) / 2,
                    (this.Height - pic.Height) / 2);
            }
            else
            {
                pic.Location = new System.Drawing.Point(0, 0);
            }
        }
         
        public void ZoomIn()
        {
            if (pic.Image == null) return;
            if (pic.Width >= MAXZOOM * pic.Image.Width ||
                pic.Height >= MAXZOOM * pic.Image.Height)
            {
                return;
            }
            pic.Width = (int)(pic.Width + pic.Image.Width / MAXZOOM);
            pic.Height = (int)(pic.Height + pic.Image.Height / MAXZOOM);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            dopasuj();
        }
        
        public void ZoomOut()
        {
        if (pic.Image == null) return;
        if (pic.Width <= pic.Image.Width / MAXZOOM || pic.Height <= pic.Image.Height / MAXZOOM)
        {
            return;
        }
        pic.Width = (int)(pic.Width - pic.Image.Width / MAXZOOM);
        pic.Height = (int)(pic.Height - pic.Image.Height / MAXZOOM);
        pic.SizeMode = PictureBoxSizeMode.StretchImage;
           dopasuj();
        }
        
        private void MyPictureBox_Resize(object sender, EventArgs e)
        {
            dopasuj();
        }
         
    }
}
