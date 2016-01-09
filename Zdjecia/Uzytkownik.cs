using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zdjecia
{
    class Uzytkownik
    {
        string Imie;
        int wiek;
        string plec;
        public Uzytkownik(string Imie, string plec, int wiek)
        {
            this.Imie = Imie;
            this.plec = plec;
            this.wiek = wiek;
        }
    }
}
