//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

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

void Task02()
{
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine("Данная программа определяет возраст человека на момент 1 июля 2022 года по введённой дате");
    Console.WriteLine(" ");//пустая строка для красоты

    //блок ввода данных
    Console.Write("Введите год рождения: ");
    int year = Convert.ToInt32(Console.ReadLine()); // вводим год
    Console.Write("Введите месяц рождения: ");
    int month = Convert.ToInt32(Console.ReadLine()); // вводим месяц
    Console.Write("Введите день рождения: ");
    int day = Convert.ToInt32(Console.ReadLine()); // вводим день
    DateTime Birthday = new DateTime(year, month, day);
    Console.WriteLine("Вы ввели дату: " + Birthday.ToShortDateString());
    DateTime Currentday = new DateTime(2022, 7, 1);
    Console.WriteLine("Проверяем возраст на дату: " + Currentday.ToShortDateString());

    //блок расчёта

    TimeSpan answer = Currentday.Subtract(Birthday);
    Console.WriteLine("Ответ: возраст в годах: " + Math.Round((answer.TotalDays / 365.25), 0));

    Console.WriteLine(" ");//пустая строка для красоты
}



//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.


void Task03()
{
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine("Данная программа определяет размер вклада 1000 рублей под 1,5 % месячных через n месяцев");
    Console.WriteLine(" ");//пустая строка для красоты
    double balance = 1000;
    double percent = 0.015;
    Console.Write("Введите колличество месяцев: ");
    int months = Convert.ToInt32(Console.ReadLine());
    Console.Write("Колличество месяцев: " + months + ". " + balance + " рублей превратится в ");
    while (months > 0)
    {
        balance = balance + balance * percent;
        months--;
    };
    Console.Write(Math.Round(balance, 2) + " рублей."); //выводим сумму с округлением до копеек
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine(" ");//пустая строка для красоты

};

//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.


void Task04()
{
    Console.WriteLine(" ");//пустая строка для красоты
    Console.WriteLine("Данная программа определяет минимальнае или максимальная цифра находится левее во введённом числе");
    Console.WriteLine(" ");//пустая строка для красоты
    Console.Write("Введите натуральное число без повторяющихся цифр: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int indexMax = 0;//месторасположение максимального элемента
    int indexMin = 0;//месторасположение минимального элемента
    int max = number % 10;
    int min = max;
    if (number < 10)
    {
        Console.WriteLine("Число состоит из одной цифры. Максимальное и минимальное значение находятся на одной позиции");
    }
    else
    {
        number /= 10;
        int index = 0;
        int curentnumber = 0;
        while (number > 0) //проходимся по всему числу (отсекаем каждую цифру при помощи деления на 10)
        {
            curentnumber = number % 10;
            if (curentnumber > max)
            {
                max = curentnumber;
                indexMax = index;
            }
            else if (curentnumber < min)
            {
                min = curentnumber;
                indexMin = index;
            }
            number /= 10;
            index++;
        }
        if (indexMax > indexMin)
        {
            Console.WriteLine("Максимальная цифра находится левее минимальной");
        }
        else
        {
            Console.WriteLine("Минимальная цифра находится левее максимальной");
        }
    }
    Console.WriteLine(" ");//пустая строка для красоты
}


//Запуск заданий. При желании, любое можно закомментировать.
Task01();
Task02();
Task03();
Task04();