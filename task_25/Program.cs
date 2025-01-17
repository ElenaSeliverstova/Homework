﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int cycle(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result *= number;
    }
    return result;
}
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write(numA + " ^ " + numB + " = " + cycle(numA, numB));
