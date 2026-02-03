using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using designPattern_mvvm.ViewModels;

namespace designPattern_mvvm.Views
{
    /*
     * 화면(View)과 데이터(ViewModel)를 연결해주는 실제 로직
     * ScottPlot 같은 컨트롤은 여기서 직접 제어해주는 게 가장 확실 함
     */
    public partial class MainWindow : Window
    {
        // 화면 뒤에서 작동할 두뇌(ViewModel)를 담을 변수
        private readonly MainViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            // 1. 프로그램의 두뇌인 MainViewModel을 생성
            vm = new MainViewModel();

            // 2.ScottPlot 5의 특징
            // 화면에 있는 그래프 도화지(PlotView.Plot)를 ViewModel에 빌려줘서
            // ViewModel이 그 위에 그림을 그릴 수 있게 세팅 함
            vm.Plot = PlotView.Plot;

            // 3. 이 화면의 데이터 주인(DataContext)이 누구인지 알려줘.
            // 이렇게 해야 XAML에서 {Binding}이 작동함
            DataContext = vm;
        }

        // 4. 버튼을 클릭했을 때 실행되는 함수
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ViewModel에서 데이터를 아무리 바꿔도,
            // 이 Refresh()를 안 해주면 그래프 화면은 변하지 않음
            // "자, 이제 다 그렸으니 화면 다시 그려!"라고 명령 함
            PlotView.Refresh();
        }
    }
}