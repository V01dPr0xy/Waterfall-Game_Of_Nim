using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    public class CPU : BasePlayer
    {

        /// <summary>
        /// The CPU is passed the dictionary of all heaps. 
        /// It then looks to see if it can make a winnning move 
        /// this turn by leaving the last available heap with 1.
        /// Else it chooses a random, valid heap and takes a random amount between 1 and the max.
        /// </summary>
        /// <param name="heaps"></param>
        public override void TakeTurn(Dictionary<string, Heap> heaps)
        {
            Heap chosenHeap = null;
            int amount = 0;
            int zeroCount = 0;

            foreach(Heap h in heaps.Values)
            {
                if (h.IsEmpty)
                {
                    zeroCount++;
                }
                else
                {
                    chosenHeap = h;
                }
            }

            if(chosenHeap != null && chosenHeap.Amount > 1 && zeroCount == heaps.Count - 1)
            {
                amount = chosenHeap.Amount - 1;
                chosenHeap.TakeAmount(amount);
            }
            else
            {
                Random rand = new Random();
                List<Heap> list = heaps.Values.ToList();
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].IsEmpty)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }
                chosenHeap = list[rand.Next(list.Count)];
                amount = rand.Next(chosenHeap.Amount);
              
            }

            chosenHeap.TakeAmount(amount);
            Console.WriteLine("CPU took " + amount + " from heap " + chosenHeap.name);
        }
    }
}
