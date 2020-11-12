namespace DB_planes
{
    partial class Menu_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.My_tickets_label = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вийти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адміністрування";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // My_tickets_label
            // 
            this.My_tickets_label.AutoSize = true;
            this.My_tickets_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.My_tickets_label.Location = new System.Drawing.Point(154, 204);
            this.My_tickets_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.My_tickets_label.Name = "My_tickets_label";
            this.My_tickets_label.Size = new System.Drawing.Size(138, 29);
            this.My_tickets_label.TabIndex = 3;
            this.My_tickets_label.Text = "Мої квитки";
            this.My_tickets_label.Click += new System.EventHandler(this.My_tickets_label_Click);
            this.My_tickets_label.MouseEnter += new System.EventHandler(this.My_tickets_label_MouseEnter);
            this.My_tickets_label.MouseLeave += new System.EventHandler(this.My_tickets_label_MouseLeave);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLabel.Location = new System.Drawing.Point(118, 84);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(213, 29);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "Замовити квитки";
            this.orderLabel.Click += new System.EventHandler(this.orderLabel_Click);
            this.orderLabel.MouseEnter += new System.EventHandler(this.orderLabel_MouseEnter);
            this.orderLabel.MouseLeave += new System.EventHandler(this.orderLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список рейсів";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.My_tickets_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu_form";
            this.Text = "Головне меню";
            this.Load += new System.EventHandler(this.Menu_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label My_tickets_label;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label label1;
    }
}