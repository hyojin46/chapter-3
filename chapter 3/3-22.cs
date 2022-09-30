//using System;
//class ReadIntegerApp
//{
//    static int ReadInt()
//    {
//        char ch;
//        int n = 0;
//        while (!char.IsDigit(ch = (char)Console.Read())) ;//isDigit(): 숫자여부검사 -> 숫자이면 true, 아니면 false를 반환
//        do //반복문: 거짓이더라도 최소 한번은 실행
//        {
//            n = n * 10 + (ch - '0');//ch - '0' = 정수형 ch
//            ch = (char)Console.Read(); //정수형을 문자형으로 변환하여 입력받음
//        } while (char.IsDigit(ch));
//        return n;
//    }
//    public static void Main()
//    {
//        Console.Write("*** input data : ");
//        Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt()); //ReadInt(): 숫자여부검사
//    }
//}