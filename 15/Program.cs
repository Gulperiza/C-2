// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число:");
double a=Convert.ToDouble(Console.ReadLine());
if(a==1) System.Console.WriteLine($"Сегодня ПОНЕДЕЛЬНИК, а значит не выходной");
if(a==2) System.Console.WriteLine($"Сегодня ВТОРНИК, а значит не выходной");
if(a==3) System.Console.WriteLine($"Сегодня СРЕДА, а значит не выходной");
if(a==4) System.Console.WriteLine($"Сегодня ЧЕТВЕРГ, а значит не выходной");
if(a==5) System.Console.WriteLine($"Сегодня ПЯТНИЦА, а значит не выходной");
if(a==6) System.Console.WriteLine($"Сегодня СУББОТА, а значит выходной");
if(a==7) System.Console.WriteLine($"Сегодня ВОСКРЕСЕНЬЕ,а значит выходной");
