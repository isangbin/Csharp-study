using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_th1
{
    /*
     * --------------------
     * 인터페이스
     * --------------------
     * 움직일 수 있다 라는 규칙을 만들 것임. (구현은 없음)
     * 이 인터페이스를 상속하면 반드시 Move()를 만들어야함.
     * 이 기능은 꼭 만들어라 라는 강제규칙
     * 
     * 
     * 오버로드 = 확장
     * 오버라이드 = 변경
     * 인터페이스 = 강제
     * 업캐스팅 = 통합
     */
    interface IMovable
    {
        void Move();
    }
}
