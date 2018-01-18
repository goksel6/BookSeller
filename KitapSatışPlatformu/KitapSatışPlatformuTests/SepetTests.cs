using Microsoft.VisualStudio.TestTools.UnitTesting;
using KitapSatışPlatformu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapSatışPlatformu.Tests
{
    [TestClass()]
    public class SepetTests
    {

        Sepet s;
        Form1 f;

        [TestMethod()]
        public void ToplamaTest()
        {
            double sayi1 = 5;
            double sayi2 = 3;
            s = new Sepet(f);
            double expected = s.Toplama(sayi1, sayi2);
            Assert.AreEqual(expected, 8);
        }
    }
 }
