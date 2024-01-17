using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dice
{

    internal class diceroll
    {
        private int die1;
        private int die2;
        private int diesum;
        public int[] rolldie(int rolls)
        {
            Random random = new Random();

            int[] results = new int[11];

            for (int i = 0; i < rolls; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                diesum = die1 + die2;
                results[diesum-2] = results[diesum-2] + 1;
            }

            return results;
        }

    }
}
