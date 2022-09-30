//using System; //지역변수의 이름 충돌 예제
//class AnotherBlock
//{
//    public static void Main(string[] args)
//    {
//        int x = 1; //전역변수 x
//        {
//            // int x; // error ( 블록 밖의 전역변수x와 겹침)
//            int y = 2;
//            Console.WriteLine("Block 1: x = " + x + ", y = " + y);
//        }
//        {
//            int y = 3;
//            Console.WriteLine("Block 2: x = " + x + ", y = " + y);
//        }
//    }
//}