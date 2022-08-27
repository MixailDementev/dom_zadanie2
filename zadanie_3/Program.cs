// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 7)
{
    if(number >= 1 && number <= 5)
    {
        System.Console.WriteLine("Будни");
        break;
    }
    else{
        System.Console.WriteLine("Выходной");
        break;
    }
}    
    