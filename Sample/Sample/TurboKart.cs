using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class TurboKart : Kart
    {

        public void Turbo()
        {
            Console.WriteLine("ブースト！");
        }

        public override void Horn()
        {
            Console.WriteLine("ぴぴーっ");
        }

    }



    //internal class TurboKart
    //{
    //    public int weight;
    //    public int speed;

    //    public void Force()
    //    {
    //        Console.WriteLine("加速or減速");
    //    }

    //    public void Turbo()
    //    {
    //        Console.WriteLine("ブースト！");
    //    }
    //}
}
