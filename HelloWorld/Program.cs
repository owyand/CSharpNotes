
//these are classes imported from different namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


//all the classes in this namespace have access to eachother
namespace CSharpNotes
{
    internal class Program
    {
        //Main must be capital
        static void Main(string[] args)
        {
            //-+2billion
            //local identifiers use camelCase
            int number = 200;

            //consts must have their value set
            //consts use PascalCase
            const float Pi = 3.14f;
            Console.WriteLine(number + Pi);

            /*primative types
             * byte
             * short
             * int
             * long
             * float   - (f)
             * double  - default by the compiler
             * decimal - most precision (m)
             * char
             * bool
             * 
             * non-primative types
             * String
             * Array
             * Enum
             * Class
             * 
             * 
             * overflowing is when it wraps around
             * - no overflow checking in C#
             */

            //never ever really used but possible
            //throws an error when overflow is detected
            //checked
            //{
            //    byte num = 255;
            //    num = (byte)(num + 1);
            //}

            Console.WriteLine(number);

            byte law = 2;
            int count = 10;
            float totalPrice = 20.95f;
            string firstName = "Mosh";
            bool isWorking = false;
            char character = 'A';

            //C# detects the value - will assume integral is of type integer
            var law2 = 2;

            Console.WriteLine(law);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(character);

            //formatted string 0 is first arg 1 is second arg
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //constant is the final of Java - cannot be changed or reassigned
            const float Pip = 3.14f;

            /*
             * Type conversions
             * 
             * - implicit type conversion
             * - explicit type conversion or casting
             * - conversion between non-compatible types
             */

            //implicit - going up - no data loss
            byte b = 1;
            int i = b;

            //what there will be data loss conversion must be explicit with a cast for it to compile
            int imp = 1;
            byte by = (byte)imp;

            //non-compatible types - converting and parsing
            string s = "1";
            int ill = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(s);
            Console.WriteLine(ill);
            Console.WriteLine(j);

        }
    }
}
