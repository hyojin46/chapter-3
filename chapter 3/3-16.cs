//using System;
//class BreakStApp
//{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
//    public static void Main()
//    {
//        int n, i;
//        double h = 0.0;
//        Console.Write("Enter a number = ");
//        n = Console.Read() - '0'; //문자열형을 정수형으로 변환
//        i = 1; //초깃값
//        while (true) //참일때까지 반복
//        {
//            h = h + 1 / (double)i;
//            if (++i > n) break; //while문 밖으로 
//        }
//        Console.WriteLine(" n = " + n + ", h = " + h);
//    }
//}