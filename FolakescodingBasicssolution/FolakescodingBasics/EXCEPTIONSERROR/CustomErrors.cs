using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.EXCEPTIONSERROR
{
   public  class CustomErrors : Exception
    {
       public CustomErrors(string errorMessage) : base(errorMessage)
       {
           Console.WriteLine("THIS IS FROM THE CUSTOME ERROR CLASS");
       }
    }
}
