//using System;
//class CalculatorApp
//{
//    public static void Main()
//    {
//        int x, y, r = 0;
//        char opr;
//        Console.Write("Enter an operator & two numbers = ");
//        opr = (char)Console.Read(); //문자열형을 문자형으로 변환
//        x = Console.Read() - '0'; // 문자열형을 정수형으로 변환
//        y = Console.Read() - '0'; // 문자열형을 정수형으로 변환
//        switch (opr) //문자형opr이 참일때까지 반복
//        {
//            case '+':
//                r = x + y;
//                Console.WriteLine(x + " + " + y + " = " + r);
//                break;
//            case '-':
//                r = x - y;
//                Console.WriteLine(x + " - " + y + " = " + r);
//                break;
//            case '*':
//                r = x * y;
//                Console.WriteLine(x + " * " + y + " = " + r);
//                break;
//            case '/':
//                r = x / y;
//                Console.WriteLine(x + " / " + y + " = " + r);
//                break;
//            default:
//                Console.WriteLine("Illegal operator ");
//                break;
//        }
//    }
//}