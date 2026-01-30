using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 한사람이 하나만 하는게 아니라 여러명이 동시에 일을 나눠서 하는 것
 * 상황                    설명
 * 싱글 스레드             요리사 한명이 요리+설거지+주문
 * 멀티 스레드             요리사/서빙/계산원 각각 따로 존재
 * UI 스레드               손님 앞에서 보이는 직원
 * 백그라운드 스레드       주방 안에서 일하고 있는 직원
 * 
 * 손님 앞에 보이는 직원(UI스레드)은 멈추면 안됨.
 * 힘든 일은 뒤에서 따로 처리
 * 
 * 필수 용어
 * 프로세스 : 실행 중인 프로그램 (카카오톡)
 * 스레드 : 프로세스 안에서 실제로 일하는 일꾼
 *          기본은 1개 (UI스레드)
 * 멀티스레드 : 일꾼을 여러명 쓰는 것
 * UI스레드 : 화면 그리는 전용 스레드
 *            절대 멈추면 안됨
 *            
 *            
 * 
 * 왜 멀티스레드를 쓰는가?
 * 컴퓨터를 빠르게하려고 -> X
 * 화면(UI)을 멈추지 않게 하려고 -> O
 * 
 * Thread : 직접 사람 뽑기 (힘듦) <- 현업에서 쓰면 혼남
 * Task : 일 맡기기 (편함)
 * Async : 기다리지만 놀진 않음 (최고) <- 제일 많이 씀
 * 
 * async/await는 멀티스레드를 사람처럼 쓰게 해주는 문법
 */

/*
 * Thread 쓸바엔 Task 쓴다
 * Thread = 수동 (위험)
 * Thread를 직접 쓰면 개발자가 전부 책임져야함
 * 스레드 썼을 때 개발자가 관리해야 하는 것들
 * - 스레드 생성, 종료
 * - 개수 제한, 예외 처리, 리소스 해체, 성능 관리
 * - 사고나면 전부 내탓
 * Thread는 너무 무겁다. 하나당 메모리 MB단위
 * 컨텍스트 스위칭 비용 큼
 * 많이 만들면 성능 오히려 최악
 * server/client 둘 다 문제생김
 * 예외가 잡히지 않는다 (치명적)
 * 취소가 어렵다
 * Thread가 할 수 있는건 Task도 다 해줌
 * 
 * 총평 - 스레드는 왜 안쓰나요?
 * 스레드는 직접 관리 비용과 위험이 커서
 * 실무에선 Task나 async/await를 사용한다고 알고 있다.
 */
namespace multithread_th1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 멀티스레드 안 쓴 경우 (UI멈춤)
         */
        private void btnBlock_Click(object sender, EventArgs e)
        {
            // UI스레드에서 실행됨
            // UI스레드는 화면 담당 직원
            label1.Text = "5초 동안 멈춤.....";
            Thread.Sleep(5000);
            label1.Text = "끝 (멈췄었음)";
        }

        /*
         * Thread 사용 (원초적 멀티스레드)
         */
        private void btnThread_Click(object sender, EventArgs e)
        {
            // Thread : 직접 일꾼 한명을 뽑는 것
            // 관리가 어렵고 위험함
            Thread worker = new Thread(DoWorkWithThread);

            worker.IsBackground = true; // 프로그램 종료시 같이 종료
            worker.Start();
        }

        private void DoWorkWithThread()
        {
            // 이 메서드는 UI 스레드가 아니다.
            // 화면(Label)을 직접 만지면 에러남
            for (int i=1; i<=5; i++)
            {
                Thread.Sleep(1000);
                // Invoke
                // 야 UI스레드야 나대신 화면좀 바꿔줘
                this.Invoke(new Action(() =>
                {
                    label1.Text = $"Thread 작업 중: {i}";
                }));
            }
        }

        /*
         * Task 사용 (Thread보다 안전)
         */
        private void btnTask_Click(object sender, EventArgs e)
        {
            // Task = 일 시키기
            // Thread 관리는 .NET이 알아서 함
            Task.Run(()=>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Thread.Sleep(1000);
                    // Invoke
                    // 야 UI스레드야 나대신 화면좀 바꿔줘
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"Task 작업 중: {i}";
                    }));
                }
            });
        }

        /*
         * async / await (실무 최종형)
         */
        private async void btnAsync_Click(object sender, EventArgs e)
        {
            // async : 이 메서드 안에서는 await를 쓸 수 있다.
            label1.Text = "async 시작";

            // await : 오래걸리는 작업을 기다리되 UI스레드는 절대 멈추지 않는다.
            await Task.Delay(1000);

            // await 이후 코드는 다시 UI스레드로 돌아온다. -> invoke 필요 X
            label1.Text = "async 끝 (UI 안멈춤)";
        }
    }
}
