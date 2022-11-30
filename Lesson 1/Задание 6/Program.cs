Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Четное" : "Нечетное");
