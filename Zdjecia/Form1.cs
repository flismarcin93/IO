using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Zdjecia
{
    public partial class Form1 : Form
    {
        string[] wczytanePliki;
        string[] przyciski=new string []{"koń","krowa","kura","pies","słoń"};
        string []items;
        private int numer=0;
        int i,punkty=0;
        //Uzytkownik a;
        //Form2 forma2;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("wybierz plec","no", MessageBoxButtons.YesNoCancel); 
            //this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            //wczytanePliki[0] = Directory.GetCurrentDirectory() + "images.jpg";
            Form2 form2 = new Form2(this);
            form2.Owner = this;
            form2.ShowDialog();
            String path = @"C:\Users\Marcin\Desktop\a.txt";
            items = File.ReadAllText(path).Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            obrazek.LoadFromFile(items[0]);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label2.Visible = false;
            

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
            /*
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.ShowDialog();
            //if (dialog.FileName != "")
            //   obrazek.LoadFromFile(dialog.FileName);
            OpenFileDialog open = new OpenFileDialog();
           open.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            open.Filter = "JPEG Compressed Image (*.jpg|*.jpg" + "|GIF Image(*.gif|*.gif" + "|Bitmap Image(*.bmp|*.bmp";
            open.Multiselect = true;
            open.FilterIndex = 1;

            // jezeli pomyslnie wybrano pliki to skopiuj nazwy do tablicy wczytanePliki
           if (open.ShowDialog() == DialogResult.OK)
           {
                wczytanePliki = new string[open.FileNames.Length];
                open.FileNames.CopyTo(wczytanePliki, 0);
                obrazek.LoadFromFile(wczytanePliki[numer]);
               // obrazek.LoadFromFile("C:\\Users\\Marcin\\Desktop\\images.jpg");
               //obrazek.LoadFromFile(items[0]);
            }

            */
            
        }
        /*
        private void zoominToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obrazek.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obrazek.ZoomOut();
        }

        private void nastepnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numer<1) obrazek.LoadFromFile(items[++numer]);
            //else
            //{
             //   numer=0;
              //  obrazek.LoadFromFile(wczytanePliki[numer]);
            //}
        }

        private void poprzedniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numer > 0) obrazek.LoadFromFile(items[--numer]);
            //else
            //{
              //  numer = 1;
                //obrazek.LoadFromFile(wczytanePliki[numer]);
            //}
        }
        
        private void logowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            //form2.Owner = this;
            form2.ShowDialog();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("dziekujemy za skorzystanie", "Żegnaj", MessageBoxButtons.OK);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numer > 0) obrazek.LoadFromFile(items[--numer]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numer++;
            if (numer <= 4) { 
                obrazek.LoadFromFile(items[numer]); 
            }
            if (numer == 5)
            {
                button3.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                label2.Visible = true;
                button4.Text = przyciski[i];
                button5.Text = przyciski[i + 1];
                button6.Text = przyciski[i + 2];
                button7.Text = przyciski[i + 3];
                label2.Text = punkty.ToString();
                numer = 0;
                if (i == 2) button4_Click(sender, e);
                //obrazek.LoadFromFile(items[numer]);
                // if(radioButton1.Checked=true) {
                //  punkty ++;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            punkty++;
            label2.Text = punkty.ToString();
            numer++;
            obrazek.LoadFromFile(items[numer]);
        }

      
    }
}
