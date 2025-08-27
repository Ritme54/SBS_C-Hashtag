
using System.Collections.Generic;

namespace Program
{

    internal class Program
    {
        static void Main()
        {
            #region 컬렉션
            //
            #region List
            //

            //List<int> list = new List<int>();
            //list.Capacity = 10;
            //
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //
            //foreach (int element in list) 
            //{
            //    Console.WriteLine(element);
            //
            //}
            #endregion
            #region Dictionary

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            int money = 0;

            dictionary.Add("Doran's Blade", 450);
            dictionary.Add("B.F  Sword", 1300);
            dictionary.Add("Randuin's Omen", 2700);

            foreach (var element in dictionary)
            {
                Console.WriteLine("KEY : " + $"{element.Key}");
                Console.WriteLine("VALUE : " + $"{element.Value}");

            }

            string key = "Doran's Blade";

            if (dictionary.TryGetValue(key, out money))
            {
                money = dictionary[key];
                Console.WriteLine(money);

            }
            else
            {
                dictionary.Add(key, 500);
            }

            // foreach (var element in dictionary)
            // {
            //     Console.WriteLine("KEY : " + $"{element.Key}");
            //     Console.WriteLine("VALUE : " + $"{element.Value}");
            //    
            //
            // }
            #endregion

            #region Stack
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            //while(stack.Count>0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            #endregion

            #region Queue
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            #endregion

            #region Linked List
            //양뱡향연결 리스트
            LinkedList<int> linkedlist = new LinkedList<int>();

            linkedlist.AddFirst(10);
            linkedlist.AddFirst(5);
            linkedlist.AddFirst(1);

            linkedlist.AddLast(20);

            foreach (int element in linkedlist)
            {
                Console.WriteLine(element);

            }

            #endregion

            #endregion

        }
    }
}
