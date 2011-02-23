using System;
using NUnit.Framework;

namespace BaseMaster.Tests {
    [TestFixture]
    public class TestConversions {
        
        [Test]
        public void TestHexToDec() {
            string result = BaseUtility.Convert("13D", 16, 10);
            Assert.AreEqual(result, "317");
        }
        [Test]
        public void TestHexToOct() {
            string result = BaseUtility.Convert("13D", 16, 8);
            Assert.AreEqual(result, "475");
        }
        [Test]
        public void TestHexToBin() {
            string result = BaseUtility.Convert("13D", 16, 2);
            Assert.AreEqual(result, "100111101");
        }

        [Test]
        public void TestDecToHex() {
            string result = BaseUtility.Convert("31417", 10, 16);
            Assert.AreEqual(result, "7AB9");
        }
        [Test]
        public void TestDecToOct() {
            string result = BaseUtility.Convert("31417", 10, 8);
            Assert.AreEqual(result, "75271");
        }
        [Test]
        public void TestDecToBin() {
            string result = BaseUtility.Convert("31417", 10, 2);
            Assert.AreEqual(result, "111101010111001");
        }

        [Test]
        public void TestOctToHex() {
            string result = BaseUtility.Convert("7527143", 8, 16);
            Assert.AreEqual(result, "1EAE63");
        }
        [Test]
        public void TestOctToDec() {
            string result = BaseUtility.Convert("75271", 8, 10);
            Assert.AreEqual(result, "31417");
        }
        [Test]
        public void TestOctToBin() {
            string result = BaseUtility.Convert("123", 8, 2);
            Assert.AreEqual(result, "1010011");
        }

        [Test]
        public void TestBinToHex() {
            string result = BaseUtility.Convert("1001111", 2, 16);
            Assert.AreEqual(result, "4F");
        }
        [Test]
        public void TestBinToDec() {
            string result = BaseUtility.Convert("1001111", 2, 10);
            Assert.AreEqual(result, "79");
        }
        [Test]
        public void TestBinToOct() {
            string result = BaseUtility.Convert("1001111", 2, 8);
            Assert.AreEqual(result, "117");
        }


    }
}
