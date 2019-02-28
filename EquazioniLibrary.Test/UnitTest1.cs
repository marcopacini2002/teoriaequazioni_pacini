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
    }
    
}
