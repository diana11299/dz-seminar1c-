﻿//Задача 4:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("imput a first number' ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput a second number' ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput a third number' ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine(max);
