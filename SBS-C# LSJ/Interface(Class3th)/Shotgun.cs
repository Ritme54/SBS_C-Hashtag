using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Program.GunAction;

namespace Program
{
    internal class Shotgun : Weapon, IReloadable, IMeleeAttack
    {
        private int damageValue = 30;                                         
        private int maxAmmo = 12;                                             
        private int currentAmmo = 12;

        public override string Name => "AA-12";

        public override void Damage(int damage)
        { if (damage <= 0) damage = 1; damageValue = damage; }
        public override void Maxammo(int ammo)
        { if (ammo < 1) ammo = 1; maxAmmo = ammo; currentAmmo = Math.Min(currentAmmo, maxAmmo); }

        public void Reload() { currentAmmo = maxAmmo; Console.WriteLine($"{Name} 재장전 완료 ({currentAmmo}/{maxAmmo})"); }

        // 근접공격 구현
        public int MeleeDamage { get; private set; } = 50;
        public void MeleeAttack() { Console.WriteLine($"{Name} 근접공격! 피해:{MeleeDamage}"); }
        public override string ToString() => $"{Name} | 데미지:{damageValue} | 탄창:{currentAmmo}/{maxAmmo}";

        public override void Activate()
        {
           MeleeAttack();
            Reload();
        }
    }
}
