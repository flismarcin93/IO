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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmpplec="kobieta";
            if (radioButton2.Checked == true) tmpplec = "mezczyna";
            int zmienna = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            Uzytkownik a = new Uzytkownik(textBox1.Text, tmpplec, zmienna);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
