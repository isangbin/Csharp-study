using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_th1
{
    /*
     * 부모클래스
     */
    class Vehicle
    {
        public virtual string GetName()
        {
            return "탈 것";
        }

        public void Drive()
        {
            MessageBox.Show("탈것이 이동합니다");
        }

        public void Drive(int speed)
        {
            MessageBox.Show($"{speed}의 속도로 이동합니다");
        }
    }
}
