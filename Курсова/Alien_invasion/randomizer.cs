using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_invasion
{
    public class randomizer
    {
        Random random = new Random();

        public int createNum(int min, int max)
        {
            return random.Next(min, max+1);
        }
        public int createNum(int max)
        {
            return random.Next(1, max + 1);
        }
    }
}
