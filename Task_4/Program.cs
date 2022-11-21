Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA>numB)
{
    Console.WriteLine($"{numA} максимальное");
}
else if (numA>numC)
{
    Console.WriteLine($"{numA} максимальное");
}
else if (numC>numB)
{
    Console.WriteLine($"{numC} максимальное");
}
else
{
    Console.WriteLine($"{numB} максимальное");
}
