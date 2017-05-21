using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_PAES_NonCoopEquil
    {
        [TestMethod]
        public void IsEqual()
        {
            PAES p = new PAES(new NonCoopEquilForm(), 0, 0, "1", 0, "1", null);
            int n = 5;
            int exp = 0;
            double[] f1 = new double[5];
            f1[0] = 1.1;
            f1[1] = 2.1;
            f1[2] = 3;
            f1[3] = 4;
            f1[4] = 5.1;

            double[] f2 = new double[5];
            f2[0] = 1.1;
            f2[1] = 2.1;
            f2[2] = 3;
            f2[3] = 4;
            f2[4] = 5.1;

            for (int i=0; i < n; i++)
            {
                if (f1[i] != f2[i])
                {
                    exp = 0;
                }
            }
            exp = 1;

            int res = p.equal(f1, f2, n);
            Assert.AreEqual(exp, res);
        }
    }
}
