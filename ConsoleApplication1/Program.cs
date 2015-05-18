using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C2;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;

namespace C
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("hello world! C#");
        //    //Console.Write(Program1.calc(5500));
        //    System.AppDomainInitializer ab = x =>
        //    {
        //        Console.WriteLine(String.Join(",", x));
        //    };

        //    ab(new String[] { "abc", "bcd" });


        //    IInterface cc = new C.cc();
        //   var s = cc.hello(new String[]{"c"});
        //   Console.Write(s);
        //    Console.WriteLine(cc.GetHashCode()+"");
        //    C2.red a = (x, y) =>
        //    {
        //        return x * 15 * y;

        //    };

        //    Console.Write(a(15, 10));

        //}
    }

    static class MyClass
    {
        public static IList<String> Test(this IList<String> list)
        {
            throw new NotImplementedException();
        }
    }


    class cc : IInterface {

        //[Display(Name = "")]
        string IInterface.hello(string[] ccc)
        {
            String[] cc = { "c", "a", "b" };
            List<String> cc1 = cc.Reverse().ToList();
            //  list = new List<String>(cc1);
            //for (int i = 0; i < cc1.Count; i++)
            //{
            //    var count = cc1.OrderBy(x => x).Where(x => x != "a").Skip(1).Take(1);
            //}

            
            //Expression<Func<String, Boolean>> t = x => false;


            return cc1[0];


        }

        int IInterface.x
        {
            get { return 100; }
        }

        private String _cc;

        string IInterface.ccc
        {
            get
            {
                return _cc;
            }
            set
            {
                _cc = value;
            }
        }
    }

    interface IInterface
    {
        //int x=0;
        String hello(String[] ccc);
        int x { get; }
        String ccc { get; set; }
    }
    class Program1
    {

        private int m1;
        public int m { get; set; }
        public static int calc(int m)
        {
            //Console.WriteLine(m*m);
            return m * m;
        }
    }

    delegate void red(int xxx);
}


namespace C2
{
    delegate int red(int x, int y);
    //delegate int red(int x, long y);
}
