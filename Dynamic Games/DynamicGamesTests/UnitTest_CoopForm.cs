using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_CoopForm
    {
        [TestMethod]
        public void InputCoopTest()
        {
            CoopForm coopTest = new CoopForm();

            coopTest.richTextBoxPlayerFunc.Text = "";
            coopTest.numericPlayer.Value = 0;
            coopTest.richTextBoxMaterials.Text = "";
            Assert.IsFalse(coopTest.CheckFill());

            coopTest.numericPlayer.Value = 5;
            Assert.IsFalse(coopTest.CheckFill());

            coopTest.richTextBoxPlayerFunc.Text = "alma";
            Assert.IsFalse(coopTest.CheckFill());

            coopTest.richTextBoxMaterials.Text = "rost\nmag";
            Assert.IsTrue(coopTest.CheckFill());
        }

        [TestMethod]
        public void GetRandomFunction()
        {
            int m = 5;
            CoopForm cf = new CoopForm();
            string res = cf.getRandomFunction(m);

            Assert.IsTrue(res.Length == (5 * m - 1)); // <number>*X<number2>+<number>*X<number2>+
        }

        [TestMethod]
        public void GetRandomMaterial()
        {
            int m = 5;
            CoopForm cf = new CoopForm();
            string res = cf.getRandomMaterials(m);

            Assert.IsTrue(res.Split(' ').Length == m); // <number> <number>
        }
    }
}
