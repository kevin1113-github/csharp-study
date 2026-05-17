public class Program
{
    public static void Main(string[] args)
    {
        // for (int num = 2; num < 10; num++)
        // {
        Console.Write("몇단을 출력할까요? : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num + "단");
        for(int i=1; i<10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + num*i);
        }
        
        Console.WriteLine();
        // }

        // int a = 10;
        // a = int.Parse(Console.ReadLine());

        // Console.WriteLine("입력한 수는 " + a + "입니다.");
    }
}