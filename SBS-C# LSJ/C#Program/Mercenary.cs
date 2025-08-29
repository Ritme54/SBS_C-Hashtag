using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Mercenary : Entity, MoveIT, AttackedIT
    {
        public override string Name => "Outer";

        public void Move()
        {
            Console.WriteLine("Mercenary move");

        }

        public void Attacked(float Taketodamage)
        {
            Console.WriteLine("Mercenary attacked");

        }
    }

}