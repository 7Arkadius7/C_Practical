Console.Clear();

Console.WriteLine("Пожалуйста, ввведите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, ввведите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, ввведите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.Write($"{max} ");