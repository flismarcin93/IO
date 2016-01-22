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
    /**\file
      * /
      /**\class Form2
      *\brief Form2 sluzy do wysiwetlenia ekranu logowania i utworzeniu profilu gracza
      */ 
    public partial class Form2 : Form
    {
        //Uzytkownik a;
        private Form1 formaa1;
        //! \brief konstruktor klasy Form2
        public Form2(Form1 forma1)
        {
            InitializeComponent();
           // this.WindowState = FormWindowState.Maximized;
            formaa1 = forma1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string tmpplec="kobieta";
            //if (radioButton2.Checked == true) tmpplec = "mezczyna";
            //int zmienna = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            //a = new Uzytkownik(textBox1.Text, tmpplec, zmienna);
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            formaa1.label1.Text = textBox1.Text;
        }

    }
}
