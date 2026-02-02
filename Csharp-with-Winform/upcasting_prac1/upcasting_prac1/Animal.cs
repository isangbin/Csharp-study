using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_prac1
{
    internal class Animal
    {
        public virtual string Name()
        {
            return "동물";
        }

        public virtual string Speak()
        {
            return "동물소리";
        }

        public virtual string Gender()
        {
            return "자웅동체";
        }
    }
}
