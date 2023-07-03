using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern._17
{
    public class SalaryAccount: IKindAccount
    {
        public double Balance { get; set; }
        private double Interest { get; set; }
        public SalaryAccount(double balance) { this.Balance = balance; }
        public void CalculateInterest()
        {
            if (Balance <= 0)
                throw new Exception("Для отрицательного и нулевого значения баланса процентная ставка не вычисляется");
            Interest = Balance * 0.5;
            
        }

    }
}
