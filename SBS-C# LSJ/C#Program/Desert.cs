using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Desert : Terrain
    {
        public override void Describe()
        {
            Console.WriteLine("Desert");
        }

        public Desert()
        {
            width = 30;
            height = 50;
        }

    }
}
