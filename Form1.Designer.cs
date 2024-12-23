namespace ElectronicDiary
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.buttonLogin_Click = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.Authorization = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(298, 189);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(205, 20);
            this.textBoxPassword.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(231, 196);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(45, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(298, 153);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(205, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(231, 160);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(38, 13);
            this.Login.TabIndex = 3;
            this.Login.Text = "Логин";
            // 
            // buttonLogin_Click
            // 
            this.buttonLogin_Click.Location = new System.Drawing.Point(298, 215);
            this.buttonLogin_Click.Name = "buttonLogin_Click";
            this.buttonLogin_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin_Click.TabIndex = 4;
            this.buttonLogin_Click.Text = "Войти";
            this.buttonLogin_Click.UseVisualStyleBackColor = true;
            this.buttonLogin_Click.Click += new System.EventHandler(this.buttonLogin_Click_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(379, 215);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(124, 23);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(295, 251);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(91, 13);
            this.linkLabelForgotPassword.TabIndex = 6;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Забыли пароль?";
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(413, 251);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(90, 13);
            this.linkLabelChangePassword.TabIndex = 7;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Сменить пароль";
            // 
            // Authorization
            // 
            this.Authorization.AutoSize = true;
            this.Authorization.Enabled = false;
            this.Authorization.Location = new System.Drawing.Point(361, 115);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(73, 13);
            this.Authorization.TabIndex = 8;
            this.Authorization.Text = "Авторизация";
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(509, 192);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShowPassword.TabIndex = 9;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.linkLabelChangePassword);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin_Click);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormLogin";
            this.Text = "Login";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button buttonLogin_Click;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
        private System.Windows.Forms.Label Authorization;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}

