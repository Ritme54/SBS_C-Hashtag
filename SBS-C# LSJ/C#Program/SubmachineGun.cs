using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class SubmachineGun : Weapon
    {
        public override string Name => "MP-40";

        public override void Activate()
        {
            throw new NotImplementedException();
        }

        public override void Damage(int damage)
        {
            damage = 7;

        }

        public override void Maxammo(int ammo)
        {
            ammo = 32;
        }

        public override string ToString() => $"{Name} | 데미지:{Damage} | 탄창:{Maxammo}";

    }
}
