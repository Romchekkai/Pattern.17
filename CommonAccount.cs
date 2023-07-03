using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern._17
{
    public class CommonAccount: IKindAccount
    {

        public double Balance { get; set; }
        private double Interest { get; set; }
        public CommonAccount(double balance) { this.Balance = balance;}
        public void CalculateInterest()
        {
            if (Balance <= 0)
                throw new Exception("Для отрицательного и нулевого значения баланса процентная ставка не вычисляется");
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
