
namespace My_Expenses
{
    partial class ProfileUC
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
            this.grPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grPersonalInfo
            // 
            this.grPersonalInfo.Controls.Add(this.btnCapture);
            this.grPersonalInfo.Controls.Add(this.label3);
            this.grPersonalInfo.Controls.Add(this.txtSalary);
            this.grPersonalInfo.Controls.Add(this.txtSurname);
            this.grPersonalInfo.Controls.Add(this.label2);
            this.grPersonalInfo.Controls.Add(this.label1);
            this.grPersonalInfo.Controls.Add(this.txtName);
            this.grPersonalInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPersonalInfo.Location = new System.Drawing.Point(69, 112);
            this.grPersonalInfo.Name = "grPersonalInfo";
            this.grPersonalInfo.Size = new System.Drawing.Size(545, 300);
            this.grPersonalInfo.TabIndex = 0;
            this.grPersonalInfo.TabStop = false;
            this.grPersonalInfo.Text = "Personal Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 27);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(195, 110);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(270, 27);
            this.txtSurname.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(195, 170);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(270, 27);
            this.txtSalary.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Salary";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(307, 224);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(158, 48);
            this.btnCapture.TabIndex = 6;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.Location = new System.Drawing.Point(166, 43);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(51, 36);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "na";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hello,";
            // 
            // ProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.grPersonalInfo);
            this.Name = "ProfileUC";
            this.Size = new System.Drawing.Size(638, 437);
            this.grPersonalInfo.ResumeLayout(false);
            this.grPersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grPersonalInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label label5;
    }
}
