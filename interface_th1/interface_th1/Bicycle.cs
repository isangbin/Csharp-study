using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_th1
{
    internal class Bicycle : Vehicle, IMovable
    {
        public override string GetName()
        {
            return "자전거";
        }

        public void Move()
        {
            MessageBox.Show("자전거가 천천히 이동");
        }
    }
}
