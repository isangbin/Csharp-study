using ScottPlot;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using designPattern_mvvm.Models;

namespace designPattern_mvvm.ViewModels
{
    /*
     * MainViewModel
     * 프로그램의 '두뇌' 역할을 하는 클래스
     * 데이터를 만들고, 버튼 명령을 처리하고, 그래프를 그릴 준비를 다 여기서 함
     */
    public class MainViewModel
    {
        // 1. 점수를 무작위로 만들기 위한 도구
        private readonly Random rand = new Random();

        // 2. 학생들 점수 데이터를 모아두는 리스트야.
        // 일반 List와 달리 데이터가 추가/삭제되면 화면에 바로 알려주는 기능이 있음
        public ObservableCollection<ScoreModel> Scores { get; private set; }

        // 3. 버튼을 클릭했을 때 실행될 '명령'이야. XAML 버튼의 Command와 연결 됨
        public ICommand GenerateCommand { get; }

        // 4. 실제로 그래프가 그려지는 '도화지' 객체
        public Plot Plot { get; set; }

        // 생성자: 프로그램이 시작될 때 초기 세팅을 하는 곳
        public MainViewModel()
        {
            Scores = new ObservableCollection<ScoreModel>();
            Plot = new Plot();

            // 그래프의 제목과 가로/세로축에 이름을 붙여주는 기초 작업
            Plot.Title("시험 점수 그래프");
            Plot.Axes.Bottom.Label.Text = "학생 번호";
            Plot.Axes.Left.Label.Text = "점수";

            // 버튼 명령(GenerateCommand)이 들어오면 아래 GenerateScores 함수를 실행하도록 연결 함
            GenerateCommand = new RelayCommand(GenerateScores);
        }

        /*
         * 핵심 로직
         * 점수를 새로 만들고 그래프를 다시 그리는 함수
         */
        private void GenerateScores()
        {
            // (1) 새로운 데이터를 넣기 위해 기존에 있던 점수들을 싹 비워줌
            Scores.Clear();

            // (2) 반복문을 써서 학생 10명의 점수를 랜덤으로 생성해 리스트에 담음
            for (int i = 1; i <= 10; i++)
            {
                Scores.Add(new ScoreModel
                {
                    StudentNumber = i,
                    Score = rand.Next(0, 101) // 0점부터 100점 사이 랜덤
                });
            }

            // (3) 도화지(Plot)도 이전 그림을 지우고 새로 그릴 준비를 함
            Plot.Clear();

            // (4) 리스트에 담긴 학생 객체에서 '번호'와 '점수'만 쏙쏙 뽑아서 배열로 만듦
            // ScottPlot 그래프 라이브러리는 숫자로 된 배열만 가능
            double[] xs = Scores.Select(s => (double)s.StudentNumber).ToArray();
            double[] ys = Scores.Select(s => (double)s.Score).ToArray();

            // (5) 점들을 선으로 이은 '산점도' 그래프를 도화지에 그려 넣음
            Plot.Add.Scatter(xs, ys);

            // 주의: 그림은 다 그렸지만, 실제 화면(View)을 새로고침하는 건 View가 직접 해야 함
        }
    }
}
