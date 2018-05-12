using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace GameOfNim.Models
{
    public class GameManager
    {
        BasePlayer[] Players;
        Dictionary<string, Heap> heaps;

        /// <summary>
        /// Prompts the player through the console to choose the how many players, 
        /// set their names, and choose what game mode they want
        /// </summary>
        void SetupGame()
        {
            if (CIO.PromptForBool("1 Player or 2 Players?", "1 Player", "2 Players"))
                Players = new BasePlayer[] { new Player(), new Player() };
            else
                Players = new BasePlayer[] { new Player(), new CPU() };

            int index = 1;
            foreach (Player p in Players)
            {
                string input = CIO.PromptForInput("", true);
                p.name = (input != string.Empty) ? input : "Player " + index;
                index++;
            }

            switch (CIO.PromptForMenuSelection(new string[] { "Easy - heaps with 3 and 3", "Medium - heaps with 2, 5, 7", "Hard = heaps of 2, 3, 8, 9" }, true))
            {
                case 1:
                    heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 3) }, { "B", new Heap("B", 3) } };
                    break;

                case 2:
                    heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 2) }, { "B", new Heap("B", 5) }, { "C", new Heap("C", 7) } };
                    break;

                case 3:
                    heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 2) }, { "B", new Heap("B", 3) }, { "C", new Heap("C", 8) }, { "D", new Heap("D", 9) } };
                    break;
            }
        }

        /// <summary>
        /// Calls SetupGame(). It then iterates through players calling TakeTurn() for each. After each
        ///     turn is taken it calls CheckGameIsOver() to see if a player has won. If they have, EndGame() is called
        /// </summary>
        public void RunGame()
        {
            SetupGame();
            bool isGameGoing = true;
            int turnNum = 0;
            while (isGameGoing)
            {
                Players[turnNum % 2].TakeTurn(heaps);
                if (CheckGameIsOver())
                    isGameGoing = false;
                turnNum++;
            }
            if (EndGame(Players[turnNum % 2]))
                RunGame();
            else Environment.Exit(0);
        }

        /// <summary>
        /// Prints which player won and asks the players if they would like to play again. If they answer yes, the 
        ///     game goes back to the beginning. If not, it exits
        /// </summary>
        /// <returns>Returns a bool that represents if the player wants to continue playing or not</returns>
        bool EndGame(BasePlayer player)
        {
            return CIO.PromptForBool(player.name + " won! Do you wish to keep playing?", "Yes", "No");
        }

        /// <summary>
        /// Returns true if every Heap in heaps is empty
        /// </summary>
        /// <returns>A bool representing the emptiness of all heaps</returns>
        bool CheckGameIsOver()
        {
            foreach (Heap h in heaps.Values)
                if (h.Amount != 0)
                    return false;
            return true;
        }
    }
}
