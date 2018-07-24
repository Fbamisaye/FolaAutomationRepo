using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.Abstraction
{
   public  abstract class AbstractKnowlege
    {
        /*
         * 1.This is a special type of class whuch is only use for inheritance
         * 2.An object of an Abstract can't be created
         * 3.An Abstract class can have Abstract methods
         * 4.Abstract methods are those methods whose implementation is defined
         * by the derived class
         */

       private int _numberOne;
       private int _numberTwo;
       protected int numbersAdded = 0;
       protected int numbersSubstraced = 0;

        //THIS IS A STARDARD METHOD
       public void DisplayTotalSum()
       {

           Console.WriteLine("The addition of both numbers is: {0}", numbersAdded );
       }

       public void DisplayTotalSub()
       {
           Console.WriteLine("The substraction of both numbers is : {0}", numbersSubstraced);
       }
        //this is an abstract method
       public abstract void AddNumber(int numA, int numB);

        //this is another abstract method
       public abstract void SubNumbers(int subA, int subB);

    }
}
