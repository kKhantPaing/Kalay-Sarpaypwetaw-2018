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
    public partial class ScoreBoard : Form
    {
        private int sc;
        private int a = Convert.ToInt32(Form1.age);
        public ScoreBoard(int score)
        {
            main(score);
            InitializeComponent();
        }
        private int main(int score) {
            if (score == 10)
                sc = 2;
            else if (score < 10 && score > 4)
                sc = 1;
            else
                sc = 0;
            return sc;
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            this.Text = "Score Board";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lb_name.Text = Form1.name;
            if (a <= 5)
            {
                lb_score.Text = "Your Score is " + Form2.score.ToString()+" of 10";
                Form2.score = 0;
            }
            else if (5 < a && a <= 8)
            {
                lb_score.Text = "Your Score is " + Form3.score.ToString()+" of 10";
                Form3.score = 0;
            }else if (8 < a && a <= 12)
            {
                lb_score.Text = "Your Score is " + Form4.score.ToString() + " of 10";
                Form4.score = 0;
            }
            else
            {
                lb_score.Text = "Your Score is " + Form5.score.ToString() + " of 10";
                Form5.score = 0;
            }
            if (sc.Equals(2))
                textName.Text = "Congratulations!You got a book and pen!";
            else if (sc.Equals(1))
                textName.Text = "Congratulations! You got a book!";
            else
                textName.Text = "Nice Try! Good Luck Next time.";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
