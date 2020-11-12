namespace DB_planes
{
    partial class AdminMenu
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.FlightsLabel = new System.Windows.Forms.Label();
            this.PlanesLabel = new System.Windows.Forms.Label();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(51, 43);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(320, 29);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Переглянути користувачів";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            this.UserLabel.MouseEnter += new System.EventHandler(this.UserLabel_MouseEnter);
            this.UserLabel.MouseLeave += new System.EventHandler(this.UserLabel_MouseLeave);
            // 
            // FlightsLabel
            // 
            this.FlightsLabel.AutoSize = true;
            this.FlightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlightsLabel.Location = new System.Drawing.Point(95, 107);
            this.FlightsLabel.Name = "FlightsLabel";
            this.FlightsLabel.Size = new System.Drawing.Size(241, 29);
            this.FlightsLabel.TabIndex = 1;
            this.FlightsLabel.Text = "Переглянути рейси";
            this.FlightsLabel.Click += new System.EventHandler(this.FlightsLabel_Click);
            this.FlightsLabel.MouseEnter += new System.EventHandler(this.FlightsLabel_MouseEnter);
            this.FlightsLabel.MouseLeave += new System.EventHandler(this.FlightsLabel_MouseLeave);
            // 
            // PlanesLabel
            // 
            this.PlanesLabel.AutoSize = true;
            this.PlanesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanesLabel.Location = new System.Drawing.Point(95, 169);
            this.PlanesLabel.Name = "PlanesLabel";
            this.PlanesLabel.Size = new System.Drawing.Size(244, 29);
            this.PlanesLabel.TabIndex = 2;
            this.PlanesLabel.Text = "Переглянути літаки";
            this.PlanesLabel.Click += new System.EventHandler(this.PlanesLabel_Click);
            this.PlanesLabel.MouseEnter += new System.EventHandler(this.PlanesLabel_MouseEnter);
            this.PlanesLabel.MouseLeave += new System.EventHandler(this.PlanesLabel_MouseLeave);
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalesLabel.Location = new System.Drawing.Point(86, 230);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(265, 29);
            this.SalesLabel.TabIndex = 3;
            this.SalesLabel.Text = "Переглянути продажі";
            this.SalesLabel.Click += new System.EventHandler(this.SalesLabel_Click);
            this.SalesLabel.MouseEnter += new System.EventHandler(this.SalesLabel_MouseEnter);
            this.SalesLabel.MouseLeave += new System.EventHandler(this.SalesLabel_MouseLeave);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 292);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.PlanesLabel);
            this.Controls.Add(this.FlightsLabel);
            this.Controls.Add(this.UserLabel);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label FlightsLabel;
        private System.Windows.Forms.Label PlanesLabel;
        private System.Windows.Forms.Label SalesLabel;
    }
}