using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfNim.Models;
using System.Collections.Generic;

namespace GameOfNimUnitTesting
{
    [TestClass]
    public class GameManagerTests
    {
        [TestMethod]
        public void GameManagerGameIsOver_TestTrue_HeapsEmpty()
        {
            GameManager gm = new GameManager();
            gm.heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 0) }, { "B", new Heap("B", 0) } };
            
            bool answer = gm.CheckGameIsOver();

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void GameManagerGameIsOver_TestFalse_HeapsNotEmpty()
        {
            GameManager gm = new GameManager();
            gm.heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 3) }, { "B", new Heap("B", 3) } };
            
            bool answer = gm.CheckGameIsOver();

            Assert.IsFalse(answer);
        }

        //[TestMethod]
        //public void GameManagerEndGame_TestFalse()
        //{
        //    GameManager gm = new GameManager();
        //    gm.EndGame(new Player() { name = "Billy-Jo" });

        //    Assert.IsTrue(true);
        //}

        //[TestMethod]
        //public void GameManagerEndGame_TestTrue()
        //{
        //    GameManager gm = new GameManager();
        //    gm.EndGame(new Player() { name = "Billy-Jo" });

        //    Assert.IsTrue(true);
        //}
    }
}
