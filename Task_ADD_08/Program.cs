// Задача 8. Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие число 3. 
// Вывести в консоль новый массив и количество удалённых элементов.


class Program
{
    static void Main(string[] args) 
    { 
        int i = 0;
        int j = 0;
        
        int[] array = new int [100]; //{3,2,3,3,2,2,8,6,3}; example array

        Random rnd = new Random();
        for (i = 0; i< array.Length; i++) // заполнение массива случ числами
            array[i] = rnd.Next(1, 101); 
        Console.Write("исходный массив: ");

        for(i = 0; i< array.Length; i++) Console.Write(array[i] + ", "); //печать массива
        Console.WriteLine();

        for (i = 0; i< array.Length; i++) //ищем и сдвигаем
        {   
            if (array[i] != 3)
            {
                if (j != i) array[j] = array[i];
                j++;
            }
        }

        Console.WriteLine ("Удалено элементов: " + (array.Length -j) );
        for(i = j; i< array.Length; i++) array[i] = 0;

        Console.Write("Новый массив: ");
        for(i = 0; i< array.Length; i++) Console.Write(array[i] + ", "); //печать массива
    }
}

