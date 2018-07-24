using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics
{

   public class Square

       
   {
       //these variables have been declared outside any methods
       public double Length = 2.6;
       public double Breadth = 5.6;

       public void GetArea()
       {
           double squareArea = Length*Breadth;
           Console.WriteLine("Area of square is {0}", squareArea); 
       }

       public double LengthRoot()
       {
           double rootlenght = Length + Length;
           return rootlenght;
       }
   }

}
