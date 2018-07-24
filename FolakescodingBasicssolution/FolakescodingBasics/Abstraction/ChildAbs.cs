using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.Abstraction
{
    public abstract class ChildAbs:AbstractKnowlege 
    {
        public override void AddNumber(int numA, int numB)
        {
            numbersAdded = numA + numB;
        }

        
    }
}
