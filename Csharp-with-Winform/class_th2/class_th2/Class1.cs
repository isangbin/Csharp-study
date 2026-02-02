using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_th2
{
    internal class Device
    {
        private string name;
        private int Id;
        private bool IsOn;

        /*
         * 생성자
         * new Device() 할 때 자동 실행
         */
        public Device(string name, int id)
        {
            // this.name = 이 객체의 필드
            // name = 생성자 매개변수
            this.name = name;
            this.Id = id;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
        public string GetStatus()
        {
            return $"{name} (ID: {Id}) 전원상태:{(IsOn ? "ON" : "OFF")}";
        }

        // 소멸자
        // 객체가 메모리에서 제거될 때 실행
        // GC가 호출하므로 언제 실행되는지는 알 수 없음
        ~Device()
        {
            // WinForms에서는 거의 사용하지 X
        }
    }
}
