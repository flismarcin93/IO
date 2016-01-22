using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Zdjecia
{
    /**\file
     * /
     /**\class Program
     *\brief Program sluzy do uruchamiania gry
     */  
    static class Program
    {
        //! \brief fuckja glowna programu tworzaca obiekt klasy Form1
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
