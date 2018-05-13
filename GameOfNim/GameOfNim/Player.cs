using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace GameOfNim.Models
{
    public class Player : BasePlayer
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
            //| A - 3 | B - 3 |
            //1) Choose pile
            //2) Quit
            Console.WriteLine(name + "'s Turn");

            Console.Write("| ");
            foreach (Heap h in heaps.Values) Console.Write(h + " | ");
            Console.WriteLine();

            if(CIO.PromptForMenuSelection(new string[] { "Choose pile" }, true) == 0) Environment.Exit(0);

            //Choose a pile
            //1) Heap1
            //2) Heap2
            //etc
            int heapIndex;
            Heap chosenHeap;
            do
            {
                Console.WriteLine("Choose a pile");
                heapIndex = CIO.PromptForMenuSelection(heaps.Keys, false);
                chosenHeap = heaps.ElementAt(heapIndex - 1).Value;

                if (chosenHeap.IsEmpty) Console.WriteLine("That heap is empty");
            } while (chosenHeap == null || chosenHeap.IsEmpty);

            

            int amountToTake = 0;
            bool validAmount = true;
            //Pick amount to take form Heapn
            do
            {
                amountToTake = CIO.PromptForInt("Pick amount to take from " + chosenHeap.name + " (Between 1 and " + chosenHeap.Amount + ")", Int32.MinValue, Int32.MaxValue);

                validAmount = chosenHeap.TakeAmount(amountToTake);
                if(!validAmount)
                {
                    Console.WriteLine(amountToTake < 1 ? "That's too little" : "That's too much");
                }
            } while (!validAmount);
        }
    }
}
