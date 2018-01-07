using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucbucaq_clone
{
    class reference_out
    {
        static void Mainn()
        {

            double s = 0;
            int r = 15;
            calcarea(r,out s);

            Console.WriteLine(s);
            Console.ReadLine();

        }

        static void calcarea(int r,out double s)
        {
            s = Math.PI * r * r;
        }

     



    }
}


