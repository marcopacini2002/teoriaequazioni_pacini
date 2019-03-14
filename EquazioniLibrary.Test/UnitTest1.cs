using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void determinata1()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.determinata(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void determinata2()
        {
            double a = 2;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.determinata(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void determinata3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.determinata(a);

            Assert.AreEqual(risposta_attesa, test);

        }



        [TestMethod]
        public void Impossibile1()
        {
            double a = 0, b = 3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Impossibile(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossibile2()
        {
            double a = 3, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossibile(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossibile3()
        {
            double a = 0, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossibile(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossibile4()
        {
            double a = 3, b = 3;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossibile(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }




        [TestMethod]
        public void indeterminata1()
        {
            double a = 0, b = 0;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void indeterminata2()
        {
            double a = 2, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void indeterminata3()
        {
            double a = 0, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void indeterminata4()
        {
            double a = 2, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }





        [TestMethod]
        public void grado1()
        {
            double a = 3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Controllo(a);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void grado2()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Controllo(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void grado3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Controllo(a);

            Assert.AreEqual(risposta_attesa, test);

        }






        [TestMethod]
        public void Delta1()
        {
            double a = 0, b = 5, c = 2;
            double risposta_attesa = 25;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta2()
        {
            double a = 2, b = 0, c = 2;
            double risposta_attesa = -16;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta3()
        {
            double a = 2, b = 4, c = 0;
            double risposta_attesa = 16;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta4()
        {
            double a = 0, b = 0, c = 0;
            double risposta_attesa = 0;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione1()
        {
            double a = 0, b = 0;
            string risposta_attesa = "Indeterminato";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione2()
        {
            double a = 0, b = 3;
            string risposta_attesa = "Impossibile";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione3()
        {
            double a = 1, b = 3;

            string risposta_attesa = $"x={-3}";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]

        public void Equazione4()
        {
            double a = 1, b = -3;

            string risposta_attesa = $"x={3}";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);


            Assert.AreEqual(risposta_attesa, test);

        }

    }

}
