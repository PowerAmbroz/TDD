using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    class Osoba : IWiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Imie, Nazwisko);
        }

        public int Wiek
        { 
            get
            {
                return DateTime.Now.Year - DataUrodzenia.Year;
            }
        }
    }
}
