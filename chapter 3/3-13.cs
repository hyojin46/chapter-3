//using System;
//class WhileStApp
//{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
//    public static void Main()
//    {
//        int i, n;
//        double h = 0.0;
//        Console.Write("Enter a number = ");
//        n = Console.Read() - '0'; //문자열형을 정수형으로 변환
//        i = 1;
//        while (i <= n) //n이 i보다 클때 실행
//        {
//            h = h + 1 / (double)i; //캐스트연산자를 사용해서 형변환
//            i++; //후위증감연산자
//        }
//        Console.WriteLine("n = {0}, h = {1}", n, h);
//    }
//}