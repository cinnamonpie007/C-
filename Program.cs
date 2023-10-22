System.Console.WriteLine("Task 1");

// task 1
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
// int a = 2;
// int b = 4;
int cub(int x, int y)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}
System.Console.WriteLine($"{a} в {b} степени = {cub(a, b)}");
// System.Console.WriteLine(Math.Pow(a, b));

System.Console.WriteLine("Task 2");

// task2

int c = new Random().Next(1, 1000);
int sum(int x)
{
    int c2 = c;
    int res = 0;
    for (int i = 0; i <= c2; i++)
    {
        res += c2 % 10;
        c2 /= 10;
    }
    return res;    
}
System.Console.WriteLine($"Сумма цифр числа {c} = {sum(c)}");

System.Console.WriteLine("Task 3");

// task3

void lists()
{
    List<int> res = new List<int>();
    for (int i = 0; i < 8; i++)
    {
        int v = new Random().Next(1, 10);
        res.Add(v);
    } 
    Console.WriteLine($"[{string.Join(", " , res)}]");
}
lists();