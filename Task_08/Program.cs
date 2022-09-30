Console.Clear();
Console.WriteLine("Пожалуйста, ввведите число");

int numberA = Convert.ToInt32(Console.ReadLine());
int counter = 2;
while (counter <= numberA)
{
        Console.Write($"{counter} ");
        counter = counter + 2;
}
