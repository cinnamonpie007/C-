
public class lesson9
{
    public static void lesson64(int n)
    {  
        if (n != 0)
        {
            Console.Write(n);
            if(n > 1)
            {
                Console.Write(", ");
            }
            lesson64(n - 1);
        }
    }
    public static void lesson66(int m, int n)
    {
        int x = 0;
        if(m < n)
        {
            for(int i = m; i <= n; i++)
            {
                x += i;
            }
        }
        else
        {
            for(int i = n; i <= m; i++)
            {
                x += i;
            }
        }
        System.Console.WriteLine(x);
    }
    public static int lesson68(int m, int n)
    {
        if(m == 0) return n + 1;
        else if(n == 0) return lesson68(m - 1, 1);
        else return lesson68(m - 1, lesson68(m, n - 1));
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Задание 64");
        Console.Write("Введите значение N: ");
        string? x = Console.ReadLine();
        int n = Convert.ToInt32(x);
        lesson64(n);
        System.Console.WriteLine("\nЗадача 66");
        Console.Write("Введите значение M: ");
        string? x1 = Console.ReadLine();
        int m = Convert.ToInt32(x1);
        Console.Write("Введите значение N: ");
        string? x2 = Console.ReadLine();
        int n1 = Convert.ToInt32(x2);
        lesson66(m, n1);
        System.Console.WriteLine("Задача 68");
        Console.Write("Введите значение M: ");
        string? x3 = Console.ReadLine();
        int m1 = Convert.ToInt32(x3);
        Console.Write("Введите значение N: ");
        string? x4 = Console.ReadLine();
        int n2 = Convert.ToInt32(x4);
        System.Console.WriteLine(lesson68(m1, n2));
    }
}