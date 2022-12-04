Console.Clear();
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if(day >= 0 && day <= 5)
{
    Console.WriteLine("Нет");
} else if(day >= 6 && day <= 7)
{
    Console.WriteLine("Да");
} else
{
    Console.WriteLine("Введите число от 1 до 7");
}
