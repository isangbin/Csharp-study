using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 이 파일이 속한 namespace
// 같은 프로젝트 안에서 클래스를 묶어주는 역할
namespace class_th1
{
    // Device라는 이름의 클래스 선언
    // 클래스는 설계도 역할
    internal class Device
    {
        // 필드
        public string Name;     // 장비 이름
        public int Id;          // 장비 번호
        public bool IsOn;       // 장비 전원 상태
    
        //생성자
        // Device 객체가 생설될 때 자동으로 실행되는 메서드 __init__
        // 클래스이름(Device)과 반드시 같아야함
        public Device(string name, int id)
        {
            Name = name;        // this.Name = name; 이 원래 맞다
            Id = id;
            IsOn = false;
        }

        // 메서드
        public void PowerOn()       // 장비 전원 켜는 메서드
        {
            IsOn = true;
        }

        public void PowerOff()      // 장비 전원 끄는 메서드
        {
            IsOn = false;
        }

        public string GetInfo()     // 장비 정보를 문자열로 반환하는 메서드
        {
            return $"장비명:{Name}, ID:{Id}, 전원상태:{IsOn}";
        }
    }
}
