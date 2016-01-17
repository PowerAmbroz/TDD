using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //tworzymy pierwszy test jednostkowy
        public void MetodaToStringZwracaImieOrazNazwisko()
        { 
            var osoba = new Osoba() //tworzymy zmienna osoba, która przyjmuje wartości Imie i Nazwisko
            {
                        Imie = "Jan",
                        Nazwisko = "Kowalski"
            };
            Assert.AreEqual("Jan Kowalski", osoba.ToString()); //weryfikuje czy podane w nawiasach wartości są stringami i czy należa do zmiennej osoba
        }

        [TestMethod] //drugi test jednostkowy
        public void MetodaWiekZwracaIloscLatOsoby()
            {
                var osoba = new Osoba
                {
                    Imie = "Jan",
                    Nazwisko = "Kowalski",
                    DataUrodzenia = new DateTime(1991, 02, 12)
                };
                Assert.AreEqual(25, osoba.Wiek); //podajemy najpierw obecny wiek a następnie program 
                                                 //porównuje go z wiekiem wyliczonym, jesli są prawidłowe to test kończy się sukcesem
            }
    }
}
