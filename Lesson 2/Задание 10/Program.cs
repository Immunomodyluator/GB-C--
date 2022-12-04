Console.Clear();
Console.WriteLine("Введите число");
string number = Console.ReadLine();
char[] dig_mas = new char[number.Length];
for (int i = 0; i < number.Length; i++)
{
    dig_mas[i] = number[i];
}
Console.WriteLine("Второе число : " + dig_mas[1]);