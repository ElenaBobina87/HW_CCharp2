//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000)
{
    int result=num/10%10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели неправильное число");
}