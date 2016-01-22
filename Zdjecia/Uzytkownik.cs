using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zdjecia
{
/**\file
 * /
 /**\class Uzytkownik
 *\brief Uzytkownik sluzy do tworzenia profilu uzytkownika
 */
    public class Uzytkownik
    {
        //! \brief zmienna odpowiadajaca imieniu uzytkownika
        string Imie="marcin";
        //! \brief zmienna odpowiadajaca wiekowi uzytkownika
        int wiek=9;
        //! \brief zmienna odpowiadajaca plci uzytkownika
        string plec="mezczyzna";
        //! \brief konstruktor odpowiadajacy za tworzenie nowego uzytkownika
        public Uzytkownik(string Imie, string plec, int wiek)
        {
            this.Imie = Imie;
            this.plec = plec;
            this.wiek = wiek;
        }
        //public string dane()
        //{
          //  return this.Imie;
        //}
    }
}
