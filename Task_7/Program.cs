Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99)
{
    k = number;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;

    }
Console.WriteLine($"Третье число от начала {d}");
}
else
{
    Console.WriteLine("Число имеет меньше трех цифр");
}
