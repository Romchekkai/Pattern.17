using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern._17
{
    class Calculator
    {
        public void CalculateAnyInterest(IKindAccount account)
        {
            account.CalculateInterest();
        }
    }
}
