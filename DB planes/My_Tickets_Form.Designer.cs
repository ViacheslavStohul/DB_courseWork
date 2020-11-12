namespace DB_planes
{
    partial class My_Tickets_Form
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
            this.Ticket_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plane_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOff_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landing_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flight_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.For_Citizen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOff_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_Number,
            this.Plane_Number,
            this.Line,
            this.TakeOff_time,
            this.Landing_Time,
            this.Flight_Number,
            this.For_Citizen,
            this.Sale_Date,
            this.Seat_Type,
            this.TakeOff_Date,
            this.Sum});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ticket_Number
            // 
            this.Ticket_Number.HeaderText = "Ticket Number";
            this.Ticket_Number.MinimumWidth = 8;
            this.Ticket_Number.Name = "Ticket_Number";
            this.Ticket_Number.Width = 150;
            // 
            // Plane_Number
            // 
            this.Plane_Number.HeaderText = "Plane number";
            this.Plane_Number.MinimumWidth = 8;
            this.Plane_Number.Name = "Plane_Number";
            this.Plane_Number.Width = 150;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.MinimumWidth = 8;
            this.Line.Name = "Line";
            this.Line.Width = 150;
            // 
            // TakeOff_time
            // 
            this.TakeOff_time.HeaderText = "Take off time";
            this.TakeOff_time.MinimumWidth = 8;
            this.TakeOff_time.Name = "TakeOff_time";
            this.TakeOff_time.Width = 150;
            // 
            // Landing_Time
            // 
            this.Landing_Time.HeaderText = "Landing time";
            this.Landing_Time.MinimumWidth = 8;
            this.Landing_Time.Name = "Landing_Time";
            this.Landing_Time.Width = 150;
            // 
            // Flight_Number
            // 
            this.Flight_Number.HeaderText = "Flight Number";
            this.Flight_Number.MinimumWidth = 8;
            this.Flight_Number.Name = "Flight_Number";
            this.Flight_Number.Width = 150;
            // 
            // For_Citizen
            // 
            this.For_Citizen.HeaderText = "For citizen";
            this.For_Citizen.MinimumWidth = 8;
            this.For_Citizen.Name = "For_Citizen";
            this.For_Citizen.Width = 150;
            // 
            // Sale_Date
            // 
            this.Sale_Date.HeaderText = "Sale Date";
            this.Sale_Date.MinimumWidth = 8;
            this.Sale_Date.Name = "Sale_Date";
            this.Sale_Date.Width = 150;
            // 
            // Seat_Type
            // 
            this.Seat_Type.HeaderText = "Seat type";
            this.Seat_Type.MinimumWidth = 8;
            this.Seat_Type.Name = "Seat_Type";
            this.Seat_Type.Width = 150;
            // 
            // TakeOff_Date
            // 
            this.TakeOff_Date.HeaderText = "Take off Date";
            this.TakeOff_Date.MinimumWidth = 8;
            this.TakeOff_Date.Name = "TakeOff_Date";
            this.TakeOff_Date.Width = 150;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Cost";
            this.Sum.MinimumWidth = 8;
            this.Sum.Name = "Sum";
            this.Sum.Width = 150;
            // 
            // My_Tickets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "My_Tickets_Form";
            this.Text = "My_Tickets_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.My_Tickets_Form_FormClosed);
            this.Load += new System.EventHandler(this.My_Tickets_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plane_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOff_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Landing_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn For_Citizen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOff_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}