using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_NonCoopForm
    {
        [TestMethod]
        public void InputNonCoopTest()
        {
            NonCoopForm nonCoopTest = new NonCoopForm();

            nonCoopTest.NoPTB.Text = "";
            nonCoopTest.InvestmentTB.Text = "";
            nonCoopTest.MultiTB.Text = "";
            nonCoopTest.RuleParamTB.Text = "";
            Assert.IsFalse(nonCoopTest.checkParams());

            nonCoopTest.NoPTB.Text = "5";
            Assert.IsFalse(nonCoopTest.checkParams());

            nonCoopTest.InvestmentTB.Text = "2";
            Assert.IsFalse(nonCoopTest.checkParams());

            nonCoopTest.MultiTB.Text = "2";
            Assert.IsFalse(nonCoopTest.checkParams());

            nonCoopTest.RuleParamTB.Text = "2";
            Assert.IsTrue(nonCoopTest.checkParams());
        }
    }
}
