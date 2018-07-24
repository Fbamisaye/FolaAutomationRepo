using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.Abstraction
{
   public  class FinalAbstract : ChildAbs
    {
       public override void SubNumbers(int subA, int subB)
       {
           numbersSubstraced = subA - subB;
       }
    }
}
