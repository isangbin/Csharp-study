using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    /*
     * -------------
     * 자식 클래스
     * -------------
     * Dog : Animal
     * -> Dog는 Animal을 상속 받는다.
     * -> Dog는 Animal 이다. (IS-A관계)
     * 
     * 부모는 공통, 자식은 구체적인 기능을 구현
     * animal -> 말하는 기능만 정의
     * Dog -> 어떻게 말하는지 구체화
     */
    internal class Dog : Animal
    {
        /*
         * override 키워드 -> 자식 클래스에서 이 메서드를 다시 재정의
         * 부모(Animal)의 Speak()를 다시 정의해서 사용함
         */
        public override string Speak()
        {
            // 부모랑 다른 동작을 수행
            return "강아지가 멍멍";
        }
    }
}
