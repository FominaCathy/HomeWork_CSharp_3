// Задача 1. + Задача 3
// На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

// Задача 3. Решить задачу 1 для n точек.

// решение сразу для N. для 3х точек - будет частный случай

class Program
{
    static void Main(string[] args) 
    { //алгоритм: находим ближайшую точку. затем от нее ищем следующую ближайшую уже к ней из непосещенных.
      // предполагаю, что на любом этапе нет равноудаленных точек.
        Console.Write("Введите номер четверти: ");
            int quarter = int.Parse(Console.ReadLine());
        Console.Write("Введите количество точек: ");
            int n = int.Parse(Console.ReadLine()) +1; //+1 для нулевой точки

        Random rnd = new Random();

        int[,] array = new int [2, n+1]; // точки
        int i;
        int index_min;
        double local_min;
        int temp_point; // index current point 

        List<int> PointList = new List<int>(); 

        // заполняем массив с учетом четверти

        array [0, 0] = 0;
        array [1, 0] = 0;

        for (i = 1; i < n; i++)
        {
            if ((quarter == 1)|(quarter == 4)) array [0, i] = rnd.Next(1, 10);
            else array [0, i] = - rnd.Next(1, 10);
            if ((quarter == 1)|(quarter == 2))  array [1, i] = rnd.Next(1, 10);
            else array [1, i] = -rnd.Next(1, 10);
            PointList.Add(i);
        }

        Console.WriteLine("Точка выхода О(0,0). Кратчайший путь по точкам: ");
        temp_point = 0; // стартуем с нулевой точки;

        while (PointList.Count > 0) 
        {
            local_min = Distance(PointList[0],temp_point);
            index_min = PointList[0];
                 for (i = 1; i < PointList.Count; i++)
                {   
                    if (Distance(PointList[i],temp_point) < local_min) 
                    {
                        local_min = Distance(PointList[i],temp_point);
                        index_min = PointList[i];
                    }
                }
            Console.Write("- (" + array [0, index_min] + "," + array [1, index_min] + ") ");
            
            PointList.Remove(index_min);
            temp_point = index_min;
        }
   
        double Distance(int i, int j) //расстояние между i и j точками
        {            
            return Math.Sqrt((array[0, i]-array[0, j])*(array[0, i]-array[0, j])+(array[1, i]-array[1, j])*(array[1, i]-array[1, j]));
        }
    }

}
