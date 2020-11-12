namespace DB_planes
{
    partial class LinersForm
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
            this.Board_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buisness_places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buisness_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstClass_Places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstClass_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondClasss_Places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondClasss_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Board_Number,
            this.Type,
            this.Last_check,
            this.buisness_places,
            this.buisness_cost,
            this.FirstClass_Places,
            this.FirstClass_cost,
            this.SecondClasss_Places,
            this.SecondClasss_cost});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // Board_Number
            // 
            this.Board_Number.HeaderText = "Board Number";
            this.Board_Number.MinimumWidth = 8;
            this.Board_Number.Name = "Board_Number";
            this.Board_Number.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Last_check
            // 
            this.Last_check.HeaderText = "Last check";
            this.Last_check.MinimumWidth = 8;
            this.Last_check.Name = "Last_check";
            this.Last_check.Width = 150;
            // 
            // buisness_places
            // 
            this.buisness_places.HeaderText = "Buisness places";
            this.buisness_places.MinimumWidth = 8;
            this.buisness_places.Name = "buisness_places";
            this.buisness_places.Width = 150;
            // 
            // buisness_cost
            // 
            this.buisness_cost.HeaderText = "Buisness cost";
            this.buisness_cost.MinimumWidth = 8;
            this.buisness_cost.Name = "buisness_cost";
            this.buisness_cost.Width = 150;
            // 
            // FirstClass_Places
            // 
            this.FirstClass_Places.HeaderText = "First class places";
            this.FirstClass_Places.MinimumWidth = 8;
            this.FirstClass_Places.Name = "FirstClass_Places";
            this.FirstClass_Places.Width = 150;
            // 
            // FirstClass_cost
            // 
            this.FirstClass_cost.HeaderText = "First class cost";
            this.FirstClass_cost.MinimumWidth = 8;
            this.FirstClass_cost.Name = "FirstClass_cost";
            this.FirstClass_cost.Width = 150;
            // 
            // SecondClasss_Places
            // 
            this.SecondClasss_Places.HeaderText = "Second classs places";
            this.SecondClasss_Places.MinimumWidth = 8;
            this.SecondClasss_Places.Name = "SecondClasss_Places";
            this.SecondClasss_Places.Width = 150;
            // 
            // SecondClasss_cost
            // 
            this.SecondClasss_cost.HeaderText = "Second classs cost";
            this.SecondClasss_cost.MinimumWidth = 8;
            this.SecondClasss_cost.Name = "SecondClasss_cost";
            this.SecondClasss_cost.Width = 150;
            // 
            // LinersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 458);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LinersForm";
            this.Text = "LinersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LinersForm_FormClosed);
            this.Load += new System.EventHandler(this.LinersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Board_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn buisness_places;
        private System.Windows.Forms.DataGridViewTextBoxColumn buisness_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstClass_Places;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstClass_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondClasss_Places;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondClasss_cost;
    }
}