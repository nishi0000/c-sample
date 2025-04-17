using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Player
    {
        public string name;
        public int hp;

        public Player(string name,int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get { return this.hp; }
        }

        //public void SetHp(int hp)
        //{
        //    this.hp = hp;
        //    if (this.hp < 0)
        //    {
        //        this.hp = 0;
        //    }
        //}

        //public int GetHp()
        //{
        //    return this.hp;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length <= 8)
        //    {
        //        this.name = name;
        //    }
        //}

        //public string GetName() 
        //{ 
        //    return this.name;
        //}

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }

    internal class Enemy
    {
        public int hp;

        public void Attack()
        {
            Console.WriteLine("敵の攻撃！");
        }

        public void Escape()
        {
            Console.WriteLine("逃げられた！");
        }
    }
}
