using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DI.Service
{
    public interface IA
    {
        public int CalculateSum(int a, int b) => a + b;
    }
}
