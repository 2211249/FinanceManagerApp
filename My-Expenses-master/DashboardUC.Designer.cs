
namespace My_Expenses
{
    partial class DashboardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSalaryChart = new System.Windows.Forms.Panel();
            this.panelExpenseChart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Expenses = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblTotalUsed = new System.Windows.Forms.Label();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelSalaryChart
            // 
            this.panelSalaryChart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSalaryChart.Location = new System.Drawing.Point(72, 69);
            this.panelSalaryChart.Name = "panelSalaryChart";
            this.panelSalaryChart.Size = new System.Drawing.Size(242, 253);
            this.panelSalaryChart.TabIndex = 0;
            // 
            // panelExpenseChart
            // 
            this.panelExpenseChart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExpenseChart.Location = new System.Drawing.Point(342, 69);
            this.panelExpenseChart.Name = "panelExpenseChart";
            this.panelExpenseChart.Size = new System.Drawing.Size(245, 253);
            this.panelExpenseChart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monthly Salary";
            // 
            // Expenses
            // 
            this.Expenses.AutoSize = true;
            this.Expenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses.Location = new System.Drawing.Point(358, 36);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(79, 19);
            this.Expenses.TabIndex = 3;
            this.Expenses.Text = "Expenses";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(0, 0);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            //this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Amount Used";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Remaining";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(314, 344);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 7;
            // 
            // lblTotalUsed
            // 
            this.lblTotalUsed.AutoSize = true;
            this.lblTotalUsed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsed.ForeColor = System.Drawing.Color.Red;
            this.lblTotalUsed.Location = new System.Drawing.Point(137, 344);
            this.lblTotalUsed.Name = "lblTotalUsed";
            this.lblTotalUsed.Size = new System.Drawing.Size(0, 23);
            this.lblTotalUsed.TabIndex = 8;
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.AutoSize = true;
            this.lblTotalRemaining.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRemaining.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalRemaining.Location = new System.Drawing.Point(137, 378);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(0, 23);
            this.lblTotalRemaining.TabIndex = 9;
            //this.lblTotalRemaining.Click += new System.EventHandler(this.label3_Click);
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalRemaining);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalUsed);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelExpenseChart);
            this.Controls.Add(this.panelSalaryChart);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(632, 437);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSalaryChart;
        private System.Windows.Forms.Panel panelExpenseChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Expenses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblTotalUsed;
        private System.Windows.Forms.Label lblTotalRemaining;
    }
}
