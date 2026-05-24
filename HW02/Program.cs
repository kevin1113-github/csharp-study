//과제: 나만의 아이돌/ 게임 캐릭터 도감 만들기
//좋아하는 아이돌 멤버 이름이나 게임 캐릭터 이름을 리스트에 저장하고 관리하는 프로그램입니다.
//파일 입출력을 사용하여 새로운 이름을 추가(Add)하거나, 전체 목록을 보거나, 특정 이름을 검색하는 기능을 구현합니다.
// characters.txt 파일에 저장하고 불러오는 기능을 구현합니다.
using System.Collections;
public class Program
{
    public static void Main(string[] args)
    {
        ArrayList characters = new ArrayList();
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. 게임 캐릭터 추가");
            Console.WriteLine("2. 전체 목록 보기");
            Console.WriteLine("3. 특정 이름 검색");
            Console.WriteLine("4. 저장하기");
            Console.WriteLine("5. 불러오기");
            Console.WriteLine("6. 종료");
            Console.Write("선택>>> ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    Console.Write("추가할 이름 입력>>> ");
                    string name = Console.ReadLine();
                    characters.Add(name);
                    Console.WriteLine(name + "이(가) 추가되었습니다.");
                    break;
                case 2:
                    Console.WriteLine("전체 목록:");
                    foreach (string character in characters)
                    {
                        Console.WriteLine("\t" + character);
                    }
                    break;
                case 3:
                    Console.Write("검색할 이름 입력>>> ");
                    string searchName = Console.ReadLine();
                    if (characters.Contains(searchName))
                    {
                        Console.WriteLine(searchName + "이(가) 목록에 있습니다.");
                    }
                    else
                    {
                        Console.WriteLine(searchName + "이(가) 목록에 없습니다.");
                    }
                    break;
                case 4:
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("characters.txt"))
                    {
                        foreach (string character in characters)
                        {
                            sw.WriteLine(character);
                        }
                    }
                    Console.WriteLine("데이터가 저장되었습니다.");
                    break;
                case 5:
                    if (System.IO.File.Exists("characters.txt"))
                    {
                        characters.Clear();
                        using (System.IO.StreamReader sr = new System.IO.StreamReader("characters.txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                characters.Add(line);
                            }
                        }
                        Console.WriteLine("데이터를 불러왔습니다.");
                    }
                    else
                    {
                        Console.WriteLine("저장된 파일이 없습니다.");
                    }
                    break;
                case 6:
                    Console.WriteLine("프로그램을 종료합니다.");
                    return;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 시도하세요.");
                    break;
            }
        }

    }
}