using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_Rules_NonCoops
    {
        [TestMethod]
        public void MultFactGrows()
        {
            Rules r = new Rules();
            int n = 3;
            float mult = 2;
            int rule = 1;
            int coop = 50;
            float exp = 0;

            float res = r.MultFactGrows(n, mult, rule, coop);

            if (coop >= rule && (mult + mult * 10 / 100) < n)
            {
                mult += mult * 10 / 100;
            }
            exp = mult;
            Assert.AreEqual(exp, res);
        }
    }
}
