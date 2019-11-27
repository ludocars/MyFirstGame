using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame {
    class Program {
        static void Main (string[] args) {

            int x = 5;
            float y = 4.5f;
            string str = "lorem ipsum";
            bool myBool = false;

            float result;

            result = 5 + 7;
            Console.WriteLine ("suma " + result);

            result = 5 - 7;
            Console.WriteLine ("resta " + result);

            result = 5 * 7;
            Console.WriteLine ("multiplicacion " + result);

            result = 5f / 7f;
            Console.WriteLine ("division " + result);

            result = 5 % 7;
            Console.WriteLine ("diferencia " + result);

            Console.ReadLine ();

        }
    }
}
