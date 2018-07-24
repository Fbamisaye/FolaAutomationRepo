using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.InheritingCodes
{
    //this is known as the derived class
    public class CallParentDetails : ParentClass
    {
        private string _newAddress = "Ibadan State ";
        public CallParentDetails(string newstateName) : base(newstateName)
        {
            newstateName = _newAddress; 
            Console.WriteLine("I now live at {0}:, newstatename ");
        }

        public void callFromTheBaseClass()
        {
            numberTwo = 22;
            numberThree = 44;
            base.SetNumberTwo(7777);
            SetBothMethods();
        }
    }
}
