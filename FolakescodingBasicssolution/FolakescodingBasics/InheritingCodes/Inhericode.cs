using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.InheritingCodes
{
     public class Inhericode
     {
         public string Kayname = "Kay";

         private int ChinweAge = 16;

         protected double DimejiScore = 100; 

         public void DeclareAge()
         {
             Console.WriteLine("Chinwe is: {0} years old",ChinweAge);
         }
     }
}
