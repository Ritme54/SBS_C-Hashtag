
using System.Collections.Generic;
using C_Program;

namespace Program
{

    internal class Program
    {
        static void Main()
        {
            #region 추상 클래스

            Weapon shotgun = new Shotgun();


            Console.WriteLine(shotgun.ToString());
            shotgun.Activate();

            //Weapon pistol = new Pistol();
            //Console.WriteLine(pistol.ToString());//

            //Terrain terrain = new Desert();

            

            //Console.WriteLine("Width : " + terrain.Width);
            //Console.WriteLine("Height : " + terrain.Height);



            #endregion



        }
    }
}
