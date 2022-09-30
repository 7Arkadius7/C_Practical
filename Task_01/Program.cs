Console.Clear();
Console.WriteLine("Пожалуйста, ввведите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, ввведите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());
int squareB = numberB * numberB;

if (numberA == squareB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else 
{
    Console.WriteLine($"Число {numberA} НЕ является квадратом числа {numberB}");
}
