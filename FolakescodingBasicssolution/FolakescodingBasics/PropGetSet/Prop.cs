using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.PropGetSet
{
   public  class Prop
   {
       private string _hiddenVariable;

       //this setter is used to set the values of the variable
       public void SetHiddenVariable(string variableValue)
       {

           
           _hiddenVariable = variableValue;
           _hiddenVariable = _hiddenVariable + "is my name";
        }


        //This getter is used to return the value of the variable
       public string GetHiddenVariable()
       {
           _hiddenVariable = _hiddenVariable + "who am I";
           return _hiddenVariable;
       }

       public string ShowVariable { get; set; }
   }
}
