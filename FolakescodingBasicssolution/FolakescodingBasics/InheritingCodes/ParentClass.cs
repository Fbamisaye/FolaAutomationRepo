using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.InheritingCodes
{
    //this is the base class
    //And is sometimes referred to as the Super class
   public class ParentClass
   {
       public string ParentName = "Dada";
       private int _parentAccountBalance = 1000000;
       protected string DaughterName = "Chinwe";
       private string _whereParentlive = "Edo";


        public ParentClass(string stateName)
        {
            stateName = _whereParentlive;
            Console.WriteLine("My parents live at {0}:", stateName);
        }
       // ======================================
       private int _numberOne;
       protected int numberTwo;
       public int numberThree;

       private void SetNumberOne(int alphaNum)
       {
           alphaNum = _numberOne;
           Console.WriteLine("alphaNum is {}", alphaNum);
       }

       protected void SetNumberTwo(int betaNum)
       {
           betaNum = numberTwo;
           Console.WriteLine("betaNum is {0}", betaNum );
       }

       public void SetBothMethods()
       {
           Console.WriteLine("The values of numberOne & numberTwo are {0} & {1}:",numberTwo, numberThree);
       }

   }
}
