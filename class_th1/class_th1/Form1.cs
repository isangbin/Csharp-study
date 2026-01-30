using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 네임스페이스 = 폴더
 * 클래스 = 파일
 * 클래스 이름 = 파일명
 * 
 * 네임스페이스는 클래스 묶음이다.
 * 이름 충돌을 막기위해 사용
 * 같은 네임스페이스면 바로 사용 가능 
 */

namespace class_th1
{
    public partial class Form1 : Form
    {
        /*
         * Device 클래스 타입의 변수 선언
         * 아직 실제 장비는 만들어지지 않은 상태
         */
        Device device, device2;
        Student student;
        public Form1()
        {
            // 디자이너에서 만든 컨트롤 초기화
            InitializeComponent();

            // Device 클래스 객체 생성(new 사용)
            // 생성자가 호출되면서 Name, Id, IsOn이 초기화됨
            device = new Device("Camera A", 1);
            device2 = new Device("Camera B", 1);


            student = new Student();
            // 프로퍼티를 통해 나이 설정 set
            student.Age = 20;
            student.Age = -5;
            // 보여주기위해 get으로 가져옴
            label4.Text = $"학생 나이: {student.Age}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 장비 전원을 켜는 메서드 호출
            device.PowerOn();
            device2.PowerOn();
            label2.Text = device.GetInfo();
            label3.Text = device2.GetInfo();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            device.PowerOff();
            device2.PowerOff();
            label2.Text = device.GetInfo();
            label3.Text = device2.GetInfo();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            device.PowerOn();
            label2.Text = device.GetInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            device.PowerOff();
            label2.Text = device.GetInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            device2.PowerOn();
            label3.Text = device2.GetInfo();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            device2.PowerOff();
            label3.Text = device2.GetInfo();
        }


    }
}
