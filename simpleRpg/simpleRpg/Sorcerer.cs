using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Sorcerer : Player
    {
        public int hp;
        public int ad;

        public Sorcerer(int hp, int ad)
        {
            this.hp = hp;
            this.ad = ad;
        }

        public override string Talk()
        {
            return "마법사가 스킬로 공격!";
        }

        public override string Click()
        {
            return "마법사를 선택했습니다.";
        }
    }
}
