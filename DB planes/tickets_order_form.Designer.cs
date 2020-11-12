namespace DB_planes
{
    partial class tickets_order_form
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
            this.comboBox_flight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeatTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_flight
            // 
            this.comboBox_flight.FormattingEnabled = true;
            this.comboBox_flight.Location = new System.Drawing.Point(27, 50);
            this.comboBox_flight.Name = "comboBox_flight";
            this.comboBox_flight.Size = new System.Drawing.Size(193, 28);
            this.comboBox_flight.TabIndex = 0;
            this.comboBox_flight.SelectedIndexChanged += new System.EventHandler(this.comboBox_flight_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер рейса";
            // 
            // SeatTypeBox
            // 
            this.SeatTypeBox.FormattingEnabled = true;
            this.SeatTypeBox.Location = new System.Drawing.Point(361, 50);
            this.SeatTypeBox.Name = "SeatTypeBox";
            this.SeatTypeBox.Size = new System.Drawing.Size(267, 28);
            this.SeatTypeBox.TabIndex = 2;
            this.SeatTypeBox.SelectedIndexChanged += new System.EventHandler(this.SeatTypeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Класс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ім\'я";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(27, 144);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(193, 26);
            this.First_Name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Прізвище";
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(361, 144);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(193, 26);
            this.Last_Name.TabIndex = 7;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(27, 221);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(193, 26);
            this.age.TabIndex = 8;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вік";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(31, 296);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(189, 26);
            this.sum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сума";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(361, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Я ветеран войны";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(361, 318);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Виберіть дату вильоту";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Замовити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tickets_order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.age);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeatTypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_flight);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tickets_order_form";
            this.Text = "Замовлення квитків";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tickets_order_FormClosed);
            this.Load += new System.EventHandler(this.tickets_order_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_flight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeatTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}