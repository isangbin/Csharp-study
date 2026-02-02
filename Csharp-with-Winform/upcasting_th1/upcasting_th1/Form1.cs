using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upcasting_th1
{
    public partial class Form1 : Form
    {
        Currency currency;      // 부모타입 변수 선언. Currency타입 하나로 Won/Dollar.Yuan 전부 담을 수 있음. 이것이 업캐스팅 (자식 -> 부모 자동변환)
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 다형성
             * 부모 타입으로 호출했는데 자식 메서드가 실행됨
             * 화폐는 다르지만 다 화폐긴 하다.
             * 그래서 한 변수로 다 처리할 수 있다.
             */
            currency = new Won();
            ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currency = new Dollar();
            ShowInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currency = new Yuan();
            ShowInfo();
        }
        private void ShowInfo()
        {
            label1.Text = $"{currency.Name()}\n환율:{currency.Rate()}원";
        }
    }
}
