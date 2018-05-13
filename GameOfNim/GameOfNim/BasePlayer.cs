using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.Models
{
    public abstract class BasePlayer
    {
        public string name;

        /// <summary>
        /// Takes turn in Nim. Takes an amount great than zero 
        /// but less than the amount of one of the heaps passed 
        /// from that heap
        /// </summary>
        /// <param name="heaps"> the heaps that an amount can be taken from </param>
        public abstract void TakeTurn(Dictionary<string, Heap> heaps);
    }
}
