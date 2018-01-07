using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucbucaq_clone
{
    class Program
    {
        static void Main(string[] args)
        {
            ucbucaq uc = new ucbucaq();
            uc.a = 15;
            uc.b = 15;
            uc.c = 20;

            ucbucaq uc2 = uc.copy();


            int yari = uc.perimetr() / 2;
            uc2.a = yari + uc.a;
            uc2.b = yari + uc.b;
            uc2.c = yari + uc.c;

            Console.WriteLine(uc.perimetr());
            Console.WriteLine(uc2.perimetr());
            Console.ReadLine();

        }
    }

    class ucbucaq {

        public int a;
        public int b;
        public int c;

        public int perimetr()
        {
            return a + b + c;
        }

        public ucbucaq copy()
        {
            ucbucaq temp = new ucbucaq();
            temp.a = a;
            temp.b = b;
            temp.c = c;
            return temp;
        }
    }

}
