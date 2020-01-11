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
    public partial class Form3 : Form
    {
        private int sec;
        private string[,] first = { { "၃၁ရက် ရှိသောလဘယ်နှလရှိသနည်း။", "7" }, 
			{ "၂၈ရက်ရှိသောလမှာ နှစ်တစ်နှစ်ဘယ်နှလပိုင်းဖြစ်သနည်း။", "2" }, 
			{ "နံနက် ၇နာရီခွဲမှမွန်းလွဲ ၁နာရီခွဲအထိအချိန်မည်မျှကြာသနည်း။", "6" }, 
			{ "မွန်းတည့် ၁၂နာရီမှနောက်နေ့နံနက် ၃နာရီထိအချိန်မည်မျှကြာသနည်း။", "15" }, 
			{ "တန်းခူးလတွင် လဆုတ်နေ့မှလကွယ်နေ့အထိရက်ပေါင်းမည်မျှကြာသနည်း။", "14" }, 
			{ "ကဆုန်လတွင် လဆန်းနေ့မှလကွယ်နေ့အထိရက်ပေါင်းမည်မျှကြာသနည်း။", "30" }, 
			{ "မီးရထားတစ်စီးသည်ပထမခရီးကို ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဒုတိယခရီးကို ၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ထိုမီးရထားသည်ခရီးစုစုပေါင်းမည်မျှသွားခဲ့သနည်း။", "2000" }, 
			{ "မီးရထားတစ်စီး ၁၀၀၀ကီလိုမီတာဝေးသောခရီးနှစ်ခုကိုသွားခဲ့သည်။ ပထမခရီးသည် ၅၀၀ကီလိုမီတာကွာဝေးလျှင် ဒုတိယခရီးကိုရှာပါ။","500" }, 
			{ "ပန်းကန်တစ်ချပ်တွင်ပန်းသီး ၅လုံးထည့်လျှင်ပန်းကန် ၉ချပ်တွင်ထည့်ရန်ပန်းသီးမည်မျှလိုသနည်း။",  "45" }, 
			{ "အိတ်ထဲတွင်ဘီစကွတ် မုန့် ၈ခုနှင့်ဘူးထဲတွင်ဘီစကွတ် မုန့် ၃၂ခုရှိသည်။ ဘူးထဲရှိဘီစကွတ်မုန့်သည်အိတ်ထဲရှိဘီစကွတ်မုန့်ထက်ဘယ်နှဆများသနည်း။", "4" }, 
			{ "ကားတစ်စီးသည် ၁၀၀၀ကီလိုမီတာဝေးသောခရီးတစ်ခုကို ၁၀နာရီ့ကြာသွားရသည်။ ထိုကားသည် ၁နာရီတွင်ခရီးမည်မျှသွားခဲ့ရသနည်း။", "100" }, 
			{ "ကားတစ်စီးသည် ပထမခရီးကို ၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဒုတိယခရီးကို ၂၅၀ကီလိုမီတာသွားခဲ့သည်။ တတိယခရီးကို ၂၅၀ကီလိုမီတာသွားခဲ့သည်။ ထိုကားသည်ခရီးစုစုပေါင်းမည်မျှသွားခဲ့သနည်း။", "1000" }, 
			{ "မဆုသည် မုန့်ဖိုး ၅၀၀ကျပ်ရသည်။ ၃၀၀ကျပ်တန်စာအုပ်ဝယ်လိုက်လျှင် သူတွင်ငွေမည်မျှကျန်သနည်း။", "200" },
			{ "ကြိုးတစ်ချောင်းသည် ၁၀စင်တီမီတာရှည်သည်။ ၎င်းကြိုးကို ၁၀စင်တီမီတာရှည်သောကြိုးအပိုင်းလေးများလုပ်မည်ဆိုလျှင်ကြိုးပိုင်းမည်မျှရမည်နည်း။", "1" },
			{"သကြားလုံး ၂၁လုံးရှိသည်။ကလေး ၇ယောက်ကိုအညီအမျှဝေပေးလျှင်ကလေးတစ်ယောက်ကိုသကြားလုံးဘယ်နှစ်လုံးရမည်နည်း။","3"},
			{"အခန်းထဲရှိသောကုလားထိုင် ၃၆လုံးကို ၁တန်းလျှင် ၆လုံးစီတန်းစီသော်အတန်းပေါင်းဘယ်နှစ်တန်းရနိုင်သနည်း။","6"},
			{"ပန်းကန်တစ်ချပ်တွင်ပန်းသီး ၅လုံးစီထည့်မည်။ပန်းကန် ၉ချပ်တွင်ထည့်ရန်ပန်းသီးမည်မျှလိုသနည်း။","45"},
			{"ဘူးတစ်ဘူးတွင်ခဲတံ ၄ချောင်းစီရှိသည်။ဘူး ၁၁ဘူးတွင်ခဲတံမည်မျှရှိသနည်း။","44"},
			{"အအေးကတ် ၁ကတ်တွင်အအေးဘူး ၆ဘူးပါသည်။အအေးကတ် ၃ကတ်တွင် အအေးဘူးမည်မျှပါရှိသနည်း။","18"},
			{"သစ်ကိုင်းတစ်ကိုင်းတွင် ငှက် ၂ကောင်နားနေသည်။ သစ်ကိုင်း ၈ကိုင်းတွင်ငှက်မည်မျှနားနေသနည်း။","16"},
			{"မောင်ကျော်တွင်စုထားသောပိုက်ဆံ ၁၀၀၀ကျပ်ရှိသည်။ ၃၀၀ကျပ်တန်စာအုပ်နှင့် ၂၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်လျှင် မောင်ကျော်ထံတွင်ပိုက်ဆံမည်မျှကျန်သနည်း။", "500" },
			{"မောင်ကျော်တွင်မုန့် ၅ခုရှိသည်။ မဆုတွင်မုန့် ၁၀ခုရှိသည်။ မဆုသည်မောင်ကျော်ထက်မုန့်မည်မျှပိုများသနည်း။","5"},
			{ "၂၉ရက် ရှိသောလဘယ်နှလရှိသနည်း။", "1" }, 
			{ "ဖေဖော်ဝါရီလတွင်ဘယ်နှရက်ရှိသနည်း။", "28" }, 
			{ "မွန်းလွဲ ၁၂နာရီခွဲမှမွန်းလွဲ ၄နာရီခွဲအထိအချိန်မည်မျှကြာသနည်း။", "4" }, 
			{ "မွန်းတည့် ၁၂နာရီမှနောက်နေ့ မွန်းတည့် ၁၂နာရီထိအချိန်မည်မျှကြာသနည်း။", "24" }, 
			{ "တန်းခူးလတွင် လဆန်းနေ့မှလကွယ်နေ့အထိရက်ပေါင်းမည်မျှကြာသနည်း။", "29" }, 
			{ "လေယာဉ်တစ်စီးသည်ပထမခရီးကို ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဒုတိယခရီးကို ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ထိုလေယာဉ်သည်ခရီးစုစုပေါင်းမည်မျှသွားခဲ့သနည်း။", "3000" }, 
			{ "သင်္ဘောတစ်စီး ၅၀၀ကီလိုမီတာဝေးသောခရီးနှစ်ခုကိုသွားခဲ့သည်။ ပထမခရီးသည် ၃၀၀ကီလိုမီတာကွာဝေးလျှင် ဒုတိယခရီးကိုရှာပါ။","200" }, 
			{ "ကားတစ်စီးသည် ၁၀၀၀ကီလိုမီတာဝေးသောခရီးတစ်ခုကို ၂၀နာရီ့ကြာသွားရသည်။ ထိုကားသည် ၁နာရီတွင်ခရီးမည်မျှသွားခဲ့ရသနည်း။", "50" }, 
			{ "မမြင့်သည် မုန့်ဖိုး ၁၅၀၀ကျပ်ရသည်။ ၃၀၀ကျပ်တန်စာအုပ်ဝယ်လိုက်လျှင် သူတွင်ငွေမည်မျှကျန်သနည်း။", "1200" },
			{ "ကြိုးတစ်ချောင်းသည် ၁၀၀စင်တီမီတာရှည်သည်။ ၎င်းကြိုးကို ၁၀စင်တီမီတာရှည်သောကြိုးအပိုင်းလေးများလုပ်မည်ဆိုလျှင်ကြိုးပိုင်းမည်မျှရမည်နည်း။", "10" },
			{"အအေးကတ် ၃ကတ်တွင်အအေးဘူး ၁၈ဘူးပါသည်။အအေးကတ် ၁ကတ်တွင် အအေးဘူးမည်မျှပါရှိသနည်း။","6"},
			{"သစ်ကိုင်းတစ်ကိုင်းတွင် ငှက် ၄ကောင်နားနေသည်။ သစ်ကိုင်း ၁၀ကိုင်းတွင်ငှက်မည်မျှနားနေသနည်း။","40"},
			{"မောင်ကျော်တွင်စုထားသောပိုက်ဆံ ၁၀၀၀ကျပ်ရှိသည်။ ၆၀၀ကျပ်တန်စာအုပ်နှင့် ၂၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်လျှင် မောင်ကျော်ထံတွင်ပိုက်ဆံမည်မျှကျန်သနည်း။", "200" },
			{"မောင်ကျော်တွင်မုန့် ၅ခုရှိသည်။ မဆုတွင်မုန့် ၁၅ခုရှိသည်။ မဆုသည်မောင်ကျော်ထက်မုန့်မည်မျှပိုများသနည်း။","3"} };  

        private List<int> no1 = new List<int>();
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
        private void main()
        {
            for (int j = 0; j < 10; j++)
            {

                int number;
                Random random = new Random();
                do number = random.Next(36);
                while (no1.Contains(number));
                no1.Add(number);
            }

        }
        public Form3()
        {
            main();
            InitializeComponent();
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "5-8";
            this.ActiveControl = tb_ans;
            tb_que.Text = "Question No-1";
            tb_question.Text = first[no1[i], 0];
            tb_socre.Text = "Score-" + score.ToString();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Stop();
            score = 0;
            this.Close();
        }

        private void tb_ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                e.Handled = true;
            if (tb_ans.Text.Equals("0"))
                tb_ans.Text = "";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text == "0" && tb_ans.Text != null)
            {
                tb_ans.Text = "1";
            }
            else
            {
                if (tb_ans.Text.Length < 4)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_ans.Clear();
            tb_ans.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text.Length > 0)
                tb_ans.Text = tb_ans.Text.Substring(0, tb_ans.Text.Length - 1);
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tb_ans.Text) && IsDigitsOnly(tb_ans.Text))
            {
                if (tb_ans.Text.Equals(first[no1[i], 1]))
                {
                    score++;

                }
                else
                {
                    MessageBox.Show("Correct Answer is " + first[no1[i], 1]);
                    tb_ans.Focus();
                }
                i++;
                if (i < 10)
                {
                    tb_que.Text = "Question No-" + (i + 1).ToString();
                    tb_question.Text = first[no1[i], 0];
                    tb_socre.Text = "Score-" + score.ToString();
                    tb_ans.Clear();
                }
                else
                {
                    ScoreBoard sc = new ScoreBoard(score);
                    timer1.Stop();
                    sc.Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Invalid");

        }

        private void tb_ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_check.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            timer.Text = "Timer- " + (60*5 - sec).ToString();
            if (60 * 5 - sec <= 30)
            {
                timer.ForeColor = System.Drawing.Color.Red;
            }
            if (sec.Equals(60*5))
            {
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
