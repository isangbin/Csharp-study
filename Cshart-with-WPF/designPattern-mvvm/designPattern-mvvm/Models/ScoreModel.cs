using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern_mvvm.Models
{
    /*
     * Model은 계산도 화면도 모름
     * 그냥 데이터만 들고 있음
     * 
     * ScoreModel
     * ----------------
     * 시험 점수 하나를 표현하는 "데이터 클래스"
     * 
     * 화면(XAML)과 전혀 관계 없음
     * 랜덤 생성, 계산 로직 없음
     * 오직 '값' 만 보관할 것임
     * 
     * Model은 똑똑할 필요가 없음 (기능, 예외처리 등등 X)
     * 그냥 데이터박스 역할
     * 
     * Model은
     * 이게 무슨 데이터 인지만 알고 있으면 됨
     * 그걸 어떻게 사용할지는 다른 애들 일임
     */

    /*
     * ScoreModel
     * 1. 학생 한 명의 정보를 저장하는 '데이터 틀'.
     * 2. 가로축(번호)과 세로축(점수) 데이터를 하나로 묶어주는 역할
     */
    public class ScoreModel
    {
        // 학생 번호: 그래프의 가로축(X축) 위치를 결정
        public int StudentNumber { get; set; }

        // 시험 점수: 그래프의 높낮이(Y축)를 결정. (0~100 사이)
        public int Score { get; set; }
    }
}
