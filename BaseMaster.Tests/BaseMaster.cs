using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BaseMaster.Tests {
    [TestFixture]
    public class BaseMaster {
        
        [Test]
        public void TestHexToDec() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestHexToOct() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestHexToBin() {
            Assert.Inconclusive();
        }

        [Test]
        public void TestDecToHex() {
            int testNum = 317;
            string hexValue = testNum.ToString("X");
            Assert.AreEqual(hexValue, "13D");
        }
        [Test]
        public void TestDecToOct() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestDecToBin() {
            Assert.Inconclusive();
        }

        [Test]
        public void TestOctToHex() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestOctToDec() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestOctToBin() {
            Assert.Inconclusive();
        }

        [Test]
        public void TestBinToHex() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestBinToDec() {
            Assert.Inconclusive();
        }
        [Test]
        public void TestBinToOct() {
            Assert.Inconclusive();
        }


    }
}
