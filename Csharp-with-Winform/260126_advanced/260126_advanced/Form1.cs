using System;   // 기본 자료형. console등 기본 기능 사용
using System.Collections.Generic;   // List같은 컬렉션 사용
using System.ComponentModel;    // 컴포넌트 관련 기능
using System.Data;  // 데이터 관련 기능
using System.Drawing;   // 색상, 그래픽 관련 기능
using System.Linq;  // LINQ 기능
using System.Text;  // 문자열 처리 기능
using System.Threading.Tasks;   // 비동기 처리 관련 기능
using System.Windows.Forms; //winForms 기능 사용

namespace _260126_advanced  // 프로젝트(프로그램) 이름 공간
{
    /*
    구조체 안쓰면?
    변수가 흩어짐 -> 관리가 힘듦, 실수 많아짐

    의미 단위로 묶은 아래 세 변수는 항상 같이 움직임
    '장비 한 대' 라는 개념을 코드에 만들었다고 볼 수 있음
    
    사람의 말 -> 코드 로 번역한 것
    '장비 하나에는 이름, 번호, 상태가 있다.' -> DeviceInfo
     */
    /*
    왜 class가 아니라 struct 인가?
    ㄴ> 값 자체를 저장하고 싶어서
    구조체는 값 타입
    복사하면 완전히 다른 장비 데이터
     */

    struct DeviceInfo   // 장비 정보를 저장하기 위한 구조체 선언
    {
        public string Name; // 장비 이름을 저장하는 문자열 변수
        public int Id;  // 장비 번호를 저장하는 정수 변수
        public bool IsConnected;    // 장비 연결 상태를 저장하는 변수(t/f)
    }


    public partial class Form1 : Form   // Form1은 Form클래스를 상속받음
    {
        /*
        왜 Form1 안에 DeviceInfo device;를 둘까?
        Form1이 장비 하나를 관리하는 화면이기 때문
        Form1 == 장비 관리 화면
        device == 그 화면에서 사용하는 장비 정보
        UI와 데이터 분리
        - 버튼/라벨 = 화면
        - 구조체 = 데이터
        */
        DeviceInfo device;  // DeviceInfo 구조체 타입의 변수 선언
        public Form1()  // Form1 생성자 (프로그램 시작 시 실행)
        {   
            /*
            왜 생성자(Form1)에서 값을 넣을까?
            프로그램 시작과 동시에 기본 장비정보 세팅
            '아무 값도 없는 상태' 방지
            프로그램 켜자마자 장비 하나는 있다고 가정한 것
             */
            /*
             구조체는 데이터를 묶기 위한 도구
            이 코드는 장비 1대를 코드로 표현한 것
            Form1은 그 장비를 화면에서 관리하는 역할
             */
            InitializeComponent();  // 디자이너에서 만든 버튼, 라벨 등 컨트롤 초기화

            device.Name = "Camera A";   // 구조체 속 Name 변수에 값 저장
            device.Id = 1;  // 구조체 속 Id 변수에 값 저장
            device.IsConnected = true;  // 구조체 속 IsConnected 변수에 값 저장


        }
    }
}
