using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var randNum = new Random();
            var dice = new int[3];
            var sum = 0;

            for (int rollingDice = 0; rollingDice < 3; rollingDice++)
            {
                dice[rollingDice] = randNum.Next(1, 7);
                sum += dice[rollingDice];
            }

            DiceNumber1.Text = dice[0].ToString();
            DiceNumber2.Text = dice[1].ToString();
            DiceNumber3.Text = dice[2].ToString();

            DiceSum.Text = "Sum = " + sum;

            if(dice[0]==dice[1] && dice[0] == dice[2])
            {
                DiceEqual.Text = "You've got a three of a kind!";
            }
            else if (dice[0]==dice[1] || dice[0] == dice[2]|| dice[1] == dice[2])
            {
                DiceEqual.Text = "You've got a pair!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiceNumber1.Text = "";
            DiceNumber2.Text = "";
            DiceNumber3.Text = "";
            DiceSum.Text = "";
            DiceEqual.Text = "";

        }
    }
}
