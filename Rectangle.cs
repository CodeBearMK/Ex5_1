using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_1
{
    internal class Rectangle:Area
    {
        private float length = 0;
        private float width = 0;
        public float Num1
        {
            get { return length; }
            set { length = value; }
        }

        public float Num2
        {
            get { return width; }
            set { width = value; }
        }

        public float CalArea()
        {
            return length * width;
        }
    }
}
