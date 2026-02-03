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
using ScottPlot;
namespace nuget_tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // x축: 시험 번호(1~5번)
            // y축: 각 시험 점수
            // double[] x = { 1, 2, 3, 4, 5 };
            // double[] y = { 60, 70, 80, 90, 100 };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlotView.Plot.Clear();
            string font = "맑은 고딕";

            Random rand = new Random();
            double[] x = Enumerable.Range(1, 10).Select(i => (double)i).ToArray();
            double[] y = new double[10];

            for (int i = 0; i<10; i++)
            {
                y[i] = rand.Next(0, 101);
            }

            double avg = y.Average();

            // 그래프에 선그래프 추가
            // PlotView는 XAML에서 만든 WpfPlot 컨트롤
            var scatter = PlotView.Plot.Add.Scatter(x, y);
            scatter.LegendText = "시험 점수";

            // 평균선
            var avgLine = PlotView.Plot.Add.HorizontalLine(avg);
            avgLine.LineColor = ScottPlot.Colors.Red;
            avgLine.LinePattern = LinePattern.Dashed;
            avgLine.LineWidth = 2;
            avgLine.LegendText = "평균 점수";

            // 그래프 꾸미기
            // 1. 텍스트 설정
            PlotView.Plot.Title("시험 점수 변화");
            PlotView.Plot.XLabel("시험 번호");
            PlotView.Plot.YLabel("점수");

            // 2. 폰트
            PlotView.Plot.Axes.Title.Label.FontName = font;
            PlotView.Plot.Axes.Bottom.Label.FontName = font;
            PlotView.Plot.Axes.Left.Label.FontName = font;

            PlotView.Plot.Axes.SetLimits(0, 11, -10, 110);

            // 범례
            var legend = PlotView.Plot.ShowLegend(ScottPlot.Alignment.UpperLeft);
            legend.FontName = font;

            PlotView.Refresh();

        }
    }
}