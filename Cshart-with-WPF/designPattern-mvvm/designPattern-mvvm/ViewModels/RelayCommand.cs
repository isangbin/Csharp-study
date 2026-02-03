using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace designPattern_mvvm.ViewModels
{
    /*
     * RelayCommand
     * 1. 버튼 클릭 이벤트를 ViewModel에 있는 함수랑 연결해주는 '중간 다리'
     * 2. WPF의 기본 인터페이스인 ICommand를 우리가 쓰기 편하게 구현 함
     */
    public class RelayCommand : ICommand
    {
        // 실행할 함수를 담아두는 변수
        private readonly Action execute;

        // 생성자: 버튼을 눌렀을 때 "어떤 함수를 실행할지" 전달받아서 저장 함
        public RelayCommand(Action execute)
        {
            this.execute = execute;
        }

        // 1. 이 버튼을 지금 눌러도 되는지(활성화 상태) 체크하는 곳
        // 고민 없이 항상 true(활성)를 돌려주도록 함
        public bool CanExecute(object parameter) => true;

        // 2. 실제로 버튼을 클릭했을 때 호출되는 지점
        // 저장해뒀던 함수(execute)를 여기서 실행 함
        public void Execute(object parameter) => execute();

        // 버튼의 활성화 상태가 바뀔 때 화면에 알려주는 이벤트 여기선 안 써서 비워둠
        public event EventHandler CanExecuteChanged;
    }
}
