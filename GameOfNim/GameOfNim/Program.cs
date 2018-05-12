using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfNim.Models;

namespace GameOfNim
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            gm.RunGame();
        }
    }
}
