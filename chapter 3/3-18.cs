//using System;
//class JumpStApp
//{
//    public static void Main()
//    {
//        int n, s, i;
//        for (; ; ) //무한루프
//        {
//            Console.Write("Enter a number : ");
//            n = Int32.Parse(Console.ReadLine()); //받은정수 문자열을 정수로 변환
//            if (n == 0) break; //0입력시 무한루프종료 (무한루프 종료조건)
//            else if (n < 0) continue; //음수인 경우 무시
//            for (s = 0, i = 1; i <= n; ++i) //s=0으로 초기화
//                s = sum(s, i); //함수 호출
//            Console.WriteLine("n = {0}, sum = {1}", n, s);
//        }
//        Console.WriteLine("End of Main");
//    }
//    static int sum(int s, int i) //static메소드
//    {
//        return s + i; //결과 반환
//    }
//}