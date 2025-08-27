using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal abstract class Weapon
    {



        public abstract string Name { get; }
        
        public abstract void Damage(int damage);

        public abstract void Maxammo(int ammo);


        public abstract string ToString();

        public abstract void Activate();
    }
}
