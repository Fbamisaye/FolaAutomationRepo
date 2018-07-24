using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolakescodingBasics.Interfacinginterfacse
{
    public class Grandinterfacecall :IParentinterface
    {
        private int eNum;
        private int _eNum;

        public void DisplayNumber(int aNum)
        {
            Console.WriteLine("Display {0} from Grandchildclass", aNum);
        }

        public void DisplayNumber(int bNum, int cNum)
        {
            Console.WriteLine(_eNum = bNum - cNum);
        }
    }
}
