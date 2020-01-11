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
    public partial class Form4 : Form
    {
        private int sec;
        private string[,] q = { { "မီးရထားတစ်စီးသည်မေလတွင် ၃၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဇွန်လတွင် ၂၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဇူလိုင်လတွင် ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ထိုမီးရထားသည် မေလနှင့်ဇွန်လတွင်သွားခဲ့သောခရီးကိုရှာပါ။", "6000" }, 
			{ "မထက်သည် ၅၀၀ကျပ်တန်စာအုပ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်ပြီးနောက် ၂၀၀ကျပ်ကျန်လျှင် ယခုသူမတွင်ရှိသောငွေကိုဖြေပါ။", "200" }, 
			{ "မောင်ထက်သည်မုန့်ဖိုးရပြီးနောက် ၁၀၀၀ကျပ်တန်စာအုပ်နှင့် ၅၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်သည်။သူထံတွင် ၅၀၀ကျပ်ကျန်လျှင် သူမုန့်ဖိုးမည်မျှရသနည်း။", "2000" }, 
			{ "ကားတစ်စီးသည် ပထမခရီးကို ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဒုတိယခရီးကို ၁၀၀၀ကီလိုမီတာသွားခဲ့သည်။ တတိယခရီးကို ၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ထိုကားနောက်ဆုံးခရီးတွင်မည်မျှသွားခဲ့သနည်း။", "500" }, 
			{ "ကားတစ်စီးသည်တစ်နာရီ ၅၀ကီလိုမီတာြဖင့်မောင်းနေသည်။ ၁၀နာရီတွင်သူခရီးမည်မျှမောင်းခဲ့သနည်း။", "500" }, 
			{ "ကားတစ်စီးသည် ၅၀၀ကီလိုမီတာသွားပြီးတိုင်းဆီတစ်ခါဖြည့်ရသည်။ ၁၇၀၀ကီလိုမီတာခရီးတွင်ဆီဘယ်နှခါဖြည့်ခဲ့ရသနည်း၊", "3" }, 
			{ "မလှသည်ဈေးထဲတွင် ကြက်သား ၁၀ကျပ်သားလျှင်၁၀၀၀ကျပ်ဖြင့် ၅၀ကျပ်သားဝယ်ခဲ့သည်။ ကန်ဇွန်းရွက် ၁စီးလျှင် ၃၀၀ကျပ်ဖြင့် ၅စီးဝယ်လာခဲ့သည်။ စုစုပေါင်းမည်မျှကုန်ကျသနည်း။", "6500" }, 
			{ "ဦးလှသည်သကြားလုံး ၁၀၀လုံးကို ကလေး ၉ယောက်အားအညီအမျှဝေပေးလျှင်သူထံတွင်သကြားလုံးမည်မျှကျန်သနည်း။", "1" }, 
			{ "ဆိုင်ကယ်တစ်စီးသည် ၃နာရီတွင် ၁၅၀ကီလိုမီတာသွားခဲ့သည်။ နောက် ၃နာရီတွင် ၂၁၀ကီလိုမီတာရောက်ခဲ့သည်။ ထိုဆိုင်ကယ်သည်တစ်နာရီမည်မျှသွားခဲ့သနည်း။ ", "60" }, 
			{ "ကုန်တင်ကားတစ်စီးသည်ဇန်နဝါရီလတွင် ၂၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဖေဖော်ဝါရီလတွင် ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ မတ်လတွင် ၁၀၀၀ကီလိုမီတာသွားခဲ့သည်။ထိုကုန်တင်ကားသည် ထို၃လတွင်သွားခဲ့သောခရီးကိုရှာပါ။", "5000" }, 
			{ "မအေးတွင် ၁၀၀၀ကျပ်ရှိသည်။ ၄၅၀ကျပ်တန်စာအုပ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်ပြီးနောက် ၂၅၀ကျပ်ကျန်လျှင် ယခင်ကသူမတွင်ရှိသောငွေကိုဖြေပါ။", "1000" },
			{ "မောင်လှသည်မုန့်ဖိုးရပြီးနောက် ၁၀၀၀ကျပ်တန်စာအုပ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်သည်။သူသည် ၅၀၀ကျပ်စုလိုက်လျှင် သူစုသောငွေကိုရှာပါ။", "500" }, 
			{ "မော်တော်ကားတစ်စီးသည်တစ်နာရီ ၁၀၀ကီလိုမီတာြဖင့်မောင်းနေသည်။ ၃၀မိနစ်တွင်သူခရီးမည်မျှမောင်းခဲ့သနည်း။", "50" }, 
			{ "ကားတစ်စီးသည် ၁၅၀၀ကီလိုမီတာခရီးတွင် ဆီ ၃ခါဖြည့်ရသည်။ ခရီးမည်မျှသွားပြီးတိုင်း ဆီတစ်ခါဖြည့်ခဲ့ရသနည်း၊", "500" }, 
			{ "ဦးလှသည်ကလေး ၉ယောက်အားတစ်ယောက်လျှင်သကြားလုံး ၁၁လုံးအညီအမျှဝေပေးပြီးနောက်သူထံတွင်သကြားလုံး ၁လုံးကျန်သည်။ ဦးလှတွင်မူလကသကြားလုံးမည်မျှရှိသနည်း။", "100" }, 
			{ "ဆိုင်ကယ်တစ်စီးသည် ၃နာရီတွင် ၁၀၀ကီလိုမီတာသွားခဲ့သည်။ ထိုဆိုင်ကယ်သည်တစ်နာရီတွင်ပျမ်းမျှ ၆၀ကီလိုမီတာသွားခဲ့လျှင် ၆နာရီတွင်ရောက်ခဲ့သောခရီးကိုရှာပါ။ ", "360" },
			{ "မီးရထားတစ်စီးသည်မေလတွင် ၃၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဇွန်လနှင့် ဇူလိုင်လတွင် ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ထိုမီးရထားသည် ထို ၃လတွင်သွားခဲ့သောခရီးကိုရှာပါ။", "5000" }, 
			{ "အိမ့်မြတ်မွန်သည် ၃၀၀၀ကျပ်တန်လွယ်အိတ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်ပြီးနောက် ၂၀၀ကျပ်ကျန်လျှင် ယခုသူမတွင်ရှိသောငွေကိုဖြေပါ။", "200" }, 
			{ "မောင်ထက်သည်မုန့်ဖိုးရပြီးနောက် ၁၀၀၀ကျပ်တန်စာအုပ်နှင့် ၅၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်သည်။သူထံတွင် ၁၀၀၀ကျပ်ကျန်လျှင် သူမုန့်ဖိုးမည်မျှရသနည်း။", "2500" }, 
			{ "ကားတစ်စီးသည် ပထမခရီးကို ၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ဒုတိယခရီးကို ၂၀၀၀ကီလိုမီတာသွားခဲ့သည်။ တတိယခရီးကို ၁၅၀၀ကီလိုမီတာသွားခဲ့သည်။ ထိုကားသည် ပထမခရီးတွင်မည်မျှသွားခဲ့သနည်း။", "500" }, 
			{ "တစ်နာရီ ၆၀ကီလိုမီတာြဖင့်မောင်းနေသောကားသည် ၁၂နာရီတွင်ခရီးမည်မျှမောင်းခဲ့သနည်း။", "720" }, 
			{ "မလှသည်ဆိုင်တစ်ဆိုင်တွင် စာအုပ် ၁အုပ်လျှင်၁၀၀၀ကျပ်ဖြင့် ၅အုပ်ဝယ်ခဲ့သည်။ ဘောပင် ၁ချောင်းလျှင် ၃၀၀ကျပ်ဖြင့် ၁၀ချောင်းဝယ်လာခဲ့သည်။ စုစုပေါင်းမည်မျှကုန်ကျသနည်း။", "8000" }, 
			{ "ဦးမြသည်သကြားလုံး ၁၀၀လုံးကို ကလေး ၁၀ယောက်အားအညီအမျှဝေပေးလျှင်သူထံတွင်သကြားလုံးမည်မျှကျန်သနည်း။", "0" }, 
			{ "ဆိုင်ကယ်တစ်စီးသည် ၁၅၀ကီလိုမီတာကို ၅နာရီသွားရသည်။ နောက် ၅နာရီတွင် ၃၅၀ကီလိုမီတာသွားခဲ့သည်။ ထိုဆိုင်ကယ်သည်တစ်နာရီမည်မျှသွားခဲ့သနည်း။ ", "50" }, 
			{"ကျောင်းတစ်ကျောင်းတွင် ကျောင်းသားဉီးရေသည်ကျောင်းသူဉီးရေထက် ၅၀ယောက်ပိုများသည်။ ထိုကျောင်းတွင် ကျောင်းသား ၂၅၀ယောင်ရှိလျှင် ကျောင်းသူမည်မျှရှိသနည်း။","200"},
			{"မောင်မောင်သည်ခဲတံတစ်ချောင်း ၅၀၀ကျပ်ဖြင့်ဝယ်ခဲ့သည်။ သူသည်ထိုခဲတံကိုမလှအား ၇၅၀ကျပ်ဖြင့်ရောင်းလိုက်လျှင်သူမြတ်သောငွေကိုရှာပါ။","250"},
			{ "အိမ့်မြတ်မွန်သည် ၃၀၀ကျပ်တန်ခဲဖျတ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်ပြီးနောက် ၂၀၀ကျပ်ကျန်လျှင် ယခင်ကသူမတွင်ရှိသောငွေကိုဖြေပါ။", "800" }, 
			{ "မောင်ထက်သည်မုန့်ဖိုးရပြီးနောက် ၁၀၀၀ကျပ်တန်စာအုပ်နှင့် ၅၀၀ကျပ်တန်ဘောပင်ဝယ်လိုက်သည်။သူထံတွင် ၁၀၀၀ကျပ်ကျန်လျှင် သူထံတွင်ငွေမည်မျှရှိမည်နည်း။", "1000" }, 
			{ "မထက်သည် ၅၀၀ကျပ်တန်စာအုပ်နှင့် ၃၀၀ကျပ်တန်ဘောပင်ဝယ်ပြီးနောက် ၂၀၀ကျပ်ကျန်လျှင် စာအုပ်တန်ဖိုးကိုဖြေပါ။", "500" }, 
			{ "မောင်ထက်သည်မုန့်ဖိုးရပြီးနောက် ၁၀၀၀ကျပ်တန်ဘောပင်တစ်ချောင်းနှင့် ၅၀၀ကျပ်တန်ဘောပင်တစ်ချောင်းဝယ်လိုက်သည်။သူထံတွင် ၅၀၀ကျပ်ကျန်လျှင် သူမုန့်ဖိုးမည်မျှရသနည်း။", "2000" }};
        private List<int> no = new List<int>();
        public static int score = 0;
        private int i = 0;
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
                do number = random.Next(30);
                while (no.Contains(number));
                no.Add(number);

            }

        }
        public Form4()
        {
            main();
            InitializeComponent();
            timer1.Start();
            this.ActiveControl = tb_ans;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "9-12";
            tb_que.Text = "Question No-1";
            tb_Score.Text = "Score-" + score.ToString();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            tb_question.Text = q[no[i], 0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Stop(); 
            score = 0;
            this.Close();
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

        private void btn_AC_Click(object sender, EventArgs e)
        {
            tb_ans.Clear();
            tb_ans.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (tb_ans.Text.Length > 0)
                tb_ans.Text = tb_ans.Text.Substring(0, tb_ans.Text.Length - 1);
            tb_ans.Focus();
        }

        private void btn_check_Click(object sender, EventArgs e)
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
                    tb_que.Text = "Question No-" + (i + 1).ToString();
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
                tb_ans.Focus();
                MessageBox.Show("Invalid");
            }
        }

        private void tb_ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
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
