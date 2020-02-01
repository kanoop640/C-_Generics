using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{


    class MathmaticOperation
    {

        public void m1<T>(T[] input)
        {
            foreach (T str in input)
            {
                Console.WriteLine(str);
            }
        }
    }
}
