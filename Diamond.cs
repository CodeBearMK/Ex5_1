using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_1
{
    internal class Diamond:Area
    {
        private float diagonal_1 = 0;
        private float diagonal_2 = 0;
        public float Num1
        {
            get { return diagonal_1; }
            set { diagonal_1 = value; }
        }

        public float Num2
        {
            get { return diagonal_2; }
            set { diagonal_2 = value; }
        }

        public float CalArea()
        {
            return (diagonal_1 * diagonal_2) / 2;
        }
    }
}
