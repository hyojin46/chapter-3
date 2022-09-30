//using System; //필드변수와 지역변수 예제
//class LocalVariableApp
//{
//    static int x; //필드변수x (클래스 내 모든 메소드 접근 가능)
//    public static void Main() //새로운 메소드
//    {
//        int x = (LocalVariableApp.x = 2) * 2; //메소드내 변수x, 정적필드 접근 = 클래스명.필드이름
//        Console.WriteLine("static x = " + LocalVariableApp.x);
//        Console.WriteLine("local x = " + x);
//    }
//}