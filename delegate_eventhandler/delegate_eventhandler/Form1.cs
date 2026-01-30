using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 델리게이트는 왜 쓰나? 함수만들어서 쓰면 되지 않나?
 * -> 안되는건 아니나, 구조가 커지면 한계가 옴
 * 
 * 델리게이트는 코드를 유연하게 만들기 위해서 쓴다.
 * 
 * 
 * void Process(){
 * ShowLabel(처리완료)
 * ShowMessageBox(처리완료)
 * }
 * 위의 경우 실행 대상이 코드에 박혀있고
 * 메서드 추가/제거 하려면 Process를 수정해야함
 * 테스트/재사용 어려움
 * 
 * 
 * void Process(){
 * onComplete("처리완료")
 * }
 * 
 * 위의 경우 Process는 누가 실행되는지 모르고 처리가 됐다는 사실만 앎
 * 실행 대상은 외부에서 결정
 * 
 */

namespace delegate_eventhandler
{
    public partial class Form1 : Form
    {
        /*
         * 1. 델리게이트 선언
         * delegate는 "메서드를 담을 수 있는 타입"
         * 아래 델리게이트는
         * - 매개변수: string 한 개
         * - 반환값: void
         * 인 메서드만 저장할 수 있다.
         * 
         * 
         */
        delegate void MessageDelegate(string message);

        /*
         * 2. 델리게이트 변수 선언
         * 아직 어떤 메서드가 실행될지는 정해지지 않았다.
         * 단지 '실행 규칙'만 정해진 상태
         */
        MessageDelegate myDelegate;

        /*
         * 3. 이벤트 선언
         * event는 델리게이트를 기반으로 만들어진다.
         * 델리게이트와 차이점:
         * - 외부에서 호출 불가
         * - +=, -= 만 가능
         * "알림용"으로 사용
         */
        event MessageDelegate myEvent;
        public Form1()
        {
            InitializeComponent();

            /*
             * 델리게이트에 메서드 등록
             */
            myDelegate += ShowLabel; // 델리게이트 추가할땐 ~~el() 괄호필요X
            myDelegate += ShowMessageBox; // 주소를 저장하는거라서그렇다

            /*
             * 이벤트에 메서드 등록
             * 구조는 델리게이트와 동일, 외부호출은 불가
             */
            myEvent += ShowLabel;
            myEvent += ShowMessageBox;
        }

        /*
         * 델리게이트/이벤트에 연결될 메서드
         * 
         * 시그니처(모양)이
         * delegate void MessageDelegate(string message) 와 반드시 일치해야함
         * 
         * 
         */
        private void ShowLabel(string message)
        {
            label1.Text = message;
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            // 델리게이트 호출

            // 실행순서
            // 1. ShowLabel 실행
            // 2. ShowMessageBox 실행
            // 델리게이트는 내부적으로 메서드 목록을 가지고있다.
            myDelegate("델리게이트 호출됨");
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            // 이벤트 발생

            // 이벤트는 반드시 선언한 클래스 내부에서만 호출 가능
            myEvent("이벤트 호출됨");
        }
    }
}
