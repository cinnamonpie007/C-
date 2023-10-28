using System.Runtime.Intrinsics.Arm;

public class lesson6
{
    public static int Countnumb(List<int> arr)
    {
        int count = 0;
        foreach(int i in arr)
        {
            if(i > 0)
            {
                count += 1;
            }
        }
        return count;
    }

    public static Tuple<double, double> Points(double b1, double k1, double b2, double k2)
    {
        double y1 = 0;
        double y2 = 0;
        if(k1 == k2)
        {
            System.Console.WriteLine("Прямые параллельны, точки пересечения нет");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            y1 += k1 * x + b1;
            y2 += k2 * x + b2;
        }

        return Tuple.Create(y1, y2);
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("task 41");
        List<int> array = new List<int>();
        System.Console.Write("какой длинны список ?: ");
        string? x = Console.ReadLine();
        for (int i = 0; i < Convert.ToInt32(x); i++)
        {
            System.Console.Write($"введите число {i + 1} : ");
            string? numb = Console.ReadLine(); 
            array.Add(Convert.ToInt32(numb));
        }

        System.Console.WriteLine(Countnumb(array));

        System.Console.WriteLine("task 43");
        System.Console.Write("Введите b1 : ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Введите k1 : ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Введите b2 : ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Введите k2 : ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine($"Точки пересечения: {Points(b1, k1, b2,k2)}");

    }
}