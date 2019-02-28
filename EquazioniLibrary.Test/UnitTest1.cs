﻿using System;
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
    }
    
}
