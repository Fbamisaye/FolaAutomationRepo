using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FolakescodingBasics.EXCEPTIONSERROR;

namespace FolakescodingBasics.Interfacinginterfacse
{
     public class Childinterfacecall: IParentinterface,IExtendedfamily
     {
         private int _dNum;

         public void DisplayNumber(int aNum)
         {
             try
             {
                 Console.WriteLine("Display {0} & {1} from childclass", aNum);
                throw new CustomErrors ("THIS WAS THROWN BY FOLA FROM THE CUSTOM CLASS");
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.StackTrace);
                // throw;
             }
             finally
             {
                 Console.WriteLine("FINALLY BLOCK SHOULD BE DISPLAYED");
             }
         }

         public void DisplayNumber(int bNum, int cNum)
         {
             Console.WriteLine(_dNum  = bNum - cNum);
         }

         public int RevealExtendedNumber(int fNum)
         {
             return fNum ;
         }
     }
}
