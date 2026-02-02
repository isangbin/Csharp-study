using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Warrior : Player
    {
        public int hp;
        public int ad;

        public Warrior(int hp, int ad)
        {
            this.hp = hp;
            this.ad = ad;
        }

        public override string Talk()
        {
            return "전사가 검으로 공격!";
        }

        public override string Click()
        {
            return "전사를 선택했습니다.";
        }

    }
}
