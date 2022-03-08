//Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?


class Program
{
    static void Main(string[] args) 
    {
         //create 4 point random
        Random rnd = new Random();
        
        int Ax = rnd.Next(-10, 10); 
        int Ay = rnd.Next(-10, 10);
        int Bx = rnd.Next(-10, 10); 
        int By = rnd.Next(-10, 10);
        
        int Cx = rnd.Next(-10, 10); 
        int Cy = rnd.Next(-10, 10);
        int Dx = rnd.Next(-10, 10); 
        int Dy = rnd.Next(-10, 10);

        int vector1 = Mult_Vectors(Dx-Cx, Dy-Cy, Ax-Cx, Ay-Cy); //CD * CA     
        int vector2 = Mult_Vectors(Dx-Cx, Dy-Cy, Bx-Cx, By-Cy); //CD * CB
        int vector3 = Mult_Vectors(Bx-Ax, By-Ay, Cx-Ax, Cy-Ay); //AB * AC
        int vector4 = Mult_Vectors(Bx-Ax, By-Ay, Dx-Ax, Dy-Ay); //AB * AD

       
         if ((vector1*vector2 < 0)&&(vector3*vector4 < 0))
            Console.Write("отрезки пересекаются");
        else
            Console.Write("отрезки НЕ пересекаются");
              

         
    }
    static int Mult_Vectors (int x1, int y1, int x2, int y2)
    {
        int mult = x1*y2 - y1*x2;
        return mult;
    }

}