using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습장1
{
    internal abstract class Guns
    {
        protected string name;

        protected string description;

        protected int magAmmo; //탄창 용량

        protected int nowAmmo; //현재 탄

        protected int maxAmmo; //최대 탄

        protected int damage; // 데미지

        protected int rerodeTime;




        

        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract int MagAmmo (int magAmmo);
        public abstract int MaxAmmo (int maxAmmo); 

        public abstract int NowAmmo (int nowAmmo);
        public abstract int Damage  (int damage);  
 
        public abstract int RerodeTime (int rerodeTime);







    }
}
