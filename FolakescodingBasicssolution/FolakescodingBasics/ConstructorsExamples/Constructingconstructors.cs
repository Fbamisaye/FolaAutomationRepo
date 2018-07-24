using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.ConstructorsExamples
{
         public  class Constructingconstructors
         {
             public int Age;
             public string Name;
             public int Feet;

             public Constructingconstructors()
             {
                 
             }

             public Constructingconstructors(int newAge, string newName, int newfeet )
             {
                 Console.WriteLine("My name is {0}, my age is {1} and and I have {2} feet", newName, newAge, newfeet); 
             }

             public void PrintDetails()
             {
                 Feet = 3;
                 Name = "Andre";
                 Age = 456;
                 Console.WriteLine("I am {0}. call me {1}. I have {2} feet",Age,Name, Feet  );
                 
        }


         }
}
