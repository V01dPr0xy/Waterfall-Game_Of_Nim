using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    class GameManager
    {
        BasePlayer[] Players;
        Dictionary<string, Heap> heaps;

        /// <summary>
        /// Prompts the player through the console to choose the game's starting modes. 
        ///     These include if the game is PvP or PvC, if the game is easy (2 heaps of 3, 3), 
        ///     medium (3 heaps of 2, 5, 7), or hard (4 heaps of 2, 3, 8, 9). The Players can also change their names
        /// </summary>
        void SetupGame()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Calls SetupGame(). It then iterates through players calling TakeTurn() for each. After each
        ///     turn is taken it calls CheckGameIsOver() to see if a player has won. If they have, EndGame() is called
        /// </summary>
        void RunGame()
        {
            SetupGame();
             
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints which player won and asks the players if they woud like to play again. If they answer yes, the 
        ///     game goes back to the beginning. If not, it exits
        /// </summary>
        /// <returns></returns>
        bool EndGame()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if every Heap in heaps is empty
        /// </summary>
        /// <returns></returns>
        bool CheckGameIsOver()
        {
            foreach (Heap h in heaps.Values)
                if (h.amount != 0)
                    return false;
            return false;
        }
    }
}
