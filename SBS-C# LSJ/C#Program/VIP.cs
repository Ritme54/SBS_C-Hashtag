using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class VIP : Entity, MoveIT
    {
        public override string Name => "CT VIP";

        public void Move()
        {
            Console.WriteLine("Moving");
        }

    }

    
}
