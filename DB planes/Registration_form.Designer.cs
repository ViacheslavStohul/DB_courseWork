namespace DB_planes
{
    partial class Registration_form
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
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Date_of_Birth_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Password_Repeat_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(412, 14);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 35);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я користувача";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(32, 99);
            this.Username_TextBox.MaxLength = 30;
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(196, 26);
            this.Username_TextBox.TabIndex = 2;
            this.Username_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(32, 181);
            this.Password_TextBox.MaxLength = 30;
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(196, 26);
            this.Password_TextBox.TabIndex = 4;
            this.Password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ім\'я";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(328, 99);
            this.FirstName_TextBox.MaxLength = 30;
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(196, 26);
            this.FirstName_TextBox.TabIndex = 6;
            this.FirstName_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Прізвище";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(328, 181);
            this.LastName_TextBox.MaxLength = 40;
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(196, 26);
            this.LastName_TextBox.TabIndex = 8;
            this.LastName_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вік (не обов\'язково)";
            // 
            // Date_of_Birth_TextBox
            // 
            this.Date_of_Birth_TextBox.Location = new System.Drawing.Point(328, 258);
            this.Date_of_Birth_TextBox.Name = "Date_of_Birth_TextBox";
            this.Date_of_Birth_TextBox.Size = new System.Drawing.Size(196, 26);
            this.Date_of_Birth_TextBox.TabIndex = 10;
            // 
            // Register_Button
            // 
            this.Register_Button.Location = new System.Drawing.Point(32, 14);
            this.Register_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(165, 35);
            this.Register_Button.TabIndex = 11;
            this.Register_Button.Text = "Зареєструватися";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Повторіть пароль";
            // 
            // Password_Repeat_textbox
            // 
            this.Password_Repeat_textbox.Location = new System.Drawing.Point(32, 258);
            this.Password_Repeat_textbox.MaxLength = 30;
            this.Password_Repeat_textbox.Name = "Password_Repeat_textbox";
            this.Password_Repeat_textbox.PasswordChar = '*';
            this.Password_Repeat_textbox.Size = new System.Drawing.Size(196, 26);
            this.Password_Repeat_textbox.TabIndex = 13;
            this.Password_Repeat_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 314);
            this.Controls.Add(this.Password_Repeat_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Date_of_Birth_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registration_form";
            this.Text = "Реєстрація";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date_of_Birth_TextBox;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password_Repeat_textbox;
    }
}