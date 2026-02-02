using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleRpg
{
    public partial class Form1 : Form
    {
        Player player1, player2;
        Monster ork, slime;
        int damage1, damage2;
        string human, mon;

        public Form1()
        {
            InitializeComponent();

            player1 = new Warrior(100, 20);
            player2 = new Sorcerer(100, 25);
            ork = new Ork(100, 30);
            slime = new Slime(100, 15);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = player1.Click();
            damage1 = player1.ad;
            human = "전사";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = player2.Click();
            damage1 = player2.ad;
            human = "마법사";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = slime.Click();
            damage2 = slime.ad;
            mon = "슬라임";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = ork.Click();
            damage2 = ork.ad;
            mon = "오크";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = $"{human} vs {mon} 의 전투가 시작됩니다.";
            label4.Text = $"{player1.hp}, {player1.ad}, {ork.hp}, {ork.ad}";
            if (human == "전사") {player1.hp -= damage2; if (player1.hp <= 0) { label5.Text = "전사가 사망했습니다.";} }
            else {player2.hp -= damage2; if (player2.hp <= 0) { label5.Text = "마법사가 사망했습니다."; } }

            if (mon == "슬라임"){slime.hp -= damage1; if (slime.hp <= 0) { label5.Text = "슬라임이 사망했습니다."; } }
            else { ork.hp -= damage1; if (ork.hp <= 0) { label5.Text = "오크가 사망했습니다."; } }
        }




    }
}
