using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class BC<T>
    {
        T ob;

        public BC(T ob)
        {
            this.ob = ob;
        }

        public void show()
        {
            Console.WriteLine($"The type of ob :"+ typeof(T));
            

        }
        public T getob()
        {
            return ob;
        }
    }
}
