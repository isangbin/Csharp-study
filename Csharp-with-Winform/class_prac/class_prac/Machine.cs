using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_prac
{
    internal class Machine
    {
        public string name;
        public int price;
    

        public Machine(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Purchase()
        {
            return $"{this.name} 구입에 성공했습니다.";           
        }

    }
}
