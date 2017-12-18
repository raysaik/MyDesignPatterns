using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_BusinessLayer
{
    public class Rule1 : IRule
    {
        public double GetBill(char grade, double amount)
        {
            switch (grade)
            {
                case 'A':
                    return (amount * 20) / 100;
                case 'B':
                    return (amount * 50) / 100;
                case 'C':
                default:
                    return amount;
                case 'D':
                    return 0;
            }
        }
    }
}
