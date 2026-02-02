using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_prac1
{
    internal class Bird : Animal
    {
        public override string Name()
        {
            return "새";
        }

        public override string Speak()
        {
            return "새가 짹짹";
        }

        public override string Gender()
        {
            return "수컷";
        }
    }
}
