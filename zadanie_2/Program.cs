// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int index = 3;
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    int length = (int)Math.Log10(number) + 1;
    int numberPow = (int)Math.Pow(10, length - index);
    int result = number / numberPow % 10;

    System.Console.WriteLine($"{index} цифра в числе {number} = {result}");
}
else
{
    System.Console.WriteLine($" У числа нет трех цифр");
}
