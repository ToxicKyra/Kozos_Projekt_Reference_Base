using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games.coop.models;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_Coalition_Coop
    {
        [TestMethod]
        public void CoalitionMaxTest()
        {
            Coalition c = new Coalition(5);
            ValueFunction vf = new ValueFunction("");
            int[] materials = new int[5];
            double max = 0, res = 0;
            materials[0] = 1;
            materials[1] = 5;
            materials[2] = 3;
            materials[3] = 8;
            materials[4] = 4;
            Player p1 = new Player(vf, materials);
            c.addPlayer(p1);
            p1.Materials = materials;

            foreach (var i in materials)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i > c.getMaximumValue())
                {
                    res = i;
                }
            }

            Assert.AreEqual(max, res);
        }
    }
}
