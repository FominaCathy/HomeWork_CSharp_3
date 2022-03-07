//Задача 6. На вход подаётся число n > 4, указывающее длину пароля. 
//Создайте метод, генерирующий пароль заданной длины. 
//В пароле обязательно использовать цифру, букву и специальный знак.


class Program
{
    static void Main(string[] args) 
    {
        Random rnd = new Random();
        int temp_rnd;
        int i = 3;
        Boolean symbol = false; // коды (33, 48)
        Boolean number = false; // коды (48, 58)
        Boolean smoll_letter = false; // коды (97, 123);
    

        string parol = "";

        Console.Write("Введите длину пароля более 4х символов: ");
        int n = int.Parse(Console.ReadLine());
        
        General_Parol();
        
        Console.WriteLine("Пароль: "+ parol);
        Console.WriteLine(symbol + " "+ number + "" + smoll_letter);

        void General_Parol()
        {
            while (parol.Length < n-i) //цикл для заполнения пароля i - это место в конце для невошедших символов
            {// выбираю случ образом цифру либо символ либо букву
               temp_rnd = rnd.Next(33,123);
               if ((temp_rnd < 58) || (temp_rnd > 97)) // от 58 до 97 мне символы не нужны
                {
                   parol = parol + (char)(temp_rnd);
                    // если символ вошел - ставлю истина и уменьшаю пустое место в конце на невошедшие символы
                    if ((temp_rnd >= 33) && (temp_rnd < 48)&&(symbol == false)) {symbol = true; i--;} 
                    if ((temp_rnd >= 48) && (temp_rnd < 58)&&(number == false)) {number = true; i--;}
                    if ((temp_rnd >= 97) && (temp_rnd < 123)&&(smoll_letter == false)) {smoll_letter = true; i--;}
                }
                
            }
            // добавляю те типы которые не вошли
            if (symbol == false) parol = parol + (char)(rnd.Next(33, 48));
            if (number == false) parol = parol + (char)(rnd.Next(48, 58));
            if (smoll_letter == false) parol = parol + (char)(rnd.Next(97, 123));

        }
    }
}
