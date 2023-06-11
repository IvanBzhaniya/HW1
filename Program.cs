/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}

//программа работает, но непонятно как быть если на входе числа одинаковые




Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximum;


if (number1 > number2)
{
    maximum = number1;
}
else
{
    maximum = number2;
}

if (maximum > number3)
{
    Console.WriteLine("max = " + maximum);
}
else
{
    Console.WriteLine("max = " + number3);
}


Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Enter number: ");
int number  = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 2;

if (ostatok != 0)
{
    Console.WriteLine("нечетное");
}
else
{
    Console.WriteLine("четное");
}



Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Enter number: ");
int number  = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number > 1)
{
    while(count <= number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}

