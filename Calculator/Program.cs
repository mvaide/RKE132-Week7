﻿Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());    


switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subrtracton(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operatior.");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subrtracton(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}