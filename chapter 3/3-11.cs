//using System;
//class ForStApp
//{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
//    public static void Main(string[] args)
//    {
//        int i, n;
//        double h = 0.0;
//        Console.Write("Enter a number = ");
//        n = Console.Read() - '0'; //문자열형을 정수형으로 변환
//        for (i = 1; i <= n; ++i) //1부터 n까지 반복
//            h = h + 1 / (double)i; //캐스트연산자를 사용해서 형변환
//        Console.WriteLine("n = {0}, h = {1}", n, h);
//    }
//}