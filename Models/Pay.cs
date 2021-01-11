using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnuitetCalculator.Models
{
    public class Pay
    {
        public byte Id;
        public DateTime Date;
        public double Sum;
        public double Debt;
        public double Percent;
        public double Balance;

        public Pay(byte id, DateTime date, double sum, double debt, double percent, double balance)
        {
            Id = id;
            Date = date;
            Sum = sum;
            Debt = debt;
            Percent = percent;
            Balance = balance;
        }
        
    }
}
