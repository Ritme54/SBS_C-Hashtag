using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Reward
    {
        private int money;
        private int exp;

        public Reward(int money, int exp)
        {
            this.money = money;
            this.exp = exp;
            

        }

        public void Describe()
        {
            Console.WriteLine("Money : " + money);
            Console.WriteLine("EXP : " + exp);
        }



    }
}
