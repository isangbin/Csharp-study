using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 실습 2-1.
            byte students = 30;
            short interest = 10000;
            int price = 39800;
            float pressure = 12.345f;
            double current = 123.456;
            decimal voltage = 10000.123456m;

            textBox1.Text += students.GetType().ToString() + ' ' + "students: " + students +"\r\n";
            textBox1.Text += interest.GetType().ToString() + ' ' + "interest: " + interest + "\r\n";
            textBox1.Text += price.GetType().ToString() + ' ' + "price: " + price + "\r\n";
            textBox1.Text += pressure.GetType().ToString() + ' ' + "pressure: " + pressure + "\r\n";
            textBox1.Text += current.GetType().ToString() + ' ' + "current: " + current + "\r\n";
            textBox1.Text += voltage.GetType().ToString() + ' ' + "voltage: " + voltage + "\r\n";

            // 실습 3-1.
            string[] arr1 = new string[10];
            arr1[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            arr1[1] = "토요일에 먹는 토마토".LastIndexOf('토').ToString();
            arr1[2] = "질서 있는 퇴장".Contains('퇴').ToString();
            arr1[3] = "그 사람의 그림자는 그랬다.".Replace('그', '이');
            arr1[4] = "삼성 갤럭시".Insert(3, "애플 ");
            arr1[5] = "오늘은 왠지 더 배고프다".Remove(7, 1);
            string[] arr_tmp = new string[3];
            arr_tmp = "임상빈,29,010-9040-8866".Split(',');
            arr1[6] = arr_tmp[0];
            arr1[7] = arr_tmp[1];
            arr1[8] = arr_tmp[2];
            arr1[9] = "우리 나라 만세".Substring(3, 2);

            foreach(string s in arr1)
            {
                textBox1.Text += "\r\n" + s ;
            }


            // 실습 3-2.
            string gongja = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            
            int special_char = gongja.IndexOf('-');
            string prob1 = gongja.Substring(special_char);
            textBox1.Text += "\r\n" + prob1;

            string[] slicer = { "얼마나", "천천히", "가는지" };
            string[] prob2 = gongja.Split(slicer, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in prob2)
            {
                textBox1.Text += "\r\n"+s;
            }

            string prob3 = gongja.Replace(".", "").Replace("-", "").Replace(" ", ",");
            textBox1.Text += "\r\n" + prob3;
        }
    }
}
