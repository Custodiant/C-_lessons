﻿// напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.Clear();

Console.WriteLine("Случайное трехзначное число: ");

int num = new Random().Next(100,1000);
int a = num / 100;
int c = num % 10;
int b = a * 10 + c;

Console.WriteLine($"Ваше число {num}, преобразовались в первая цифра {a} и последняя {c}, получилось {b}");