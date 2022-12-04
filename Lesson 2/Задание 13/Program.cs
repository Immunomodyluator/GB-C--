Console.Clear();
Console.WriteLine("Введите число");
string number = Console.ReadLine();
char[] dig_mas = new char[number.Length];
if(number.Length <=2)
{
    Console.WriteLine("третьей цифры нет");
} 
else {
    for (int i = 0; i < number.Length; i++)
    {
        dig_mas[i] = number[i];
    }
    Console.WriteLine("Третье число : " + dig_mas[2]);
}
