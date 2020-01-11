namespace Material
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tb_ans = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_Score = new System.Windows.Forms.Label();
            this.tb_que = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ans
            // 
            this.tb_ans.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ans.Location = new System.Drawing.Point(824, 332);
            this.tb_ans.MaxLength = 4;
            this.tb_ans.Name = "tb_ans";
            this.tb_ans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_ans.Size = new System.Drawing.Size(227, 59);
            this.tb_ans.TabIndex = 50;
            this.tb_ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ans_KeyDown);
            this.tb_ans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ans_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1254, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tb_question
            // 
            this.tb_question.BackColor = System.Drawing.Color.White;
            this.tb_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_question.Enabled = false;
            this.tb_question.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_question.Location = new System.Drawing.Point(194, 171);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_question.Size = new System.Drawing.Size(575, 347);
            this.tb_question.TabIndex = 46;
            // 
            // tb_Score
            // 
            this.tb_Score.AutoSize = true;
            this.tb_Score.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Score.Location = new System.Drawing.Point(815, 251);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(125, 52);
            this.tb_Score.TabIndex = 45;
            this.tb_Score.Text = "Score";
            // 
            // tb_que
            // 
            this.tb_que.AutoSize = true;
            this.tb_que.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_que.Location = new System.Drawing.Point(815, 171);
            this.tb_que.Name = "tb_que";
            this.tb_que.Size = new System.Drawing.Size(236, 52);
            this.tb_que.TabIndex = 44;
            this.tb_que.Text = "Question No";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(603, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(1128, 21);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(230, 54);
            this.timer.TabIndex = 0;
            this.timer.Text = "Timer- 300";
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(824, 410);
            this.btn_check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(156, 75);
            this.btn_check.TabIndex = 63;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.tb_ans);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_que);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ans;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label tb_Score;
        private System.Windows.Forms.Label tb_que;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button btn_check;

    }
}