// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();
        while (number.Length != 5)
        {
            Console.Write("Введите пятизначное число: ");
            number = Console.ReadLine();
        }
        if ((number[4]==number[0])&&(number[3]==number[1]))
            Console.Write("Данное пятизначное число: "+ number+ " явлается полиндромом");
        else 
            Console.Write("Данное пятизначное число: "+ number+ " НЕ полиндром");

    }
}
