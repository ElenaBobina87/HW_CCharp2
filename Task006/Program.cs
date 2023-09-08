// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 && num > -100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int result = num % 10;
    if (result < 0)
    {
        result = result*-1;
    }
    System.Console.WriteLine(result);
}