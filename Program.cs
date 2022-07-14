﻿//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

void Task01()
{
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine("Данная программа определяет равнобедренность треугольника с введёнными сторонами");
    Console.WriteLine(" ");//пустая строка для красоты
    Console.Write("Введите длинну стороны a: ");
    int a = Convert.ToInt32(Console.ReadLine());// вводится длинна стороны a треугольника
    Console.Write("Введите длинну стороны b: ");
    int b = Convert.ToInt32(Console.ReadLine());// вводится длинна стороны b треугольника
    Console.Write("Введите длинну стороны c: ");
    int c = Convert.ToInt32(Console.ReadLine());// вводится длинна стороны c треугольника


    if (a + b > c && a + c > b && b + c > a) // проверка на возможность смыкания строн (треугольник ли перед нами)
    {
        if (a == b || b == c || c == a)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        else
        {
            Console.WriteLine("Треугольник не равнобедренный");
        }
    }
    else
    {
        Console.WriteLine("Это не треугольник. Стороны не смыкаются");
    }
    Console.WriteLine(" ");//пустая строка для красоты
}

//Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.





//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.


void Task03()
{
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine("Данная программа определяет размер вклада 1000 рублей под 1,5 % месячных через n месяцев");
    Console.WriteLine(" ");//пустая строка для красоты
    double balance = 1000;
    double percent = 0.015;
    Console.Write("Введите колличество месяцев: ");
    int mounths = Convert.ToInt32(Console.ReadLine());
    Console.Write("Через " + mounths + " месяцев " + balance + " рублей превратится в ");
    while (mounths > 0)
    {
        balance = balance + balance * percent;
        mounths--;
    };
    Console.Write(Math.Round(balance, 2) + " рублей.");
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine(" ");//пустая строка для красоты

};

//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.


//Запуск заданий. При желании, любое можно закомментировать.
//Task01();
//Task02();
//Task03();
//Task04();