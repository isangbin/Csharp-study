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
 * Form은 사용자와 대화만 하고
 * static 계산 클래스는 로직만 처리하고
 * Result객체는 성공인지 실패인지 책임진다
 */
/*
 * 화면이 계산하면 안되는 이유
 * Form은 사람을 상대하는 역할 (버튼 클릭, TextBox입력, 결과 라벨 보여주기)
 * 화면은 사용자 입출력 담당
 * 
 * 만약 Form 안에 계산 로직이 가득 있으면?
 * - 코드가 길어짐
 * - 테스트하기 어려움
 * - 나중에 콘솔 / 웹으로 못 옮김
 */
/*
 * 계산은 왜 static 클래스인가?
 * 상태가 없음
 * 기억할 필요 없음
 * 그냥 계산만 하면 됨
 * 
 * Calculator.Divide(a,b);
 * 객체 생성 필요없음
 * 메모리 낭비 없음
 * 
 * 계산기는 사람도 아니고 장비도 아니다
 * 그냥 공식이다 -> 그래서 static
 */

/*
 * 왜 Result 객체를 쓸까?
 * 기존 방식은 int result = a/b 가 터지면 프로그램이 죽음
 * Result방식은 Result<int> result = Calculator.Divide(a,b)
 * 세가지 항목을 한번에 물어봄
 * 항목                역할
 * Sucess              성공/실패
 * Value               결과값
 * Message             이유 설명
 * 
 * 예외는 사고발생
 * Result는 안내문이다
 * 
 * 프로그램은 역할 나누기가 전부임
 * 화면이 계산까지하면 -> 머리아픈 코드가 됨
 * 계산이 결과설명까지하면 -> 재사용이 안됨
 * 그래서 나눠서 사용
 */
/*
 * Form은 입출력 담당
 * 계산은 사태 없는 static 클래스가 처리
 * 결과는 성공 실패 포함한 Result 객체로 전달
 * 
 * 이렇게 나누면 코드가 깔끔해지고 유지보수하기 편함
 */

// 클래스 묶는 공간
namespace exception_th1
{
    /*
     * 화면 담당 / 사용자 입, 출력만 관리
     */
    public partial class Form1 : Form
    {
        // 프로그램 실행 시 Form이 만들어질 때 자동 호출
        public Form1()
        {
            // 디자인 초기화
            InitializeComponent();
        }

        /*
         * 계산 기능만 담당할 예정
         * 상태가 없으므로 static 사용 가능
         */
        static class Calculator
        {
            /*
             * 나눗셈 메서드
             * 객체 생성 없이 호출 가능
             * 비즈니스규칙 오류는 Result로 처리
             */
            public static Result<int> Divide(int a, int b)
            {
                // 0으로 나누는 것은 규칙 위반
                // 프로그램 오류가 아니라 계산 실패
                if(b == 0)
                {
                    return Result<int>.Fail("0으로는 나눌 수 없다");
                }

                // 정상적인 계산
                int value = a / b;
                // 성공한 Result 반환
                return Result<int>.Ok(value);
            }
        }

        /*
         * =====================================
         * Result<T> 클래스
         * 메서드 실행 결과를 담는 객체
         * 성공/실패 + 값 + 메세지를 함께 관리
         * =====================================
         */
        class Result<T>
        {
            public bool Success { get; } // 계산 성공 여부
            
            public T Value { get; } // 계산 결과값 (성공했을 때만 의미 있음)
            
            public string Message { get; } // 사용자 또는 개발자에게 보여줄 메세지

            /*
             * 생성자
             * 외부에서 new Result() 금지 -> private
             * 반드시 Ok / Fail 통해서 생성해야함
             */
            private Result(bool success, T value, string message)
            {
                Success = success;
                Value = value;
                Message = message;
            }

            // 성공 결과 생성용 static 메서드
            public static Result<T> Ok(T value)
            {
                return new Result<T>(true, value, "계산 성공");
            }

            // 실패 결과 생성용 static 메서드
            public static Result<T> Fail(string message)
            {
                // default -> T
                // int -> 0
                // string -> null
                // 어떤 타입이 와도 상관없음 <- 이 무슨뜻?
                return new Result<T>(false, default, message);
            }
        }

        /*
         * 버튼 클릭 메서드. 사용자가 버튼 클릭시 실행
         * UI -> 로직 -> 결과출력 흐름
         */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * 사용자 입력 받기
                 * TextBox.Text는 string 타입
                 * int.Parse -> 문자열을 정수로 변환
                 * 만약 숫자가 아니면 변환이 불가능해 예외가 발생할 예정
                 */
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                /*
                 * 계산 로직 호출
                 * Calculator 는 static클래스 -> 객체생성 없이 사용 가능
                 */
                Result<int> result = Calculator.Divide(a, b);

                // 결과 처리
                if (result.Success)
                {
                    // 계산 성공시
                    label1.Text = $"결과: {result.Value}";
                }
                else
                {
                    // 계산 실패시 (비즈니스 오류)
                    label1.Text = $"오류: {result.Message}";
                }
            }
            catch(FormatException)
            {
                // 사용자가 숫자가 아닌 값을 입력한 경우 ex) abc, 공백, 특수문자
                label1.Text = "숫자만 입력하세요.";
            }
            catch(Exception ex)
            {
                // 개발자가 예상하지 못한 오류
                label1.Text = $"시스템 오류: {ex.Message}"; 
            }
        }

}
}
