Console.Clear();
Console.WriteLine("Пожалуйста, ввведите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, ввведите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} больше {numberA}");
}