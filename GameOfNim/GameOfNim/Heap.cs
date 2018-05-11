using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    class Heap
    {
        public int Amount { get; private set; }
        public bool IsEmpty { get { return Amount == 0; } }

        public string name;

        public bool TakeAmount(int amountTaken)
        {
            if (amountTaken <= 0 || amountTaken > Amount) return false;

            Amount -= amountTaken;

            return true;
        }

        public override string ToString()
        {
            return name + " : " + Amount;
        }
    }
}
