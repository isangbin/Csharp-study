using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace collections_th1
{
    public partial class Form1 : Form
    {
        /*
         * List<Device>
         * 제네릭 T 설명
         * List<T>에서 T는
         * 이 리스트에 들어갈 타입의 자리 표시자
         * 
         * 여기서는 T = Device니까
         * 이 리스트에는 Device 객체만 들어올 수 있음
         * int, string 같은 다른 타입은 컴파일 에러
         */
        private List<Device> devices = new List<Device>();
        public Form1()
        {
            InitializeComponent();
            // 일단안보이게
            ButtonShow();
        }

        private void ButtonShow()
        {
            bool state;
            if (devices.Count > 0) { state = true; }
            else { state = false; }

            button2.Visible = state;
            button3.Visible = state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1에서 장비 이름 입력 받기
            string name = textBox1.Text;

            // Device 객체생성
            Device device = new Device()
            {
                // 현재 리스트 개수+1 을 ID로 사용
                Id = devices.Count + 1,
                // 사용자가 입력한 이름 저장
                Name = name,
            };
            //List<Device>에 Device 추가
            devices.Add(device);

            // listBox에 컬렉션 다시연결 (화면갱신)
            listBox1.DataSource = null;
            listBox1.DataSource = devices;

            // listBox에 보여줄 속성을 지정
            //listBox1.DisplayMember = "Name";
            listBox1.DisplayMember = device.ToString();

            // 입력창 초기화
            textBox1.Text = "";
            // 버튼 보일지말지 결정
            ButtonShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            devices[idx].Name = textBox1.Text;

            listBox1.DataSource = null;
            listBox1.DataSource = devices;

            textBox1.Text = "";
            ButtonShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            devices.RemoveAt(idx);

            listBox1.DataSource = null;
            listBox1.DataSource = devices;

            textBox1.Text = "";
            ButtonShow();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Device tmp = (Device)listBox1.SelectedItem;
                textBox1.Text = tmp.Name;
            }
        }
    }
}
