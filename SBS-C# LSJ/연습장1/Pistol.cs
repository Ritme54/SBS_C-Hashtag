using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습장1
{
    internal class Pistol : Guns
    {


        public override string Name => "G18C";

        public override string Description => "연사가 되는 자동권총";


        public override int Damage(int damage)
        {
           damage = 18; 
            return damage;
        }

        public override int MagAmmo(int magAmmo)
        {
            magAmmo = 18;
            return magAmmo;
        }

        public override int MaxAmmo(int maxAmmo)
        {
           maxAmmo = 180;
            return maxAmmo;
        }

        public override int NowAmmo(int nowAmmo)
        {
            nowAmmo = 18;

        }

        public override int RerodeTime(int rerodeTime)
        {
            throw new NotImplementedException();
        }
    }
}
