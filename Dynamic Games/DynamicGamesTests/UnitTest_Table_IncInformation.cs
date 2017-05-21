using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games.IncInformation.Game;
using Dynamic_Games;
using Dynamic_Games.IncInformation.Cards;
using System.Collections.Generic;
using Dynamic_Games.IncInformation.Player;

namespace DynamicGamesTests
{
    [TestClass]
    public class UnitTest_Table_IncInformation
    {
        [TestMethod]
        public void Table_startTable_IsCorrect()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var players = new List<Player>();
            players.Add(new HumanPlayer(1000, 1, table));
            players.Add(new HumanPlayer(1000, 1, table));
            table.startTable(players);

            if (table.players.Count != 2)
                Assert.Fail();
        }
        [TestMethod]
        public void Table_resetFolds_IsCorrect()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var players = new List<Player>();
            players.Add(new HumanPlayer(0, 1, table));
            players.Add(new HumanPlayer(0, 1, table));
            table.startTable(players);
            foreach (var player in table.players)
            {
                player.folded = true;
            }
            foreach (var player in table.players)
            {
                player.cash = 1000;
            }
            table.resetFolds();

            foreach (var player in table.players)
            {
                if (player.folded)
                    Assert.Fail();
            }
        }
        [TestMethod]
        public void Table_swapCards_IsCorrect()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var card1 = new Dynamic_Games.IncInformation.Cards.Card("back1", Dynamic_Games.Properties.Resources.black);
            var card2 = new Dynamic_Games.IncInformation.Cards.Card("back2", Dynamic_Games.Properties.Resources.black);
            table.swapCard(ref card1, ref card2);

            if (!(card1.CardName == "back2" && card2.CardName == "back1"))
                Assert.Fail();
        }
    }
}
