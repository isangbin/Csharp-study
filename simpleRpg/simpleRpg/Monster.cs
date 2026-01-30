using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Monster
    {
        public int hp;
        public int ad;

        public virtual string Click()
        {
            return "몬스터입니다.";
        }
    }

}
