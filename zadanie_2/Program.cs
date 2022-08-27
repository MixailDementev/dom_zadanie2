// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;

if (number >= 100)
{
    System.Console.WriteLine($"Number = {number}; result = {result}");
}
else{
    System.Console.WriteLine($"Number = {number}; Третья цифра отсутствует");
}
