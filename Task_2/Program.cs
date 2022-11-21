Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
    Console.WriteLine($"{numA} больше чем {numB}");
}
else if (numB>numA)
{
    Console.WriteLine($"{numB} больше чем {numA}");
    
 }

 else 
 {
    Console.WriteLine($"{numB} равно {numA}");
 }