
public class Program
{
    static void print(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num);
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] arr1 = { 7, 9, 3 };
        int[] arr2 = { 6, 4, 2 };
        int[] arr3 = { 1, 2, 3, 5, 7 };

        print(arr1);
        print(arr2);
        print(arr3);
    }
}
