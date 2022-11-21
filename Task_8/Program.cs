Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int k = 1;

while (k<n+1)

{
   if (k%2==0)
    {
        Console.Write($"{k} ");
        k++;
    }
    else
    {
        k++;
    }
}
Console.WriteLine();