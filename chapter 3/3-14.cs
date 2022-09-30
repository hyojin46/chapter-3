//using System;
//class DoWhileApp
//{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
//    public static void Main()
//    {
//        int n, i;
//        double h = 0.0;
//        Console.Write("Enter a number = ");
//        n = Console.Read() - '0'; //문자열형을 정수형으로 변환
//        i = 1;
//        do //조건식이 거짓이라도 최소 1번은 실행
//        {
//            h = h + 1 / (double)i;
//            i++;
//        } while (i <= n); //거짓이면 루프를 벗어나고, 참이면 반복
//        Console.WriteLine("n = " + n + ", h = " + h);
//    }
//}