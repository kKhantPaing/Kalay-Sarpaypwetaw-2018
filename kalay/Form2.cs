using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material
{
    public partial class Form2 : Form
    {
        private int sec;
        private string[,] ar = { {"fruits.jpg","ခြင်းထဲတွင်ရှိသောသစ်သီးအရေအတွက်ကိုဖြေပါ။","5"},
				{"fruits.jpg","ပုံတွင်ပါမတူညီသောအရောင်အရေအတွက်ကိုဖြေပါ။","6"},
				{"orange box.jpg","လိမ္မော်သီးထည့်ထားသောသေတ္တာဘယ်နှလုံးရှိသနည်း။","3"},
				{"orange.jpg","သေတ္တာထဲတွင်ရှိသောလိမ္မော်သီးအရေအတွက်ကိုဖြေပါ။","12"},
				{"traff.jpg","ပုံတွင်ပါသောစက်ဝိုင်းအရေအတွက်ကိုဖြေပါ။","3"},
				{"traff.jpg","ပုံတွင်ပါသောမတူညီသောအရောင်အရေအတွက်ကိုဖြေပါ။","3"},
				{"traffic light.jpg","ပုံတွင်ပါသောစက်ဝိုင်းအရေအတွက်ကိုဖြေပါ။","9"},
				{"traffic light.jpg","ပုံတွင်ပါသောမတူညီသောအရောင်အရေအတွက်ကိုဖြေပါ။","5"},
				{"traffic light.jpg","ပုံတွင်ပါသောတြိဂံအရေအတွက်ကိုဖြေပါ။","0"},
				{"traff.jpg","ပုံတွင်ပါသောတြိဂံအရေအတွက်ကိုဖြေပါ။","1"},
				{"traffic.jpg","ပုံတွင်ပါသောတြိဂံအရေအတွက်ကိုဖြေပါ။","0"}, 
				{"traffic.jpg","ပုံတွင်ပါသောစက်ဝိုင်းအရေအတွက်ကိုဖြေပါ။","12"},
				{"tri.jpg","ပုံတွင်ပါသောတြိဂံအရေအတွက်ကိုဖြေပါ။","3"},
				{"circle.jpg","ပုံတွင်ပါသောစက်ဝိုင်းအရေအတွက်ကိုဖြေပါ။","5"},
				{"circle.jpg","ပုံတွင်ပါသောမတူညီသောအရောင်အရေအတွက်ကိုဖြေပါ။","3"} 
            };
        private List<int> no = new List<int>();
        private int i = 0;
        public static int score = 0;
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void main() {
            for (int i = 0; i < 10; i++)
            {
                int number;
                Random random = new Random();
                do number = random.Next(15);
                while (no.Contains(number));
                no.Add(number);
            }
        
        }
        public Form2()
        {
            main();
            InitializeComponent();
            timer1.Start();
            this.ActiveControl = tb_ans;
                    }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "<5";
            lb_que.Text = "Question No-1";
            lb_score.Text = "Score-"+score.ToString();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            String st = "C:/Users/KKP/Desktop/My Data/kalay/5/" + ar[no[0], 0];
            tb_question.Text=ar[no[0],1];
            Bitmap q = new Bitmap(st);
            pictureBox1.Image = q;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            f1.Show();
            timer1.Stop();
            score = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_ans.Text) && IsDigitsOnly(tb_ans.Text))
            {
                if (tb_ans.Text.Equals(ar[no[i], 2]))
                {
                    score++;

                }
                else
                    MessageBox.Show("Correct Answer is " + ar[no[i], 2]);
                
                i++;
                if (i < 10)
                {
                    lb_que.Text = "Question No-" + (i + 1).ToString();
                    lb_score.Text ="Score-" +score.ToString();
                    String st = "C:/Users/KKP/Desktop/My Data/kalay/5/" + ar[no[i], 0];
                    tb_question.Text = ar[no[i], 1];
                    Bitmap q = new Bitmap(st);
                    pictureBox1.Image = q;
                    tb_ans.Clear();
                    tb_ans.Focus();
                }
                else
                {
                    ScoreBoard sc = new ScoreBoard(score);
                    sc.Show();
                    this.Close();
                }
            }
            else
            {
                tb_ans.Focus();
                MessageBox.Show("Invalid");
            }
        }

        private void tb_ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                e.Handled = true;        
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "1";
            }
            else
            {
                if(tb_ans.Text.Length<4)
                tb_ans.Text = tb_ans.Text + "1";
            }  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "2";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "3";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "4";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "5";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "6";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "7";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "8";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "9";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "0";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
                tb_ans.Text = tb_ans.Text + "0";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text.Length > 0)
            
                tb_ans.Text = tb_ans.Text.Substring(0, tb_ans.Text.Length - 1);
                tb_ans.Focus();    
            
        }

        private void tb_ans_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                e.Handled = true;
            if (tb_ans.Text.Equals("0"))
                tb_ans.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_ans.Clear();
            tb_ans.Focus();
        }

        private void tb_ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_check.PerformClick();            
        }

        private void tb_question_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            timer.Text ="Timer- "+(60*5-sec).ToString();
            if (60 * 5 - sec<=30)
            {
                timer.ForeColor = System.Drawing.Color.Red;
            }
            if (sec.Equals(60*5)) {
                timer1.Stop();
                MessageBox.Show("Time Up!");
                ScoreBoard sc = new ScoreBoard(score);
                sc.Show();
                timer.ForeColor = System.Drawing.Color.Black;
                this.Close();
            }
        }

        
       }
}
