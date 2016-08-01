﻿using System;
using Microsoft.Toolkit.Uwp;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTests.Helpers
{
    [TestClass]
    public class Test_ColorHelper
    {
        [TestMethod]
        public void Test_ColorHelper_ToColor_Predifined()
        {
            Assert.AreEqual("Red".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToColor_Hex8Digits()
        {
            Assert.AreEqual("#FFFF0000".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToColor_Hex6Digits()
        {
            Assert.AreEqual("#FF0000".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToColor_Hex4Digits()
        {
            Assert.AreEqual("#FF00".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToColor_Hex3Digits()
        {
            Assert.AreEqual("#F00".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToColor_ScreenColor()
        {
            Assert.AreEqual("sc#1.0,1.0,0,0".ToColor(), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_ToHex()
        {
            const string RED_HEX_VALUE = "#FFFF0000";
            Assert.AreEqual(Windows.UI.Colors.Red.ToHex(), RED_HEX_VALUE);
        }

        [TestMethod]
        public void Test_ColorHelper_ToInt()
        {
            const int RED_INT_VALUE = -65536;
            Assert.AreEqual(Windows.UI.Colors.Red.ToInt(), RED_INT_VALUE);
        }

        [TestMethod]
        public void Test_ColorHelper_ToHsl()
        {
            HslColor hslRed;
            hslRed.A = 1.0;  // Alpha
            hslRed.H = 0.0;  // Hue
            hslRed.S = 1.0;  // Saturation
            hslRed.L = 0.5;  // Lightness

            Assert.AreEqual(Windows.UI.Colors.Red.ToHsl(), hslRed);
        }

        [TestMethod]
        public void Test_ColorHelper_ToHsv()
        {
            HsvColor hsvRed;
            hsvRed.A = 1.0;  // Alpha
            hsvRed.H = 0.0;  // Hue
            hsvRed.S = 1.0;  // Saturation
            hsvRed.V = 1.0;  // Value

            Assert.AreEqual(Windows.UI.Colors.Red.ToHsv(), hsvRed);
        }

        [TestMethod]
        public void Test_ColorHelper_FromHsl()
        {
            Assert.AreEqual(ColorHelper.FromHsl(0.0, 1.0, 0.5), Windows.UI.Colors.Red);
        }

        [TestMethod]
        public void Test_ColorHelper_FromHsv()
        {
            Assert.AreEqual(ColorHelper.FromHsv(0.0, 1.0, 1.0), Windows.UI.Colors.Red);
        }
    }
}
