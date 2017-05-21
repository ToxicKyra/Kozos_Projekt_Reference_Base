using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games.IncInformation.Player;
using Dynamic_Games.IncInformation.Game;
using Dynamic_Games.IncInformation.Cards;
using Dynamic_Games;

namespace DynamicGamesTests
{
    [TestClass]
    public class UniteTest_Player_IncInformation
    {
        [TestMethod]
        public void HumanPlayer_setCards_IncInformation()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var humanPlayer = new HumanPlayer(1000, 0, table);
            var card1 = new Dynamic_Games.IncInformation.Cards.Card("back1", Dynamic_Games.Properties.Resources.black);
            var card2 = new Dynamic_Games.IncInformation.Cards.Card("back2", Dynamic_Games.Properties.Resources.black);
            humanPlayer.setCards(card1, card2);

            if (card1 != humanPlayer.cards[0])
                Assert.Fail();
            if (card2 != humanPlayer.cards[1])
                Assert.Fail();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void HumanPlayer_setPosition_IncInformation()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var humanPlayer = new HumanPlayer(1000, 0, table);
            humanPlayer.setPos(new Position());

            if (humanPlayer.pos.Equals(null))
                Assert.Fail();
        }
        [TestMethod]
        public void AIPlayer_setCards_IncInformation()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var parameters = new Parameters(1);
            var aiPlayer = new AIPlayer(1000, 0, table, parameters);
            var cardForAiPlayer = new Dynamic_Games.IncInformation.Cards.Card("back", null);
            var card = new Dynamic_Games.IncInformation.Cards.Card("back", Dynamic_Games.Properties.Resources.back);
            aiPlayer.setCards(cardForAiPlayer, cardForAiPlayer);

            if (card.CardName != aiPlayer.cards[0].CardName || card.CardImage.Size != aiPlayer.cards[0].CardImage.Size)
                Assert.Fail();
            if (card.CardName != aiPlayer.cards[0].CardName || card.CardImage.Size != aiPlayer.cards[1].CardImage.Size)
                Assert.Fail();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void AiPlayer_setPosition_IncInformation()
        {
            var deck = new Deck();
            var incInformationForm = new IncInformationForm();
            var table = new Table(deck, 2, incInformationForm);
            var parameters = new Parameters(1);
            var aiPlayer = new AIPlayer(1000, 0, table, parameters);
            aiPlayer.setPos(new Position());

            if (aiPlayer.pos.Equals(null))
                Assert.Fail();
        }
    }
}
