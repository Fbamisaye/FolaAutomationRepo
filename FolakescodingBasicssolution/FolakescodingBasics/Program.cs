using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using FolakescodingBasics.Abstraction;
using FolakescodingBasics.ConstructorsExamples;
using FolakescodingBasics.InheritingCodes;
using FolakescodingBasics.Interfacinginterfacse;
using FolakescodingBasics.PropGetSet;
using FolakescodingBasics.StaticVariables;

namespace FolakescodingBasics
{
   public class Program
    {
       public static void Main(string[] args)
       {
            Prop prop = new Prop();
            prop.SetHiddenVariable("Andre");
            string revealVariable = prop.GetHiddenVariable();
           Console.WriteLine(revealVariable);


            //var showProp = new Prop {ShowVariable = "Andre Dada"};
            //Console.WriteLine(showProp.ShowVariable);

         Console.WriteLine();
         Console.WriteLine("Press any key to leave the console window");
         Console.ReadKey();
        
       }
    }
}