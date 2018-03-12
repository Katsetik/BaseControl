using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseControl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int kiev = 2804000;
            int kharkiv = 1431000;
            int lasvegas = 603400;


            if (kiev > kharkiv && kiev > lasvegas)
            {
                Console.WriteLine("Most populated is Kiev", kiev);
            }
            else if (kharkiv > kiev && kharkiv > lasvegas)
            {
                Console.WriteLine("Most populated is kharkiv", kharkiv);
            }
            else
            {
                Console.WriteLine("Most populated is lasvegas", lasvegas);
            }
        }
    }
}

       