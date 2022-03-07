// Задача 1. 
// На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

class Program
{
    static void Main(string[] args) 
    { //алгоритм Литтла
        Console.Write("Введите номер четверти: ");
        int quarter = int.Parse(Console.ReadLine());

        //create 3 point random
        Random rnd = new Random();
        
        int Ax = rnd.Next(0, 10); int Ay = rnd.Next(0, 10);
        int Bx = rnd.Next(0, 10); int By = rnd.Next(0, 10);
        int Cx = rnd.Next(0, 10); int Cy = rnd.Next(0, 10);

        // добавить позиционирование в четвертях (скоретировать минусами)

        // посчитать маршруты для таблицы

        


    }
}