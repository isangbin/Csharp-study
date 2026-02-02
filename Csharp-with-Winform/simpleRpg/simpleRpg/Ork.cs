using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Ork : Monster
    {
        public int hp;
        public int ad;

        public Ork(int hp, int ad)
        {
            this.hp = hp;
            this.ad = ad;
        }

        public override string Click()
        {
            return "오크를 선택했습니다.";
        }
    }
}
