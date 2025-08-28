using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Pistol : Weapon
    {
        public override string Name => "G17";

        public override void Activate()
        {
            throw new NotImplementedException();
        }

        public override void Damage(int damage)
        {
            damage = 5;

        }

        public override void Maxammo(int ammo)
        {
            ammo = 17;
        }
        public override string ToString() => $"{Name} | 데미지:{Damage} | 탄창:{Maxammo}";

    }
}
