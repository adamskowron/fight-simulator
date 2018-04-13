using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2
{
    abstract class Creature
    {
        public int maxSpeed;
        Random random;

        public virtual int GetCurrentSpeed()
        {
            int currentSpeed = random.Next(maxSpeed);
            return currentSpeed;
        }
    }
}
