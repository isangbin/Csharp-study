using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heritage
{
    public partial class Form1 : Form
    {
        Animal animal;

        public Form1()
        {
            InitializeComponent();
            
            /*
             * 실제로 생성되는 객체는 Dog (자식클래스)
             * 그러나 변수타입은 Animal (부모클래스)
             * 
             * -> 강아지는 동물이다. 를 직관적으로 보여주기 위해 이렇게함
             * 상속의 핵심 개념.
             */
            animal = new Dog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = animal.Speak();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cat 객체 생성
            animal = new Cat();
            label1.Text = animal.Speak();
        }
    }
}
