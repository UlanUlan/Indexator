using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    public class Arrr
    {
        int[] a;
        private Random rand = new Random();
        public Arrr()
        {
            a = new int[rand.Next(10,30)];
        }
        public int this[int index]
        {
            get
            {
                return a[index];
            }
            set
            {
                a[index] = value*value;
            }
        }
        


    }
}
