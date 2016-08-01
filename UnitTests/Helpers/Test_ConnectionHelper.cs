﻿using Microsoft.Toolkit.Uwp;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTests.Helpers
{
    [TestClass]
    public class Test_ConnectionHelper
    {
        [TestMethod]
        public void Test_ConnectionHelper_IsInternetOnMeteredConnection()
        {
            Assert.IsFalse(ConnectionHelper.IsInternetOnMeteredConnection);
        }

        [TestMethod]
        public void Test_ConnectionHelper_IsInternetAvailable()
        {
            Assert.IsTrue(ConnectionHelper.IsInternetAvailable);
        }
    }
}
