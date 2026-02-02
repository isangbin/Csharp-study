using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_prac
{
    public partial class Form1 : Form
    {
        Machine drink1, drink2, drink3;
        int myBudget = 10000;
        public Form1()
        {
            InitializeComponent();

            drink1 = new Machine("Coke", 2000);
            drink2 = new Machine("Cider", 2500);
            drink3 = new Machine("Fanta", 1500);

            label1.Text = $"잔액: {myBudget}원";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "선택음료: Coke";
            label3.Text = "구매중";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "선택음료: Cider";
            label3.Text = "구매중";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "선택음료: Fanta";
            label3.Text = "구매중";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "선택음료: Coke")
            {
                if (myBudget >= drink1.price)
                {
                    myBudget -= drink1.price;
                    label3.Text = drink1.Purchase();
                    label1.Text = $"잔액: {myBudget}원";
                }
                else
                {
                    label3.Text = "잔액이 부족합니다.";
                }
                
            }
            else if (label2.Text == "선택음료: Cider")
            {
                if (myBudget >= drink2.price)
                {
                    myBudget -= drink2.price;
                    label3.Text = drink2.Purchase();
                    label1.Text = $"잔액: {myBudget}원";
                }
                else
                {
                    label3.Text = "잔액이 부족합니다.";
                }
            }
            else if (label2.Text == "선택음료: Fanta")
            {
                if (myBudget >= drink3.price)
                {
                    myBudget -= drink3.price;
                    label3.Text = drink3.Purchase();
                    label1.Text = $"잔액: {myBudget}원";
                }
                else
                {
                    label3.Text = "잔액이 부족합니다.";
                }
            }
            else
            {
                label3.Text = "잘못된 선택";
            }
        }
    }
}
