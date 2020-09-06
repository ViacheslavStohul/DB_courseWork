namespace DB_planes
{
    partial class start_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_form));
            this.registration_button = new System.Windows.Forms.Button();
            this.log_in_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registration_button
            // 
            this.registration_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registration_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registration_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_button.Location = new System.Drawing.Point(95, 101);
            this.registration_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(97, 28);
            this.registration_button.TabIndex = 0;
            this.registration_button.Text = "Реєстрація";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // log_in_button
            // 
            this.log_in_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_in_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.log_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_in_button.Location = new System.Drawing.Point(95, 59);
            this.log_in_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log_in_button.Name = "log_in_button";
            this.log_in_button.Size = new System.Drawing.Size(97, 28);
            this.log_in_button.TabIndex = 1;
            this.log_in_button.Text = "Увійти";
            this.log_in_button.UseVisualStyleBackColor = true;
            this.log_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // start_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(279, 234);
            this.Controls.Add(this.log_in_button);
            this.Controls.Add(this.registration_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(711, 593);
            this.MinimumSize = new System.Drawing.Size(293, 267);
            this.Name = "start_form";
            this.Text = "UIA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.start_form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button log_in_button;
    }
}

