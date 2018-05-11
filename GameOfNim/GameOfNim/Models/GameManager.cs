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

        void SetupGame()
        {

            throw new NotImplementedException();
        }

        void RunGame()
        {
            throw new NotImplementedException();
        }

        bool EndGame()
        {
            throw new NotImplementedException();
        }

        bool CheckGameIsOver()
        {
<<<<<<< HEAD
            foreach (Heap h in heaps.Values)
                if (h.amount != 0)
                    return false;
            return false;
=======
            throw new NotImplementedException();
>>>>>>> 4885cf2012ffe7db7bdd5820f1bfd1ae57541eca
        }
    }
}
