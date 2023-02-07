// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int a=Convert.ToInt32(Console.ReadLine());
if (a>99) System.Console.WriteLine($"{a/100%10}");
if (a<=99) System.Console.WriteLine("Нет третий цифры");
