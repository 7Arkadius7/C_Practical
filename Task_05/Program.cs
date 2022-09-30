Console.Clear();
Console.WriteLine("Пожалуйста, ввведите число");

int numberA = Convert.ToInt32(Console.ReadLine());
int counter = -numberA;
while (counter <= numberA)
{
    Console.Write($"{counter} ");
    counter++;
}