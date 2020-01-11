using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material

{
    public partial class Form1 : Form
    {
        public static string type = "";
        public static string age = "";
        public static string name = "";

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = TB_name;
            /*MaterialSkinManager material = MaterialSkinManager.Instance;
            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.LIGHT;
            material.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );*/
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name = TB_name.Text;
            age = TB_age.Text;


            if (!string.IsNullOrWhiteSpace(TB_age.Text) && !string.IsNullOrWhiteSpace(TB_name.Text))
            {
                if (IsDigitsOnly(TB_age.Text))
                {
                    int a = Convert.ToInt32(age);
                    if (a >= 3 && a <= 5)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        TB_name.Focus();
                        this.Hide();

                    }
                    else if (5 < a && a <= 8)
                    {
                        Form3 f3 = new Form3();
                        f3.Show();
                        TB_name.Focus();
                        this.Hide();
                    }
                    else if (8 < a && a <= 12)
                    {
                        Form4 f4 = new Form4();
                        TB_name.Focus();
                        this.Hide(); 
                        f4.Show();
                    }
                    else if (a > 12)
                    {
                        Form5 f5 = new Form5();
                        TB_name.Focus();
                        this.Hide();
                        f5.Show();
                    }
                    else
                        MessageBox.Show("Age must be greather than 3!");
                    TB_name.Clear();
                    TB_age.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Age");
                    TB_name.Clear();
                    TB_age.Clear();
                    TB_name.Focus();
                }
            }
            else
            {
                MessageBox.Show("Missing Values");
                TB_name.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

      
        private void TB_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                e.Handled = true;
        
        }

        private void TB_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter||e.KeyCode==Keys.Tab)
                TB_age.Focus();

        }

        private void TB_age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_play.PerformClick();
            else
            {
                if (e.KeyCode == Keys.Tab)
                    btn_play.Focus();
            }
           }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
