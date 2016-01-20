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
        string path;
        private int numer=0;
        private int i=0,punkty=0,tmp=0;
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
            path = @"C:\Users\Marcin\Desktop\a.txt";
            items = File.ReadAllText(path).Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            obrazek.LoadFromFile(items[0]);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            textBox1.Visible = false;
            //label2.Visible = false;
            label3.Visible = false;
            

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
                path = @"C:\Users\Marcin\Desktop\b.txt";
                items = File.ReadAllText(path).Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                //obrazek.LoadFromFile(items[0]);
                button3.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button4.Text = "kon";
                button5.Text = "krowa";
                button6.Text = "kura";
                button7.Text = "pies";
                label2.Text = punkty.ToString();
                MessageBox.Show("Brawo przeszedłes do nastepnego etapu. Wybieraj poprawne nazwy zwierząt", "Gratulacje");
                numer =0;
                obrazek.LoadFromFile(items[numer]);
                //tmp++;
                //tmp = 2;
                //if (i == 1){ tmp=1; }
                    
                //}
                //else{
                  //  tmp=0;
                //}
                
                //button4_Click(sender, e);
                  //  button5_Click(sender,e);
                    //button6_Click(sender,e);
                    //button7_Click(sender,e);
                //obrazek.LoadFromFile(items[numer]);
                // if(radioButton1.Checked=true) {
                //  punkty ++;
                //i++;
            }

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if(numer==0){
            punkty++;
            label2.Text = punkty.ToString();
            numer++;
            //i++;
            obrazek.LoadFromFile(items[numer]);
            }
            else
                MessageBox.Show("NIestety wybrałeś zła nazwe. wybierz poprawnie", "Źle");
            //MessageBox.Show("Zła odpowiedź", "Uwaga", MessageBoxButtons.OK); 
            //MessageBox.Show("zła odpowiedź. Zaznacz prawidlowa");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(numer==1){
            punkty++;
            label2.Text = punkty.ToString();
            numer++;
            obrazek.LoadFromFile(items[numer]);
            }
            else
                MessageBox.Show("NIestety wybrałeś zła nazwe. wybierz poprawnie", "Źle");
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numer == 2)
            {
                punkty++;
                label2.Text = punkty.ToString();
                numer++;
                obrazek.LoadFromFile(items[numer]);
            }
            else
                MessageBox.Show("NIestety wybrałeś zła nazwe. wybierz poprawnie", "Źle");
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numer == 3)
            {
                punkty++;
                label2.Text = punkty.ToString();
                //numer++;
                //obrazek.LoadFromFile(items[numer]);
                MessageBox.Show("Gratulacje przeszedłeś kolejny etap punkty", "Gratulacje");
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = true;
                textBox1.Visible = true;
            }
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(numer==3 && string.Compare(textBox1.Text, "słoń", true)==0)
            {
                punkty++;
                label2.Text = punkty.ToString(); 
                numer++;
                obrazek.LoadFromFile(items[numer]);
                textBox1.Text = "";
            }
            else if (numer == 4 && string.Compare(textBox1.Text, "pies", true) == 0)
            {
                punkty++;
                label2.Text = punkty.ToString();
                MessageBox.Show("Gratulacje przeszedłeś całą gre", "Gratulacje");
            }
            else
            {
                MessageBox.Show("NIestety podałeś zła nazwe. wprowadź poprawną", "Źle");
                textBox1.Text = "";
            }

        }

      
    }
}
