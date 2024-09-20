using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeleniumConcept2
{
    class Overload
    { 
    public int x;
    public int y;

    public void add(int a)
    {
        x = a + 1;
    }

    public void add(int a, int b)
    {
        x = a + 2;
    }
}
class Overload_methods
{
    public static void Main(string[] args)
    {
        Overload obj = new Overload();
        int a = 0;
        obj.add(6);
        Console.WriteLine(obj.x);
    }

}
}
