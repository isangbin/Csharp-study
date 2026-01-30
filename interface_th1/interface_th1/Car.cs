using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_th1
{
    /*
     * ====================
     * Car 클래스
     * ====================
     * Vehicle 상속
     * IMovable을 받아 해당하는 인터페이스 구현 강제
     */
    internal class Car : Vehicle, IMovable
    {
        public override string GetName()
        {
            return "자동차";
        }

        public void Move()
        {
            MessageBox.Show("자동차가 도로 달린다");
        }


    }
}
