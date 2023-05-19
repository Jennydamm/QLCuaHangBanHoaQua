
namespace QLcuahangbanhoaqua
{
    partial class fLogin
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
            this.lbUserNmae = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserNmae
            // 
            this.lbUserNmae.AutoSize = true;
            this.lbUserNmae.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNmae.Location = new System.Drawing.Point(23, 25);
            this.lbUserNmae.Name = "lbUserNmae";
            this.lbUserNmae.Size = new System.Drawing.Size(200, 29);
            this.lbUserNmae.TabIndex = 0;
            this.lbUserNmae.Text = "Tên đăng nhập: ";
            this.lbUserNmae.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(194, 25);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(283, 26);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(23, 12);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(132, 29);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Mật khẩu: ";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(218, 12);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(259, 26);
            this.txbPassWord.TabIndex = 3;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btLogin.Location = new System.Drawing.Point(266, 209);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(109, 47);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Location = new System.Drawing.Point(409, 210);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 46);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Location = new System.Drawing.Point(363, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 313);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPassword);
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Location = new System.Drawing.Point(75, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 61);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbUserNmae);
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Location = new System.Drawing.Point(75, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 69);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserNmae;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}