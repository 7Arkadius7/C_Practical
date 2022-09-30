Console.Clear();
Console.WriteLine("Пожалуйста, ввведите число");
int num = Convert.ToInt32(Console.ReadLine());
int res = num %  2;
if (res == 0)
{
    Console.WriteLine("Да");
}
else
Console.WriteLine("Нет");