// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*
int number  = 322;
    if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число кратно и 7, и 23.");
        }
        else if (number % 7 == 0)
        {
            Console.WriteLine("Число кратно только 7.");
        }
        else if (number % 23 == 0)
        {
            Console.WriteLine("Число кратно только 23.");
        }
        else
        {
            Console.WriteLine("Число не кратно ни 7, ни 23.");
        }
*/

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/*
int x = 4;
int y = -2;
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"Точка находится в I четверти плоскости");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine($"Точка находится в II четверти плоскости");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine($"Точка находится в III четверти плоскости");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine($"Точка находится в IV четверти плоскости");
    }
*/

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int number = 96;
int firstDigit = number / 10;
int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Найбольшая цифра из {number} это:{firstDigit}");
    }
    else
    {
        Console.WriteLine($"Найбольшая цифра из {number} это:{secondDigit}");
    }
*/    

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

string N = "9542";

for (int i=0; i < N.Length; i++){
    Console.Write(N[i]);
    if (i < N.Length-1){
         Console.Write(",");
    }
}
