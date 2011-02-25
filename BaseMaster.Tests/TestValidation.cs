using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace BaseMaster.Tests {
    [TestFixture]
    public class TestValidation {
        [Test]
        public void TestInvalidHex() {
            string errorMessage = ValidationUtility.Validate("300x", "16");
            Assert.IsNotNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestInvalidDec() {
            string errorMessage = ValidationUtility.Validate("100a", "10");
            Assert.IsNotNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestInvalidOct() {
            string errorMessage = ValidationUtility.Validate("1239", "8");
            Assert.IsNotNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestInvalidBin() {
            string errorMessage = ValidationUtility.Validate("100102101110", "2");
            Assert.IsNotNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestValidHex() {
            string errorMessage = ValidationUtility.Validate("1234567890abcdefABCDEF", "16");
            Assert.IsNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestValidDec() {
            string errorMessage = ValidationUtility.Validate("1234567890", "10");
            Assert.IsNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestValidOct() {
            string errorMessage = ValidationUtility.Validate("12345670", "8");
            Assert.IsNullOrEmpty(errorMessage);
        }
        [Test]
        public void TestValidBin() {
            string errorMessage = ValidationUtility.Validate("10010101110", "2");
            Assert.IsNullOrEmpty(errorMessage);
        }
    }
}
