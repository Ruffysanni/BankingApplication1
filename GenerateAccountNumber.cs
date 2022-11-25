using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication1
{
    public class GenerateAccountNumber
    {
       
        public string SavingsAccountNumber()
        {

            return $"10{DateTime.Today:yyMMdd}{new Random().Next(0, 99).ToString().PadLeft(2, '0')}";
        }

        public string CurrentAccountNumber()
        {

            return $"20{new Random().Next(0, 99).ToString().PadLeft(2, '0')}{DateTime.Today:yyMMdd}";
        }
    }
}
