Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"Число: {number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}
