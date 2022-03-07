// Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Координаты первой точки: ");
        Console.Write("Введите x: "); 
        int ax = int.Parse(Console.ReadLine());
        Console.Write("Введите y: "); 
        int ay = int.Parse(Console.ReadLine());
        Console.Write("Введите z: "); 
        int az = int.Parse(Console.ReadLine());

        Console.WriteLine("Координаты второй точки: ");
        Console.Write("Введите x: "); 
        int bx = int.Parse(Console.ReadLine());
        Console.Write("Введите y: "); 
        int by = int.Parse(Console.ReadLine());
        Console.Write("Введите z: "); 
        int bz = int.Parse(Console.ReadLine());

        double distance = Math.Sqrt((ax-bx)*(ax-bx) +(ay-by)*(ay-by)+(az-bz)*(az-bz));

        Console.WriteLine("Длина отрезка = "+ string.Format("{0:f2}",distance));
    }
}


      
     
    
