using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal interface GunAction
    {
        internal interface IReloadable 
        { void Reload(); }

        internal interface IMeleeAttack
        { int MeleeDamage { get; } void MeleeAttack(); }



    }
}
