namespace labRybakov
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.InputLogin = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.sendDate = new System.Windows.Forms.Button();
            this.passVisible = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // InputLogin
            // 
            this.InputLogin.Location = new System.Drawing.Point(200, 232);
            this.InputLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.Size = new System.Drawing.Size(187, 26);
            this.InputLogin.TabIndex = 1;
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(200, 277);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(187, 26);
            this.InputPassword.TabIndex = 2;
            this.InputPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(107, 280);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(65, 18);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(107, 235);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(40, 18);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            // 
            // sendDate
            // 
            this.sendDate.Location = new System.Drawing.Point(193, 350);
            this.sendDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendDate.Name = "sendDate";
            this.sendDate.Size = new System.Drawing.Size(244, 61);
            this.sendDate.TabIndex = 5;
            this.sendDate.Text = "Авторизоваться";
            this.sendDate.UseVisualStyleBackColor = true;
            this.sendDate.Click += new System.EventHandler(this.sendDate_Click);
            // 
            // passVisible
            // 
            this.passVisible.AutoSize = true;
            this.passVisible.Location = new System.Drawing.Point(422, 279);
            this.passVisible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passVisible.Name = "passVisible";
            this.passVisible.Size = new System.Drawing.Size(133, 22);
            this.passVisible.TabIndex = 6;
            this.passVisible.Text = "Показать пароль";
            this.passVisible.UseVisualStyleBackColor = true;
            this.passVisible.CheckedChanged += new System.EventHandler(this.passVisible_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(639, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passVisible);
            this.Controls.Add(this.sendDate);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Лаборатория №20\" - Авторизациия";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputLogin;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button sendDate;
        private System.Windows.Forms.CheckBox passVisible;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

