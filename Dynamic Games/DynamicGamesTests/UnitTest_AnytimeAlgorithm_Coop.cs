using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games.coop.backend;
using System.Collections.Generic;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_AnytimeAlgorithm_Coop
    {
        [TestMethod]
        public void GetNumbersPartition()
        {
            AnytimeAlgorithm aa = new AnytimeAlgorithm();
            int n = 5, l = 8;
            List<int[]> t = aa.getNumbersPartition(n, l);
            var crit = true;
            t.ForEach(e => crit &= (e.Length == l));  // every array has the length l
            Assert.IsTrue(crit);
        }
        [TestMethod]
        public void GetNumbersAllPartitionExcept()
        {
            AnytimeAlgorithm aa = new AnytimeAlgorithm();
            int n = 5, l = 8;
            List<int[]> t = aa.generateNumbersAllPartitionExcept(n, l);
            var crit = true;
            t.ForEach(e => crit &= (e.Length != l));  // every array except those with length l
            Assert.IsTrue(crit);
        }
    }
}
