using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public   class Current : Bank
    {
        public override void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public sealed  override string ToString()
        {
            return base.ToString();
        }
    }


    public class SubCurrent : Current
    {
        
    }
}
