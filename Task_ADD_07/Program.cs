// Задача 7. Из центра координат к точке А(x, y) проведён отрезок АО. 
// Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X.

class Program
{
    static void Main(string[] args) 
    { 
        //create point random
        Random rnd = new Random();
        double angle; 
        int Ax = rnd.Next(-10, 10); int Ay = rnd.Next(-10, 10);
        
        angle = (Math.Acos(Math.Abs(Ax)/(Math.Sqrt(Ax*Ax + Ay*Ay))))*180/Math.PI;

      
        Console.WriteLine("Точка А: ("+ Ax + ", " + Ay + ")");
        Console.WriteLine("Угол наклона отрезка: "+ string.Format("{0:f2}",angle));
    }
}

