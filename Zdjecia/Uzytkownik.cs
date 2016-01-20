using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zdjecia
{
    public class Uzytkownik
    {
        string Imie="marcin";
        int wiek=9;
        string plec="mezczyzna";
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
