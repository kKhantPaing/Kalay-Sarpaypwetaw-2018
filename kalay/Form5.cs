using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material
{
    public partial class Form5 : Form
    {
        private int sec;
        private int i = 0;
        public static int score = 0;
        private string[,] q = {{"How many sec in 8 min 20 s?","500"},
{"How many grams in 2.5 kilograms?","2500"},
{"0.84 + 0.16 = ?","1"},
{"3.93 + 1.07 = ?","5"},
{"25% of 28 is ______.","7"},
{"5 divided by 37 =?","0"},
{"The remainder of 48 divided by 4 is?","0"},
{"How many days in Feb if the year is 2200?","28"},
{"What is the leap year? Answer in (2100 ,2200, 2300, 2400)","2400"},
{"Anna had $60 she gives harry the same amout of her. how much did harry get?","60"},
{"David has $5000 to buy five cycles. If he bought a Laptop worth $4750, how many cycles would he buy?","0"},
{"What is the length of Hypotenuse of a Right Triangle if other two sides have 3 and 4 ?","5"},
{"An angle of a square is?","90"},
{"A clock strikes once at 1 o’clock, twice at 2 o’clock, thrice at 3 o’clock and so on. How many times will it strike in 24 hours?","156"},
{"Which of the following numbers gives 240 when added to its own square? Hint: Answer in(14, 15, 16, 17).","15"},
{"Evaluation of 8 power 3 × 8 power 2 × 8 power(-5) is ………….","1"},
{"The cube root of 1331 is ………… . Hint: Answer in(11, 13, 17, 19)","11"},
{"'Whole Number' is started from ………….","0"},
{"1 power 0 is equal to …………. ","1"},
{"What is the greatest four digit number?","9999"},
{"What is the smallest three digit number?","100"},
{"What is 1000 × 1 equal to?","1000"},
{"In 24,673 ; the place-value of 6 is ….. ","600"},
{"In 24,673 ; the face-value of 4 is ….. .","4"},
{"The difference between the smallest number of four digits and the largest number of three digits is ……. .","1"},
{"Complete the sequence 13, 16, ……, 22.","19"},
{"What is the sum of one digit prime numbers?","17"},
{"How many minutes in 1.5 hours?","90"},
{"David's age is 6 when Anna is 12. What is David's age if Anna is 66?","60"},
{"Susan's age is 3 when Louis is 6. What is Louis's age if Susan is 70?","73"},
{"How many angles are equal in 'Isosceles Triangle'?","2"},
{"In 'Isosceles Right-Triangle', what is non-right angle's degree?","45"},
{"How many digits answer we will get when we add 99 and 1?","3"},
{"Victor selects a card at random from a deck of playing cards. Victor wins if the card is a Heart or a King. How many elements are there in the sample space?","52"},
{"A code consists of a letter of the alphabet followed by a two-digit number (including 00) The code is a winner if the letter is a vowel and the two-digit number is greater than 90. How many elements are there in the sample space?","2600"}};
        private List<int> no = new List<int>();
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void main()
        {
            for (int j = 0; j < 10; j++)
            {

                int number;
                Random random = new Random();
                do number = random.Next(35);
                while (no.Contains(number));
                no.Add(number);

            }

        }
        public Form5()
        {
            main();
            InitializeComponent();
            timer1.Start();
            this.ActiveControl = tb_ans;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tb_ans;
            this.Text = "12<";
            tb_que.Text = "Question No-1";
            tb_Score.Text = "Score-"+score.ToString();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            tb_question.Text = q[no[i], 0];
        }

        
        
        private void tb_ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;                        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Stop();
            score = 0;
            this.Close();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            timer.Text ="Timer- "+(300-sec).ToString();
            if (300 - sec<=30)
            {
                timer.ForeColor = System.Drawing.Color.Red;
            }
            if (sec.Equals(300)) {
                timer1.Stop();
                MessageBox.Show("Time Up!");
                ScoreBoard sc = new ScoreBoard(score);
                sc.Show();
                timer.ForeColor = System.Drawing.Color.Black;
                this.Close();
            }
        }


        private void btn_check_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tb_ans.Text) && IsDigitsOnly(tb_ans.Text))
            {
                if (tb_ans.Text.Equals(q[no[i], 1]))
                {
                    score++;

                }
                else
                {
                    MessageBox.Show("Correct Answer is " + q[no[i], 1]);
                    tb_ans.Focus();
                }
                i++;
                if (i < 10)
                {

                    tb_que.Text = "Question No " + (i + 1).ToString();
                    tb_Score.Text = "Score-" + score.ToString();
                    tb_question.Text = q[no[i], 0];
                    tb_ans.Clear();
                    tb_ans.Focus();
                }
                else
                {
                    ScoreBoard soc = new ScoreBoard(score);
                    timer1.Stop();
                    soc.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid");
                tb_ans.Focus();
            }
        }

        private void tb_ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_check.PerformClick();
        }


        }

    }
