/*
 과제: 숫자 맞추기 게임 (Up & Down)
컴퓨터가 1부터 100 사이의 비밀 숫자를 무작위로 정합니다.
학생이 숫자를 입력하면 컴퓨터가 "더 높아요(Up)!" 또는 "더 낮아요(Down)!"라고 힌트를 주며 맞추는 게임입니다.
랜덤 숫자 생성 함수를 배워서 진행합니다. (예: Random.Next(1, 101))
 */

public class Program
{
    public static void Main(string[] args)
    {
        var random = new Random();
        int num = random.Next(1, 101);

        Console.WriteLine("숫자 맞추기 게임에 오신 것을 환영합니다!");
        Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");

        while (true)
        {
            Console.Write("숫자를 입력하세요: ");
            int guess = int.Parse(Console.ReadLine());
            // if (!int.TryParse(Console.ReadLine(), out guess))
            // {
            //     Console.WriteLine("유효한 숫자를 입력해주세요.");
            //     continue;
            // }

            if (guess < num)
            {
                Console.WriteLine("더 높아요(Up)!");
            }
            else if (guess > num)
            {
                Console.WriteLine("더 낮아요(Down)!");
            }
            else
            {
                Console.WriteLine("축하합니다! 숫자를 맞추셨습니다!");
                break;
            }
        }
    }
}