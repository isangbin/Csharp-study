using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_th1
{
    public partial class Form1 : Form
    {
        // parent type
        Vehicle vehicle;
        // interface type
        IMovable movable;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();    // Car 객체 생성
            vehicle = car;          // 업캐스팅
            vehicle.Drive();
            vehicle.Drive(100);
            
            movable = car;          // 인터페이스 참조

            label1.Text = vehicle.GetName();    // 오버라이드된 메서드 호출
            movable.Move();                     // 인터페이스 메서드 호출
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            vehicle = bicycle;
            //movable = bicycle;

            label1.Text = bicycle.GetName();
            bicycle.Move();
        }
    }
}
