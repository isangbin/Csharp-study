using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    /*
     *------------
     *부모 클래스
     *------------
     *Animal은 공통기능 만 정의한 클래스
     *실제 동물은 아니고, 기준이 되는 설계도 역할
     */
    internal class Animal
    {
        /*
         * virtual 키워드
         * -> 자식 클래스에서 이 메서드를 자기 방식대로 다시 만들 수 있다.
         */
        public virtual string Speak()
        {
            return "동물이 소리를 냅니다.";
        }
    }
}
