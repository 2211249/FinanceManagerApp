
namespace My_Expenses
{
    partial class ExpenseListUC
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
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.GrTransaction = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GrTransaction.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "entertainment",
            "food",
            "transport"});
            this.comboCategory.Location = new System.Drawing.Point(151, 60);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(147, 27);
            this.comboCategory.TabIndex = 1;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // GrTransaction
            // 
            this.GrTransaction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GrTransaction.Controls.Add(this.btnAdd);
            this.GrTransaction.Controls.Add(this.label1);
            this.GrTransaction.Controls.Add(this.txtAmount);
            this.GrTransaction.Controls.Add(this.label2);
            this.GrTransaction.Controls.Add(this.lblItem);
            this.GrTransaction.Controls.Add(this.txtItem);
            this.GrTransaction.Controls.Add(this.comboCategory);
            this.GrTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrTransaction.Location = new System.Drawing.Point(3, 110);
            this.GrTransaction.Name = "GrTransaction";
            this.GrTransaction.Size = new System.Drawing.Size(317, 194);
            this.GrTransaction.TabIndex = 2;
            this.GrTransaction.TabStop = false;
            this.GrTransaction.Text = "Add Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(276, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(151, 96);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(147, 27);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(37, 25);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(43, 19);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(151, 22);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(147, 27);
            this.txtItem.TabIndex = 2;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.txtDisplay);
            this.panelTransactions.Location = new System.Drawing.Point(335, 56);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(281, 349);
            this.panelTransactions.TabIndex = 3;
            this.panelTransactions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTransactions_Paint);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(120, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(0, 25);
            this.txtTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transaction History";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(281, 349);
            this.txtDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Location = new System.Drawing.Point(3, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 49);
            this.panel1.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Green;
            this.lblSalary.Location = new System.Drawing.Point(96, 31);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(35, 25);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "sa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary :";
            // 
            // ExpenseListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.GrTransaction);
            this.Name = "ExpenseListUC";
            this.Size = new System.Drawing.Size(638, 437);
            this.Load += new System.EventHandler(this.ExpenseListUC_Load);
            this.GrTransaction.ResumeLayout(false);
            this.GrTransaction.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.GroupBox GrTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label5;
    }
}
