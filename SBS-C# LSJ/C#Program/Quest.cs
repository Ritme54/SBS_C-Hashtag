using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Quest
    {
        private Reward reward; // 보상 클래스 불러오기

        private string title; //
        private string description;

        private bool completed = false;


        public Quest(string title, string description, Reward reward)
        {
            this.title = title;
            this.description = description;
            this.reward = reward;

        }
        public void Describe()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Description : " + description);

        }
      


    }



}
