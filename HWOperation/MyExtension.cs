using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOperation
{
    public static  class MyExtension
    {
        
            public static void PrintCampList(this List<Camp> c)
            {
                foreach (Camp c2 in c)
                    Console.WriteLine(c2.ToString());
            }

        
    }
}
