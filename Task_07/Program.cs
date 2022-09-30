Console.Clear();
Console.WriteLine("Пожалуйста, ввведите число");
int num = Convert.ToInt32(Console.ReadLine());
int res = num %  10;
Console.WriteLine($"Число {res} является последней цифрой числа {num}");