using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public  interface IInterest
    {
        //methods - methods, properties, events
        //by nature they are public and abstract

        double CalculateInterest();
    }
}
