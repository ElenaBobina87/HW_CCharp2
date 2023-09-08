// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
System.Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num < 6)
    System.Console.WriteLine("День не выходной");
if (num == 6 || num == 7)
    System.Console.WriteLine("День выходной");
if (num < 1 || num > 7)
    System.Console.WriteLine("Вы ввели неверное число");