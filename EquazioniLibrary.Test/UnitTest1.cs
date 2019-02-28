using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            double a = 10;
            bool determinata_attesa = true;
            bool determinata = EquazioniLibrary.Equazioni.isDetermined(a);
            Assert.AreEqual(determinata_attesa, determinata);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 0, b = 3;
            bool impossibile_attesa = true;
            bool impossibile = EquazioniLibrary.Equazioni.isInconsisted(a, b);
            Assert.AreEqual(impossibile_attesa, impossibile);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double a = 0, b = 0;
            bool indeterminata_attesa = true;
            bool indeterminata = EquazioniLibrary.Equazioni.isIndeterminata(a, b);
            Assert.AreEqual(indeterminata_attesa, indeterminata);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double a = 2;
            bool grado_attesa = true;
            bool grado = EquazioniLibrary.Equazioni.isDegree2(a);
            Assert.AreEqual(grado_attesa, grado);
        }
    }
    
}
