using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_th1
{
    internal class Yuan : Currency
    {
        public override string Name()
        {
            return "위안 (CNY)";
        }
        public override double Rate()
        {
            return 180.0;
        }
    }
}
