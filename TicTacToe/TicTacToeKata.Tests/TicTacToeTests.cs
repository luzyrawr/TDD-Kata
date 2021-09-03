using NUnit.Framework;
using System;

namespace TicTacToeKata.Tests
{
    /*
    * State of square: is square empty
    * Set X
    * Set O
    * State of game: is game finished
    * Who is the winner
    */
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CreateGame_GameHasCorrectState()
        {
            Game game = new Game();
            Assert.AreEqual(State.Unset, game.GetState(1));
            Assert.AreEqual(0, game.MovesCounter);
        }

        [Test]
        public void MakeMove_CounterShifts()
        {
            Game game = new Game();
            game.MakeMove(1);
            Assert.AreEqual(1, game.MovesCounter);
        }

        [Test]
        public void MakeInvalidMove_ThrowsException()
        {            
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                var game = new Game();
                game.MakeMove(0);
            });
        }

        [Test]
        public void MoveOnTheSameSquare_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var game = new Game();
                game.MakeMove(1);
                game.MakeMove(1);
            });
        }

        [Test]
        public void MakingMoves_SetStateCorrectly()
        {
            var game = new Game();
            MakeMoves(game, 1,2,3,4);
            
            Assert.AreEqual(State.Cross, game.GetState(1));
            Assert.AreEqual(State.Zero, game.GetState(2));
            Assert.AreEqual(State.Cross, game.GetState(3));
            Assert.AreEqual(State.Zero, game.GetState(4));
        }

        [Test]
        public void GetWinner_ZerosWinVertically_ReturnsZeroes()
        {
            var game = new Game();

            //2,5,8 - Zero wins
            MakeMoves(game, 1, 2, 3, 5, 7, 8);
            Assert.AreEqual(Winner.Zeroes, game.GetWinner());
        }

        [Test]
        public void GetWinner_CrossesWinDiagonaly_ReturnsCrosses()
        {
            var game = new Game();

            //1,5,9 - Cross wins
            MakeMoves(game, 1, 2, 5, 3, 9);
            Assert.AreEqual(Winner.Crosses, game.GetWinner());
        }

        [Test]
        public void GetWinner_GameIsUnfinished_ReturnsGameIsUnfinished()
        {
            var game = new Game();

            MakeMoves(game, 1, 2, 5);
            Assert.AreEqual(Winner.GameIsUnfinished, game.GetWinner());
        }

        private void MakeMoves(Game game, params int[] indexes)
        {
            foreach (var index in indexes)
            {
                game.MakeMove(index);
            }            
        }        
    }
}