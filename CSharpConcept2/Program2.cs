using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.Formule;

namespace CSharpConcept2
{
    public class Program2
    {
                   
      static void Main(string[] args)
        {
            Area objArea = new Area();
            int circleRadius = 10;
            double recLength = 20; double recWidth = 30;
            double triangleBase = 40; double triangleHeight = 50;


            Console.WriteLine(objArea.AreaOfCircle(circleRadius));
            Console.WriteLine(Area.AreaOfRectangle(recLength, recWidth));
            Console.WriteLine(Area.AreaOfTriangle(triangleBase, triangleHeight));
            Console.WriteLine(Area.GetAutherName());
        }

        //Area of Circle
        //Area of Rectangle
        //Area of Triangle.
        //Created Static moethods.
    }
}
