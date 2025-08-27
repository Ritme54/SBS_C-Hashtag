

using C_Program;

namespace Program
{

    internal class Program
    {
        static void Main()
        {
            #region

            //C#은 C++과 달리 전역변수를 지원하지 않는다.
            //따라서 전역변수를 사용하고 싶다면 static 키워드를 사용해야만 한다.

            //C# 이름 규칙
            //1. 대소문자를 구분한다.
            //2. 숫자로 시작된다.
            //3. 특수문자는 _ (언더바)만 허용된다.
            //4. 공백을 포함할 수 없다.
            #endregion

            #region
            //char rank = 'A'; //문자형 변수
            //int health = 100;

            // Fix for CS1003: Added a comma between the string and the variable.
            // Fix for CA2241: Corrected the format string to include a placeholder for the variable.
            // Console.WriteLine("rank: {0}", rank);
            // Console.WriteLine(health);
            //Marine marine = new Marine();
            //참조 변수 == 포인터
            #endregion

            #region 박싱
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.
            //
            //int value = 100;
            //object generic = value; 
            //Console.WriteLine($"value :{value} ");
            //Console.WriteLine("generic : " + generic);

            #endregion


            #region 언박싱
            //참조 형식의 데이터를 값 형식으로 변환하는 과정입니다.

            //int box = (int)generic;

            //Console.WriteLine("box : " + box);

            //utility.Pause();
            #endregion
            Utility utility = new Utility();
            #region 매개 변수 한정자
            //함수의 매개 변수 앞에 해당하는 인자의 전달 방식을 지정하는 한정자.
            //ref // 참조로 전달(읽기/쓰기)

            //int next = 10;
            //int previous = 35;
            //
            //utility.Swap(ref next, ref previous);
            //Console.WriteLine($"next: {next} {previous}, previous: {previous}");

            //out 참조로 전잘(쓰기 전용)
            //in // 참조로 전달(읽기 전용)
            //params // 가변 길이 매개 변수


            //int A = -10;
            //int distance = -11;
            //
            //Console.WriteLine("Absolute의 값 : " + utility.Absolute(in A));

            //출력용 매개 변수
            //void 함수(out value)
            //float length;
            //
            //
            //Vector2 direction = new Vector2(1, 2);
            //utility.Magnitude(direction, out length);

            #endregion


        }
    }
}
