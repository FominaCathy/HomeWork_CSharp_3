// Задача 5. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. 
// На ввод подают номер месяца и год начала и конца.
// Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. 
// Если таких температур нет, сообщить, что определить не удалось.

class Program
{
    static void Main(string[] args) 
    { 
        //create point random
        Random rnd = new Random();
         
        int i = 0;
        int j = 0; //для сезонов
        int year_begin = 0;
        int year_end = 0;
        int month_begin = 0;
        int month_end = 0;
        int index_begin = 0;
        int index_end = 0;
        string[] season = {"весна", "лето", "осень", "зима"};

        int[] array_temp = new int [120]; // array temperature January 01 - december 10.
        Console.WriteLine("задан массив температур: январь 01 года по декабрь 10 года.");
        Console.Write("введите номер месяца начала периода: ");
        month_begin = int.Parse(Console.ReadLine());
        Console.Write("введите год (от 01 до 10) начала периода: ");
        year_begin = int.Parse(Console.ReadLine());
        Console.Write("введите номер месяца конца периода: ");
        month_end = int.Parse(Console.ReadLine());
        Console.Write("введите год (от 01 до 10) конца периода: ");
        year_end = int.Parse(Console.ReadLine());

        

        for (i = 0; i< array_temp.Length; i++) // заполнение массива случ числами
            array_temp[i] = rnd.Next(-45, 45); 

        // считаем индексы начала и конца массива по заданным временным рамкам
        index_begin = month_begin + (year_begin-1)*12-1;
        index_end = month_end + (year_end-1)*12 - 1;
 
        //убираем "хвостики" неполных сезонов в начале и конце заданного периода
        if ((index_begin +1)%3 != 0 ) index_begin = index_begin + (3 - (index_begin +1)%3);   
        index_end = index_end - (index_end + 2)%3;
        
        if (((index_end - index_begin) < 3)|(index_end < index_begin)) // проверяем период на его существование
            Console.WriteLine("Сезоны не определены");
        else   
            Average_Temp();


        void Average_Temp()
        {
            if (((index_begin == 2)|(index_begin-2)%12 == 0)) j = 0; // весна
            if (((index_begin == 5)|(index_begin-5)%12 == 0)) j = 1; //- лето
            if (((index_begin == 8)|(index_begin-8)%12 == 0)) j = 2; // - осень
            if (((index_begin == 11)|(index_begin-11)%12 == 0)) j = 3; // - зима

            Console.WriteLine(j);

            for (i=0; i<(index_end - index_begin); i++)
            {
                Console.WriteLine("средняя температура в сезон: " 
                + season[(j)%4] + " " + (1+(index_begin + i)/12) + " года = " + (array_temp[i]+array_temp[i+1]+array_temp[i+2])/3);
                i = i + 2;
                j++;
            }
        }
    }
}
