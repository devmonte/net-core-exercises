using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DI.Service
{
    public interface IB
    {
        int CalculateDiff(int a, int b) => a - b;
    }
}
