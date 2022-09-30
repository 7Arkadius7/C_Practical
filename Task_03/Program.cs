Console.Clear();
Console.WriteLine("Пожалуйста, ввведите число от 1 до 7");

int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA == 1) Console.WriteLine("Данному числу соответствует понедельник");
else if (numberA == 2) Console.WriteLine("Данному числу соответствует вторник");
else if (numberA == 3) Console.WriteLine("Данному числу соответствует среда");
else if (numberA == 4) Console.WriteLine("Данному числу соответствует четверг");
else if (numberA == 5) Console.WriteLine("Данному числу соответствует пятница");
else if (numberA == 6) Console.WriteLine("Данному числу соответствует суббота");
else if (numberA == 7) Console.WriteLine("Данному числу соответствует воскресенье");
else Console.WriteLine("Вы ввели не корректное число");
