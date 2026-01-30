using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_th1
{
    internal class Device
    {
        // 장비 번호
        public int Id { get; set; }

        // 장비 이름
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id},  Name: {Name}";
        }
    }
}
