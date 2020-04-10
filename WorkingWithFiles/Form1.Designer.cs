namespace WorkingWithFiles
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnRegister);
            this.pnlButtons.Controls.Add(this.btnLogin);
            this.pnlButtons.Controls.Add(this.panel1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(221, 514);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.Location = new System.Drawing.Point(0, 139);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(221, 38);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.Location = new System.Drawing.Point(0, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(221, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 100);
            this.panel1.TabIndex = 1;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnCan);
            this.pnlRegister.Controls.Add(this.btnReg);
            this.pnlRegister.Controls.Add(this.txtRePass);
            this.pnlRegister.Controls.Add(this.txtPass);
            this.pnlRegister.Controls.Add(this.txtUser);
            this.pnlRegister.Controls.Add(this.txtCon);
            this.pnlRegister.Controls.Add(this.txtName);
            this.pnlRegister.Controls.Add(this.txtSurname);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.label3);
            this.pnlRegister.Controls.Add(this.label2);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRegister.Location = new System.Drawing.Point(230, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(563, 514);
            this.pnlRegister.TabIndex = 1;
            this.pnlRegister.Visible = false;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(184, 297);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(121, 33);
            this.btnCan.TabIndex = 13;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(45, 297);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(121, 33);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(194, 235);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(100, 22);
            this.txtRePass.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 188);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 10;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(194, 147);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 9;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(194, 108);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 22);
            this.txtCon.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(194, 37);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Comfirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contanct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLog);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Controls.Add(this.label8);
            this.pnlLogin.Controls.Add(this.label7);
            this.pnlLogin.Location = new System.Drawing.Point(227, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(566, 514);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(197, 99);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(70, 209);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(227, 23);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 514);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLog;
    }
}

