using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_th1
{
    /*
     * ==================================
     * Student 클래스
     * ==================================
     * 이 클래스는 '학생' 이라는 개념을 코드로 표현한 설계도
     * 나이(Age)를 프로퍼티로 관리하는 예제
     */
    internal class Student
    {

        /*
         * -------------------
         * private 필드
         * -------------------
         * 실제 데이터를 저장하는 변수
         * private이기 때문에 클래스 외부에서는 직접 접근 불가능
         */
        private int age;


        /*
         * -------------
         * 프로퍼티
         * -------------
         * age 필드에 안전하게 접근하기 위한 통로
         * 외부에서는 변수처럼 보이지만 내부에서는 메서드처럼 동작함
         */
        public int Age
        {
            /*
             * get : 값을 읽을 때 자동으로 실행
             */
            get
            {
                // age필드에 지정된 값을 반환
                return age;
            }

            /*
             * set : 값을 넣을 때 자동으로 실행
             */
            set
            {   
                // value는 외부에서 전달된 값
                // s.Age = 20 --> value = 20
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
    }
}
