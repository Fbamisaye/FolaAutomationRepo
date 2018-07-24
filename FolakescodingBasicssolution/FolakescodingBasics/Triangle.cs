using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolakescodingBasics.InheritingCodes;

namespace FolakescodingBasics
{
    public  class Triangle: ParentClass 
    {


        // We want to create a more smarter method
        public double TriangleArea(double length, double breadth)
        {
            double trianglecalc = length * breadth;
            return trianglecalc;
            //Console.WriteLine(trianglecalc);
        }

        public Triangle(string stateName) : base(stateName)
        {

        }
    }
}
