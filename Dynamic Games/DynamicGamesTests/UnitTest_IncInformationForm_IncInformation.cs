using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;
using System.Collections.Generic;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_IncInformationForm_IncInformation
    {
        [TestMethod]
        public void CardStatTest()
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            var symbol = "c";
            var nameHelper = default(string);

            for (var i = 0; i < 4; i++)
            {
                for (var num = 1; num <= 9; num++)
                {
                    nameHelper = symbol + "0" + num.ToString();
                    dictionary.Add(nameHelper, 0);
                }
                for (int num = 10; num <= 13; num++)
                {
                    nameHelper = symbol + num.ToString();
                    dictionary.Add(nameHelper, 0);
                }
                switch (symbol)
                {
                    case "c":
                        symbol = "d";
                        break;
                    case "d":
                        symbol = "h";
                        break;
                    case "h":
                        symbol = "s";
                        break;
                }
            }

            var n = 100;
            for (var j = 0; j < n; j++)
            {
                var d = new Dynamic_Games.IncInformation.Cards.Deck();
                for (var i = 0; i < 21; i++)
                {
                    var c = d.getCard();
                    dictionary[c.CardName]++;
                }
            }
            double alfa = n * 0.41;
            double epsilon = 100;
            bool result = true;
            foreach (var entry in dictionary)
            {
                if (Math.Abs(entry.Value - alfa) > epsilon)
                {
                    result = false;
                }
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestDivisionCards_IncInformationForm_Visualize()
        {
            bool result = true;
            IncInformationForm testForm = new IncInformationForm();
            testForm.table.resetTable();
            testForm.vizualize();
            if (testForm.Flop1.Image != testForm.table.flop[0].CardImage)
                result = false;
            if (testForm.Flop2.Image != testForm.table.flop[1].CardImage)
                result = false;
            if (testForm.Flop3.Image != testForm.table.flop[2].CardImage)
                result = false;
            if (testForm.River.Image != testForm.table.river.CardImage)
                result = false;
            if (testForm.Turn.Image != testForm.table.turn.CardImage)
                result = false;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_PlayerCards_IncInformationForm_Visualize()
        {
            bool result = true;
            IncInformationForm testForm = new IncInformationForm();
            testForm.table.resetTable();
            testForm.vizualize();
            int i = 0;
            foreach (var p in testForm.table.players)
            {
                if (testForm.cardIterator[i].Image.Size != (p.cards[0].CardImage.Size))
                    result = false;
                if (testForm.cardIterator[i+1].Image.Size != (p.cards[0].CardImage.Size))
                    result = false;
                i += 2;
            }
            Assert.IsTrue(result);
        }
    }
}
