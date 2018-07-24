using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.StaticVariables
{
   public  class StaticMethods
   {
        //this is a static variable called "Age
       public static string Animal;

        //non static variable
       public int Boy;

       public void SetAnimalName(string newAnimal)
       {
           Animal = newAnimal;

       }

       public void GetAnimalName()
       {
           Console.WriteLine("The animal name is {0}", Animal);
       }
   }
}
