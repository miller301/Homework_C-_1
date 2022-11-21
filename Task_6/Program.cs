Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n%2==0)
{
    Console.WriteLine($"{n} является четным числом");
}
else
{
    Console.WriteLine($"{n} не является четным числом");
}