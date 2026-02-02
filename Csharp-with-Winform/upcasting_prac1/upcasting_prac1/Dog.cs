using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_prac1
{
    internal class Dog : Animal
    {
        public override string Name()
        {
            return "개";
        }

        public override string Speak()
        {
            return "개가 멍멍";
        }

        public override string Gender()
        {
            return "수컷";
        }
    }
}
