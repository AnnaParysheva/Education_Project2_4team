﻿namespace Education_Project2_4team
{
    partial class Authorization
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
            this.label_Authorization = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnLogInAsAnAdministrtion = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Authorization
            // 
            this.label_Authorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Authorization.BackColor = System.Drawing.SystemColors.Info;
            this.label_Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Authorization.Location = new System.Drawing.Point(248, 35);
            this.label_Authorization.Name = "label_Authorization";
            this.label_Authorization.Size = new System.Drawing.Size(274, 37);
            this.label_Authorization.TabIndex = 0;
            this.label_Authorization.Text = "Авторизация";
            this.label_Authorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxLogin.Location = new System.Drawing.Point(301, 150);
            this.txtBoxLogin.Multiline = true;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(308, 36);
            this.txtBoxLogin.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPassword.Location = new System.Drawing.Point(301, 248);
            this.txtBoxPassword.Multiline = true;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '•';
            this.txtBoxPassword.Size = new System.Drawing.Size(308, 34);
            this.txtBoxPassword.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Orange;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(301, 312);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(151, 44);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnLogInAsAnAdministrtion
            // 
            this.btnLogInAsAnAdministrtion.BackColor = System.Drawing.Color.Orange;
            this.btnLogInAsAnAdministrtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInAsAnAdministrtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogInAsAnAdministrtion.Location = new System.Drawing.Point(480, 312);
            this.btnLogInAsAnAdministrtion.Name = "btnLogInAsAnAdministrtion";
            this.btnLogInAsAnAdministrtion.Size = new System.Drawing.Size(169, 44);
            this.btnLogInAsAnAdministrtion.TabIndex = 4;
            this.btnLogInAsAnAdministrtion.Text = "Войти как администратор";
            this.btnLogInAsAnAdministrtion.UseVisualStyleBackColor = false;
            this.btnLogInAsAnAdministrtion.Click += new System.EventHandler(this.btnLogInAsAnAdministrator_Click);
            // 
            // btn_register
            // 
            this.btn_register.AutoSize = true;
            this.btn_register.BackColor = System.Drawing.Color.Orange;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_register.Location = new System.Drawing.Point(370, 373);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(181, 42);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Зарегистрироваться";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(301, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Введите логин:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(301, 216);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Введите пароль:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Education_Project2_4team.Properties.Resources.Замок;
            this.pictureBox1.Location = new System.Drawing.Point(12, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(615, 254);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(157, 20);
            this.checkBoxShowPassword.TabIndex = 22;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btnLogInAsAnAdministrtion);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.label_Authorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authorization";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Authorization;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnLogInAsAnAdministrtion;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}

