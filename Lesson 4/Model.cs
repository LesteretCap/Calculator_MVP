using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Model
    {
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public string Mul(int a, int b)
        {
            return (a * b).ToString();
        }
        public string Div(int a, int b)
        {
            return ((double)a / b).ToString();
        }
    }
}
