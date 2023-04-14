//int inputX(string message)
//{
 //   Console.Write(message);
 //   int input = Convert.ToInt32(Console.ReadLine());
 //   return input;
//}
//int inputY(string message)
//{
  //  Console.Write(message);
   // int input = Convert.ToInt32(Console.ReadLine());
   // return input;
//}
//int numberX = inputX("Введите Х: ");
//int numberY = inputY("Введите Y: ");
// if (numberX == 0 || numberY == 0)
  //  {
    //    Console.WriteLine("Вы не услышали условия поэтому Вы находитесь в начале начале");
  //  }
//else if ( numberX > 0 && numberY  > 0)
  //  {
      //  Console.WriteLine($"При координатах x = {numberX} и y = {numberY} ваша точка находится в плоскости 1 ");
   // }
//else if ( numberX < 0 && numberY > 0)
//        {
//             Console.WriteLine($"При координатах x = {numberX} и y = {numberY} ваша точка находится в плоскости 2 ");
//        }
//else if ( numberX < 0  && numberY < 0)
 //       {
 //           Console.WriteLine($"При координатах x = {numberX} и y = {numberY} ваша точка находится в плоскости 3 ");
 //       }
//else if (numberX > 0 && numberY < 0)
 //       {
 //           Console.WriteLine($"При координатах x = {numberX} и y = {numberY} ваша точка находится в плоскости 4 ");
  //      }
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// # Пример:
// # - A (3,6); B (2,1) -> 5,09
// # - A (7,-5); B (1,-1) -> 7,21
// Console.WriteLine("Вводим координаты А(xА, yА)");
// Console.Write("xA ");
// int xA = int.Parse(Console.ReadLine());

// Console.Write("yA ");
// int yA = int.Parse(Console.ReadLine());

// Console.WriteLine("Вводим координаты B(xB, yB)");

// Console.Write("xB ");
// int xB = int.Parse(Console.ReadLine());

// Console.Write("yB ");
// int yB = int.Parse(Console.ReadLine());

// double result = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
// Console.WriteLine($"Расстояние между двумя точками {result}");
int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. ");
    Console.WriteLine("2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    if (programm > 3)
    {
        Console.WriteLine($"Извините, такой задачи  {programm} нету, введите dotnet run повторно");
    }
    switch (programm)
    {
        case 1:
            Console.Write("Ввведите число: ");
            string number = Console.ReadLine();
            int input = Convert.ToInt32(number);
            int len = number.Length;
            if (len == 5)
            {
                if (number[0] == number[4] && number[1] == number[3])
                {
                    Console.WriteLine($"Данное число является палиндромом {number}");
                }
                else
                {
                    Console.WriteLine($"Данное число  не является палиндромом {number}");
                }
            }
            else if (len > 5 || len < 5)
            {
                Console.WriteLine($"Ошибка: число больше или меньше 5 значений  {number}");
            }
            break;
        case 2:
            double x1 = Read_double("Введите координату X первой точки: ");
            double y1 = Read_double("Введите координату Y первой точки: ");
            double z1 = Read_double("Введите координату Z первой точки: ");
            double x2 = Read_double("Введите координату X второй точки: ");
            double y2 = Read_double("Введите координату Y второй точки: ");
            double z2 = Read_double("Введите координату Z второй точки: ");

            double A = Math.Pow(x2 - x1, 2);
            double B = Math.Pow(y2 - y1, 2);
            double C = Math.Pow(z1 - z2, 2);

            double length = Math.Sqrt(A + B  + C );
            Console.WriteLine($"Длинна отрезка {length:f2}");

            // Функция ввода сообщения
            double Read_double(string message)
            {
                Console.Write(message);
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }
            break;
        case 3:
            int numbers = ReadInt("Введите число: ");
            for (int i = 1; i <= numbers; i++)
            {
                double j = Math.Pow(i, 3);
                Console.Write($"{j}");
            }
            // Функция ввода сообщения
            int ReadInt(string message)
            {
                Console.Write(message);
                int num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            break;
 
        default:
             begin = false;
             break;

    }
}