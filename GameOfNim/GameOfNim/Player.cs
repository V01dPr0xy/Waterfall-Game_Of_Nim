using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace GameOfNim.Models
{
    class Player : BasePlayer
    {
        /// <summary>
        /// Prompts user to make decisions necessary for a turn in Nim
        /// 1) Choose one of several heaps to remove from
        /// 2) Choose an amount to take from the chosen heap
        /// That amount is then taken
        /// </summary>
        /// <param name="heaps"> The heaps provided as choices </param>
        public override void TakeTurn(Dictionary<string, Heap> heaps)
        {
            //Playern's Turn
            //1) Choose pile
            //2) Quit
            Console.WriteLine(name + "'s Turn");
            if(CIO.PromptForMenuSelection(new string[] { "Choose pile" }, true) == 0) Environment.Exit(0);

            //Choose a pile
            //1) Heap1
            //2) Heap2
            //etc
            Console.WriteLine("Choose a pile");
            int heapIndex = CIO.PromptForMenuSelection(heaps.Keys, false);

            Heap chosenHeap = heaps.ElementAt(heapIndex - 1).Value;

            //Pick amount to take form Heapn
            int amountToTake = CIO.PromptForInt("Pick amount to take from " + chosenHeap.name, 0, chosenHeap.Amount);

            chosenHeap.TakeAmount(amountToTake);
        }
    }
}
