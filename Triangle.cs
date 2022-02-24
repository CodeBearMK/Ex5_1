using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_1
{
    internal class Triangle:Area
    {
        private float low;
        private float high;
        public float Num1
        {
            get { return low; }
            set { low = value; }
        } 

        public float Num2
        {
            get { return high; }
            set { high = value; }
        }

        public float CalArea()
        {
            return (low * high) / 2;
        }
    }
}
