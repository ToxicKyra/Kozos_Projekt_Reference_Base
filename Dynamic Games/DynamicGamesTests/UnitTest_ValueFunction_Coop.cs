using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;
using Dynamic_Games.coop.models;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_ValueFunction_Coop
    {
        //Coop: returns the value of function to given parameters
        [TestMethod]
        public void ValueFunction()
        {
            CoopForm cf = new CoopForm();
            int[] materials = new int[5];
            double loc = 0;
            string function = cf.getRandomFunction(5);
            materials[0] = 12;
            materials[1] = 10;
            materials[2] = 11;
            materials[3] = 8;
            materials[4] = 14;

            string[] func = function.Split('+');

            for (int i = 0; i < 5; i++)
            {
                int v = Convert.ToInt32(func[i].Substring(0, 1));
                loc += v * materials[i];
            }

            ValueFunction vf = new ValueFunction(function);
            double res = vf.getValue(materials);
            Assert.AreEqual(res, loc);
        }
    }
}
