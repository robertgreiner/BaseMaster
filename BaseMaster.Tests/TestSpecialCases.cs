using System;
using NUnit.Framework;

namespace BaseMaster.Tests {
    [TestFixture]
    public class TestSpecialCases {
        [Test]
        public void TestBadInput() {
            string result = BaseUtility.Convert("109", 2, 10);
            Assert.AreEqual(result, "ERR");
        }
    }
}
