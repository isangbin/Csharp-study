using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_th1
{
    internal class Dollar : Currency
    {
        public override string Name()
        {
            return "달러 (USD)";
        }
        public override double Rate()
        {
            return 1300.0;
        }
    }
}
