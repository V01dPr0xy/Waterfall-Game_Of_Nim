using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    public class Heap
    {
        
        public int Amount { get; private set; }
        public bool IsEmpty { get { return Amount == 0; } }

        public string name;

        public Heap(string name, int amount)
        {
            this.name = name;
            Amount = amount;
        }

        /// <summary>
        /// Subtracts amountToTake from Amount unless it would make Amount negative or if amountToTake is zero
        /// </summary>
        /// <param name="amountToTake"> how much will be subtracted from Amount </param>
        /// <returns> true if Amount was changed </returns>
        public bool TakeAmount(int amountToTake)
        {
            if (amountToTake <= 0 || amountToTake > Amount) return false;

            Amount -= amountToTake;

            return true;
        }

        /// <summary>
        /// ToString override to show relevant information
        /// </summary>
        /// <returns> name and amount with a colon in between </returns>
        public override string ToString()
        {
            return name + " : " + Amount;
        }
    }
}
