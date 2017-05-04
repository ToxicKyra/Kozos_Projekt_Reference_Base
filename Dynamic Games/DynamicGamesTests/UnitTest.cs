using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;
using Dynamic_Games.coop.models;
using System.Collections.Generic;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest
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

        [TestMethod]
        public void CoalitionMaxTest()
        {
            Coalition c = new Coalition(5);
            ValueFunction vf = new ValueFunction("");
            int[] materials = new int[5];
            double max = 0;
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
            }
            double res = c.getMaximumValue();
            Assert.AreEqual(max, 2*res);
        }

        //[TestMethod]
        //public void CardStatTest()
        //{

        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();

        //    String symbol = "c";
        //    String nameHelper;

        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int num = 1; num <= 9; num++)
        //        {
        //            nameHelper = symbol + "0" + num.ToString();
        //            dictionary.Add(nameHelper, 0);
        //        }
        //        for (int num = 10; num <= 13; num++)
        //        {
        //            nameHelper = symbol + num.ToString();
        //            dictionary.Add(nameHelper, 0);
        //        }
        //        switch (symbol)
        //        {
        //            case "c":
        //                symbol = "d";
        //                break;
        //            case "d":
        //                symbol = "h";
        //                break;
        //            case "h":
        //                symbol = "s";
        //                break;
        //        }
        //    }

        //    int n = 1000;

        //    for (int j = 0; j < n; j++)
        //    {
        //        Dynamic_Games.IncInformation.Cards.Deck d = new Dynamic_Games.IncInformation.Cards.Deck();
        //        for (int i = 0; i < 21; i++)
        //        {
        //            Dynamic_Games.IncInformation.Cards.Card c = d.getCard();
        //            dictionary[c.CardName]++;
        //        }
        //    }

        //    double alfa = n * 0.41;

        //    double epsilon = 100;

        //    bool result = true;

        //    Console.WriteLine("Epsilon : " + epsilon + "      Alfa : " + alfa);

        //    foreach (KeyValuePair<string, int> entry in dictionary)
        //    {
        //        Console.WriteLine("Key : " + entry.Key + "   Value: " + entry.Value + "     Gamma: " + (entry.Value - alfa));
        //        if (Math.Abs(entry.Value - alfa) > epsilon)
        //        {
        //            Console.WriteLine("FAILED");
        //            result = false;
        //        }
        //    }
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void CardTest()
        //{
        //    bool result = true;
        //    IncInformationForm testForm = new IncInformationForm();
        //    if (testForm.Flop1.Image != testForm.table.flop[0].CardImage)
        //        result = false;
        //    if (testForm.Flop2.Image != testForm.table.flop[1].CardImage)
        //        result = false;
        //    if (testForm.Flop3.Image != testForm.table.flop[2].CardImage)
        //        result = false;
        //    if (testForm.River.Image != testForm.table.river.CardImage)
        //        result = false;
        //    if (testForm.Turn.Image != testForm.table.turn.CardImage)
        //        result = false;
        //    int i = 0;
        //    foreach (Dynamic_Games.IncInformation.Player.Player p in testForm.table.players)
        //    {
        //        if (testForm.cardIterator[i].Image != p.cards[0].CardImage)
        //            result = false;
        //        if (testForm.cardIterator[i + 1].Image != p.cards[1].CardImage)
        //            result = false;
        //        i += 2;
        //    }
        //    Assert.IsTrue(result);
        //}
    }
}
