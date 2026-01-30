using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_th1
{
    /*
     * 자식 클래스 : Won
     * Currency 클래스를 상속받음
     * '원화'에 대한 정보만 담당
     */
    internal class Won : Currency
    {
        /*
         * 부모의 Name() 메서드를 재정의
         */
        public override string Name()
        {
            return "원 (KRW)";
        }
        public override double Rate()
        {
            return 1.0;
        }
    }
}
