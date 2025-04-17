using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class SkyKart : Kart
    {

        public void Flying()
        {
            Console.WriteLine("離陸");
        }

        public override void Horn()
        {
            
            Console.WriteLine("ぴーぴー");
        }

    }




    //internal class SkyKart
    //{
    //    public int weight;
    //    public int speed;

    //    public void Force()
    //    {
    //        Console.WriteLine("加速");
    //    }

    //    public void Flying()
    //    {
    //        Console.WriteLine("離陸");
    //    }

    //}
}
