// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите число N: ");
        int nums = int.Parse(Console.ReadLine());

        Console.Write("Таблица кубов числа " + nums + ": 1");
        for (int i =2; i <= nums; i++)
            Console.Write(", " + i*i*i);
    }
}
        


