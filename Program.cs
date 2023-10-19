int numb = new Random().Next(100, 999);
int secondNumb(int numb)
{
    int result = (numb % 100) / 10;
    return (result);
}
Console.WriteLine(numb);
Console.WriteLine($"цифра под индексом -2: {secondNumb(numb)}");

int numb2 = new Random().Next(0, 100000);
if (numb2 >= 100)
{
    int result = 0;
    if (numb2 >= 1000)
    {
        int numb0 = numb2;
        while(numb0 > 1000)
        {
            numb0 /= 10;
        }
        result = numb0 % 10;
    }
    else
    {
        result = numb2 % 10;
    }
    System.Console.WriteLine(numb2);
    Console.WriteLine($"цифра под индексом 2: {result}");
}
else
{
    Console.WriteLine("третей цифры нет");
}

// Console.WriteLine(numb2);
// Console.WriteLine($"цифра под индексом 2: {thirdNumb(numb2)}");

/// task 3

int numb3 = new Random().Next(1, 7);

string day(int numb3)
{ 
    if (numb3 == 6 || numb3 == 7)
    {
        return ("да");
    }
    else
    {   
        return("нет");
    }
}
Console.WriteLine(numb3);
Console.WriteLine($"выходной день ? {day(numb3)}");
