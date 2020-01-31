# ***Emeka Mkpume***
## **ISTA 220  Exercise 1**
### *January 17, 2020*


```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nPart 1, Calculate the circumference of a circle.");
            //the circumference of a circle is 2 * Radius * PI//
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            Console.WriteLine("\nPart 2, Calculate the Area of a circle: ");
            //the area of a circle is PI * Radius * Radius//
            Console.Write("Enter an integer for the radius: ");
            string strradiuss= Console.ReadLine();
            int intradiuss = int.Parse(strradiuss);
            double Area = Math.PI * intradiuss * intradiuss;
            Console.WriteLine($"The Area is {Area}");

            Console.WriteLine("\nPart 3, Calculate the Volume of a Hemisphere.");
            //the volume of a hemisphere is (4/6) * PI * Radius * Radius * Radius//
            Console.Write("Enter an integer for the radius: ");
            string strradiusss = Console.ReadLine();
            int intradiusss = int.Parse(strradiusss);
            double Hemisphere = (0.6667) * Math.PI * intradiusss * intradiusss * intradiusss;
            Console.WriteLine($"The volume of the Hemisphere is {Hemisphere}");

            Console.WriteLine("\nPart 4, Calculate the Area of a triangle.");
            //the area of a triangle given sides a, b, and c,  is Math.SQRT(p(p-a)(p-b)(p-c))//
            //where p is p = (1/2) * (a+b+c) //
            Console.Write("Enter an integer for side a: ");
            string strside_a = Console.ReadLine();
            int intsidea = int.Parse(strside_a);
            Console.Write("Enter an integer for side b: ");
            string strside_b = Console.ReadLine();
            int intsideb = int.Parse(strside_b);
            Console.Write("Enter an integer for side c: ");
            string strside_c = Console.ReadLine();
            int intsidec = int.Parse(strside_c);
            int intP = (intsidea + intsideb + intsidec) / 2;
            int intRyan = intP * (intP - intsidea) * (intP - intsideb) * (intP - intsidec);
            double AreaofTriangle = Math.Sqrt(intRyan);
            Console.WriteLine($"The Area of the triangle is {AreaofTriangle}");

            Console.WriteLine("\nPart 5, solving a quadratic equation.");
            //a quadratic equation has the general form ax*x + b*x + c = 0//
            //a, b, and c are the coeffient of the quadratic form ax*x + b*x + c//
            //To solve for x, use the quadratic formula. There are 2 possible results.//
            //where the positive value of x is (-b - MathSqrt(b*b - (4*a*c))/2*a//
            //where the negative value of x is (-b - MathSqrt(b*b - (4*a*c))/2*a//
            Console.Write("Enter an integer for a: ");
            string stra = Console.ReadLine();
            int inta = int.Parse(stra);
            Console.Write("Enter an integer for b: ");
            string strb = Console.ReadLine();
            int intb = int.Parse(strb);
            Console.Write("Enter an integer for c: ");
            string strc = Console.ReadLine();
            int intc = int.Parse(strc);
            int intG = inta * 2;
            int intA = (intb * intb);
            int intB = (4 * inta * intc);
            int intC = (intA - intB);
            double intD = Math.Sqrt(intC);
            double intE = -(intb + intD)/intG;
            double intF = -(intb - intD)/intG;
            Console.WriteLine($"The Positive value of x is  {intF}");
            Console.WriteLine($"The Negative value of x is {intE}");
            Console.ReadLine();


        }
    }
}
```
