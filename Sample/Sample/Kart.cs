using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Kart
    {
        public int weight;
        public int speed;

        public void Force()
        {
            Console.WriteLine("加速");
        }

        public virtual void Horn()
        {
            Console.WriteLine("ぶっぶー");
        }

    }
}
