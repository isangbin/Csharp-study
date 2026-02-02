using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRpg
{
    internal class Player
    {
        public int hp;
        public int ad;

        //public Player(int hp, int ad)
        //{
        //    this.hp = hp;
        //    this.ad = ad;
        //}

        public virtual string Click()
        {
            return "플레이어입니다.";
        }

        public virtual string Talk()
        {
            return "플레이어가 공격!";
        }

        public virtual void LevelUp()
        {

        }

        public virtual void LevelUp(int hp)
        {

        }

        public virtual void LevelUp(int hp, int power)
        {

        }
    }


}
