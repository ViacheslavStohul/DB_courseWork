namespace DB_planes
{
    partial class FlightsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Flight_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plane_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOff_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOff_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landing_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landing_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flight_Number,
            this.Plane_Number,
            this.TakeOff_date,
            this.TakeOff_City,
            this.Landing_Date,
            this.Landing_City});
            this.dataGridView1.Location = new System.Drawing.Point(22, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // Flight_Number
            // 
            this.Flight_Number.HeaderText = "Flight Number";
            this.Flight_Number.MinimumWidth = 8;
            this.Flight_Number.Name = "Flight_Number";
            this.Flight_Number.Width = 150;
            // 
            // Plane_Number
            // 
            this.Plane_Number.HeaderText = "Plane Number";
            this.Plane_Number.MinimumWidth = 8;
            this.Plane_Number.Name = "Plane_Number";
            this.Plane_Number.Width = 150;
            // 
            // TakeOff_date
            // 
            this.TakeOff_date.HeaderText = "Take off date";
            this.TakeOff_date.MinimumWidth = 8;
            this.TakeOff_date.Name = "TakeOff_date";
            this.TakeOff_date.Width = 150;
            // 
            // TakeOff_City
            // 
            this.TakeOff_City.HeaderText = "Take off City";
            this.TakeOff_City.MinimumWidth = 8;
            this.TakeOff_City.Name = "TakeOff_City";
            this.TakeOff_City.Width = 150;
            // 
            // Landing_Date
            // 
            this.Landing_Date.HeaderText = "Landing date";
            this.Landing_Date.MinimumWidth = 8;
            this.Landing_Date.Name = "Landing_Date";
            this.Landing_Date.Width = 150;
            // 
            // Landing_City
            // 
            this.Landing_City.HeaderText = "Landing City";
            this.Landing_City.MinimumWidth = 8;
            this.Landing_City.Name = "Landing_City";
            this.Landing_City.Width = 150;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 445);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlightsForm";
            this.Text = "Список рейсів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.my_orders_form_FormClosed);
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plane_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOff_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOff_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Landing_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Landing_City;
    }
}