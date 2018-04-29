using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Arrr arrr = new Arrr();
                arrr[0] = 5;
                Console.WriteLine(arrr[0]);  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


