namespace Material
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_age = new System.Windows.Forms.TextBox();
            this.btn_ex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.AutoSize = true;
            this.btn_play.BackColor = System.Drawing.Color.OldLace;
            this.btn_play.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(451, 557);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(308, 62);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1482, 813);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 27);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // TB_name
            // 
            this.TB_name.BackColor = System.Drawing.Color.FloralWhite;
            this.TB_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_name.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_name.Location = new System.Drawing.Point(643, 301);
            this.TB_name.MaxLength = 100;
            this.TB_name.Name = "TB_name";
            this.TB_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_name.Size = new System.Drawing.Size(408, 59);
            this.TB_name.TabIndex = 9;
            this.TB_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_name_KeyDown);
            // 
            // TB_age
            // 
            this.TB_age.BackColor = System.Drawing.Color.FloralWhite;
            this.TB_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_age.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_age.Location = new System.Drawing.Point(643, 414);
            this.TB_age.MaxLength = 2;
            this.TB_age.Name = "TB_age";
            this.TB_age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TB_age.Size = new System.Drawing.Size(116, 59);
            this.TB_age.TabIndex = 10;
            this.TB_age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_age_KeyDown);
            this.TB_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_age_KeyPress);
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(1248, 708);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(75, 23);
            this.btn_ex.TabIndex = 12;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.TB_age);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_play);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_age;
        private System.Windows.Forms.Button btn_ex;

    }
}

