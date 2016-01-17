using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class KalkulatorWiekuTesty
    {
        private static int RokTestowy = 1981;
        private static int MiesiacTestowy = 05;
        private static int DzienTestowy = 29;

        private int OczekiwanaIloscLat = DateTime.Now.Year - RokTestowy;
        private IWiek _osoba;


        [TestInitialize]
        public void Setup()
        {
            _osoba = new Osoba()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                DataUrodzenia = new DateTime(RokTestowy, MiesiacTestowy, DzienTestowy)
            };
        }

        [TestMethod]
        public void MetodaObliczZwracaIloscLat()
        {
            var kalkulatorWieku = new KalkulatorWieku(_osoba);
            Assert.AreEqual(OczekiwanaIloscLat, kalkulatorWieku.Oblicz());
        }
    }
}
