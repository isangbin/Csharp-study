using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting_th1
{
    /*
     * ============================
     * 부모 클래스 = Currency(화폐)
     * ============================
     * 모든 화폐의 공통 기능과 형태를 정의하는 클래스
     * Won, Dollar, Yuan이 이 클래스를 상속받음
     */
    internal class Currency
    {
        /*
         * 화폐 이름을 반환하는 메서드
         * virtual 키워드 : 자식 클래스에서 재정의(override)할 수 있다는 뜻
         */
        public virtual string Name()
        {
            // 기본 화폐 이름
            return "화폐";
        }

        /*
         * 환율 정보를 반환하는 메서드
         * 자식 클래스마다 다른 환율을 가지도록 허용
         */
        public virtual double Rate()
        {
            return 1.0;
        }
    }
}
