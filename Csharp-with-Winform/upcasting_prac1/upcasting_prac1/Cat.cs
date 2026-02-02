using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_prac1
{
    internal class Cat : Animal
    {
        public override string Name()
        {
            return "고양이";
        }

        public override string Speak()
        {
            return "고양이가 야옹";
        }

        public override string Gender()
        {
            return "암컷";
        }
    }
}
