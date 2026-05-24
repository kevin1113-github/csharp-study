using System.Collections;

public class Program
{
    static int CalculateChange(int inputMoney, int itemPrice)
    {
        return inputMoney - itemPrice;
    }

    public static void Main(string[] args)
    {
        Hashtable 음료수 = new Hashtable();
        음료수["콜라"] = 2600;
        음료수["사이다"] = 1800;
        음료수["환타"] = 2700;
        음료수["코코팜"] = 1200;

        Console.WriteLine("음료수를 선택하세요:");
        foreach (string key in 음료수.Keys)
        {
            Console.WriteLine("\t" + key + ": " + 음료수[key] + "원");
        }

        Console.Write("음료수 입력>>>");
        string inputName = Console.ReadLine();
        if (inputName == null || !음료수.ContainsKey(inputName))
        {
            Console.WriteLine(inputName + " 음료수가 없습니다.");
            return;
        }

        Console.Write("돈 입력>>>");
        int inputMoney = int.Parse(Console.ReadLine());

        int price = (int)음료수[inputName];
        int returnMoney = CalculateChange(inputMoney, price);

        if (returnMoney >= 0)
        {
            Console.WriteLine(inputName + " 음료수는 " + price + "원 입니다.");
            Console.WriteLine("거스름돈은 " + CalculateChange(inputMoney, price) + "원 입니다.");
        }
        else
        {
            Console.WriteLine("돈이 부족합니다.");
        }
    }
}
