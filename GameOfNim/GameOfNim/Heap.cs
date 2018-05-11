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

        public bool TakeAmount(int amountToTake)
        {
            if (amountToTake <= 0 || amountToTake > Amount) return false;

            Amount -= amountToTake;

            return true;
        }

        public override string ToString()
        {
            return name + " : " + Amount;
        }
    }
}
