//using System;
//class OverflowApp
//{
//    public static void Main()
//    {
//        int i, max = int.MaxValue; // 정수 최대값 지정 (overflow 생성 용도)
//        try //try catch 예외처리 문
//        {
//            Console.WriteLine("Start of try statement");
//            i = max + 1; // default: don’t check Overflow.
//            Console.WriteLine("After default overflow");
//            unchecked //오버플로를 의도적으로 검사하지 않은 경우
//            {
//                i = max + 1; // don’t check Overflow intentionally.
//            }
//            Console.WriteLine("After unchecked statemen");
//            checked //오버플로를 검사
//            {
//                i = max + 1; // check Overflow
//            }
//            Console.WriteLine("After checked statement");
//        }
//        catch (OverflowException e) //예외처리로 수행되지 않음
//        {
//                Console.WriteLine("caught an OverflowException");
//        }
//    }
//}