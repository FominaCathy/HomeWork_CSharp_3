//Задача 4. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).



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
        double Ox = 0; //точка пересечения 
        double Oy = 0;

        int vector1 = Mult_Vectors(Dx-Cx, Dy-Cy, Ax-Cx, Ay-Cy); //CD * CA     
        int vector2 = Mult_Vectors(Dx-Cx, Dy-Cy, Bx-Cx, By-Cy); //CD * CB
        int vector3 = Mult_Vectors(Bx-Ax, By-Ay, Cx-Ax, Cy-Ay); //AB * AC
        int vector4 = Mult_Vectors(Bx-Ax, By-Ay, Dx-Ax, Dy-Ay); //AB * AD

       
        if ((vector1*vector2 < 0)&&(vector3*vector4 < 0))
        {
            Gen_Point();
            Location_Point();
        }
        else
            Console.Write("отрезки НЕ пересекаются");
           

         
        int Mult_Vectors (int x1, int y1, int x2, int y2)
        {
            int mult = x1*y2 - y1*x2;
            return mult;
        }

        void Gen_Point ()
        {   //проверка если один из отрезков параллен оси (или оба) 
            if (Ax == Bx) //первый отрезок || oy
            {
                Ox = Ax;
                if (Cy == Dy) Oy = Dy; // второй отрезок || ox
                else Oy = (-(Cy*Dx-Cx*Dy)-(Dy-Cy)*Ox)/(Cx-Dx);
            }
            else if (Cx == Dx) //второй отрезок || oy
            {
                Ox = Cx;
                if (Ay == By) Oy = By; // первый отрезок || ox
                else Oy = (-(Ay*Bx-Ax*By)-(By-Ay)*Ox)/(Ax-Bx);
            }
            else 
            {
                Ox =-((Ay*Bx-Ax*By)*(Cx-Dx)-(Cy*Dx-Cx*Dy)*(Ax-Bx))/((By-Ay)*(Cx-Dx)-(Ax-Bx)*(Dy-Cy));
                Oy = (-(Ay*Bx-Ax*By)-(By-Ay)*Ox)/(Ax-Bx);
            }
        
        }

        void Location_Point () // quarter
        {

            if ((Ox >=0)&&(Oy>=0)) Console.Write("Точка пересечения отрезков: х = " + Ox + ", у= " + Oy + " находится в 1 четверти");
            if ((Ox <0)&&(Oy>0)) Console.Write("Точка пересечения отрезков: х = " + Ox + ", у= " + Oy + " находится в 2 четверти");
            if ((Ox >0)&&(Oy<0)) Console.Write("Точка пересечения отрезков: х = " + Ox + ", у= " + Oy + " находится в 3 четверти");
            if ((Ox <0)&&(Oy<0)) Console.Write("Точка пересечения отрезков: х = " + Ox + ", у= " + Oy + " находится в 4 четверти");


        }

    }


}
