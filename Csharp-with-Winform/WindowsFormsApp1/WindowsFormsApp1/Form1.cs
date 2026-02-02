using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 우리가 작성하는 C# 코드는
// 바로 CPU에서 실행되지 않음.

// 순서1. C# 코드 -> CIL
// 빌드 할 때
// C# 코드는 CIL(Common Intermediate Language)라는
// 중간 언어로 변환됨
// (CPU 종류와 상관없는 언어)

// 순서2. CIL -> CLR
// 프로그램 실행하면
// CLR(Common Language Runtime)이 실행됨
// CLR은 .NET 프로그램을 관리하는 실행 환경

// 순서3. JIT 컴파일
// CLR 안에 있는 JIT 컴파일러가
// CIL 코드를 실제 CPU가 이해할 수 있는
// 기계어로 바꿔줌 (실행 직전에 변환됨)

// 순서4. 실행
// 변환된 기계어를 CPU가 실행함

// C# -> (빌드) -> CIL -> (실행) -> CLR -> CPU 실행


// CLR이 대신 해주는 일
// CLR이 자동으로 해주는 것들
// - 메모리 관리
// - 예외처리
// - 프로그램 실행 관리
// - 스레드 관리


// Debug / Release 설명
// Debug 모드
// - 개발 중 사용
// - 디버깅 정보 많음
// - 속도 느림

// Rekease 모드
// - 배포용
// - 최적화 전용
// - 실행 속도 빠름

// WinForms랑 연결 설명
// 프로그램 실행 순서
// 1. C# 코드 빌드 -> CIL 생성
// 2. 실행 시 CLR 로드
// 3. Main() 실행
// 4. Form1 생성
// 5. 윈도우 화면 표시

// C#은 바로 실행 안되고
// 중간 언어(CIL)로 바뀐 다음
// CLR이 실행해줌


// 스레드란?
// 프로그램 안에서 동시에 일하는 작업자

// 비유
// 프로그램 = 회사
// 프로세스 = 한명의 직원
// 스레드 = 그 직원의 양손
// 한 손으로 전화받고 다른 손으로는 키보드 치는 것 처럼
// 여러 일을 동시에 처리한다

// 프로세스 vs 스레드
// 프로세스
// - 실행 중인 프로그램 하나
// - 메모리 공간을 가짐

// 스레드
// - 화면 그리기
// - 버튼 클릭 처리
// 를 담당함

// 스레드를 잘못 쓰면 생기는 문제
// UI 스레드에서 오래걸리는 작업을 하면
// 화면 멈춤, '응답없음' 발생
// 버튼 눌렀는데 창이 얼어붙는 그런 상황
// 게임하다가 버튼 클릭했는데 멈춰서 작업관리자로 강종시도 -> 응답없음
// 바로 저 응답없음임

// 그래서 스레드를 쓰는 이유가 뭐냐
// 오래걸리는 작업은 다른 스레드에서 실행하고
// UI 스레드는 화면 반응만 담당하게 함

// 초간단 스레드 예제(개념용)
// using System.Threading;
// 새로운 작업자(스레드) 생성
//Thread worker = new Thread(() =>
//{
//    // 오래 걸리는 작업
//    for (int i = 0; i < 5; i++)
//    {
//        Thread.Sleep(1000); // 1 초 대기
//        Console.WriteLine("작업 중 ...");
//    }
//});
//worker.Start(); // 스레드 시작



// using = 네임스페이스 가져오기. == import in Python
namespace WindowsFormsApp1 // 내 프로그램의 네임스페이스
{ // 코드영역을 중괄호{}로 구분. == 파이썬 들여쓰기    
    public partial class Form1 : Form   // Form 클래스를 상속 받는 Form1 클래스
    {   
        // 접근 제어: public
        // partial 클래스
        public Form1()  // Form1 클래스와 같은 이름의 메소드
            // Form1 클래스의 생성자
        {
            // 우너폼 초기화를 위한함수
            // 코드를 실행하려면 반드시 ;를 붙임
            InitializeComponent();
            // **소스코드는 이곳에 작성하는 것임**
            // MessageBox.Show("안녕하세요");
            textBox_print.Text = "결과를 확인해보자";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
