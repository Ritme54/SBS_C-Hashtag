
using System.Collections.Generic;
using C_Program;

namespace C_Program
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            //클래스의 구성 단위가 하나의 책임만 가질 수 있도록 설계해야 되는 원칙
            //예시 : 퀘스트 창 만들기

            //Class Quest


            //제목 을 위해서 private string title;
            // string title 

            //퀘스트 해결여부를 위해서 private bool Compensate;
            //

            //퀘스트 보상 클래스를 따로 만들어서
            //class Service
            //{
            //void Compensate(Quest quest
            //}

            // Quest[] questList = new Quest[3];
            //List<Quest> quests = new List<Quest>();
            //
            //quests.Add(new Quest("화물 5개 수거","도적들이 훔처간 화물 상자 5개를 가저와주게.", new Reward (10, 500));
            //quests.Add(new Quest("몬스터 5마리 처치", "몬스터 무리 처리하게", new Reward(10, 500)));
            //quests.Add(new Quest("잃어버린 고양이 찾기", "고양이 찾아와라.", new Reward(10, 500)));
            //
            //for (int i = 0; i < quests.Count; i++)
            //{
            //    quests[i].Describe();
            //    reward[i].Describe();
            //}

            #endregion

            #region 개방 폐쇄 원칙

            //소프트웨어의 구성 요소는 확장에는 열려 있어야 하고 변경에는 닫혀 있어야 한다.

            //Enchant enchant = new Enchant();
            //enchant.Enchanc(new Sword());


            // enchant.Enchant(new Item("Sword", 10, 5, 1));
            // enchant.Enchant(new Item("Necklace", 1, 1, 10));
            // enchant.Enchant(new Item("Shoes", 0, 20, 0));


            #endregion

            #region 인터페이스 분리 원칙
            //

            VIP vip = new VIP();
            vip.Move();


            #endregion

        }
    }
}
