using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics
{
   public  class Rectangle
   {
       public double he;
       public double lng;

       public Rectangle()
       {
           Console.WriteLine("This is a constructor"); 
       }

       public Rectangle(double l, double h)
       {
           //l = he;
           //h = lng;
       }


       public void RectangleArea(double height, double lenght)
       {
           double area = height * lenght;
           Console.WriteLine("Area of rectangle is: {0}", area);
       }

    }
}
