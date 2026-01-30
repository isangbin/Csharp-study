using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Slime : Monster
    {
        public int hp;
        public int ad;

        public Slime(int hp, int ad)
        {
            this.hp = hp;
            this.ad = ad;
        }

        public override string Click()
        {
            return "슬라임을 선택했습니다.";
        }
    }
}
