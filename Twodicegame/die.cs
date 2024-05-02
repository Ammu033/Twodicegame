using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twodicegame
{
    public class Die
    {

        private Random random;
        public int FaceValue { get; private set; }

        public Die()
        {
            random = new Random();
            Roll();
        }

        public int Roll()
        {
            FaceValue = random.Next(1, 7); // Generates a random number between 1 and 6
            return FaceValue;
        }
    }
}
