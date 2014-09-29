namespace SalaryCalculationApp
{
    partial class Salary
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBasic = new System.Windows.Forms.TextBox();
            this.textBoxHousePer = new System.Windows.Forms.TextBox();
            this.textBoxMedicalPer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxBasic
            // 
            this.textBoxBasic.Location = new System.Drawing.Point(151, 50);
            this.textBoxBasic.Name = "textBoxBasic";
            this.textBoxBasic.Size = new System.Drawing.Size(100, 20);
            this.textBoxBasic.TabIndex = 1;
            // 
            // textBoxHousePer
            // 
            this.textBoxHousePer.Location = new System.Drawing.Point(151, 87);
            this.textBoxHousePer.Name = "textBoxHousePer";
            this.textBoxHousePer.Size = new System.Drawing.Size(100, 20);
            this.textBoxHousePer.TabIndex = 2;
            // 
            // textBoxMedicalPer
            // 
            this.textBoxMedicalPer.Location = new System.Drawing.Point(151, 123);
            this.textBoxMedicalPer.Name = "textBoxMedicalPer";
            this.textBoxMedicalPer.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedicalPer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medical Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Houst Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Basic Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "% of Basic Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "% of Basic Salary";
            // 
            // totalSalaryButton
            // 
            this.totalSalaryButton.Location = new System.Drawing.Point(176, 194);
            this.totalSalaryButton.Name = "totalSalaryButton";
            this.totalSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.totalSalaryButton.TabIndex = 10;
            this.totalSalaryButton.Text = "Total Salary";
            this.totalSalaryButton.UseVisualStyleBackColor = true;
            this.totalSalaryButton.Click += new System.EventHandler(this.totalSalaryButton_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 288);
            this.Controls.Add(this.totalSalaryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMedicalPer);
            this.Controls.Add(this.textBoxHousePer);
            this.Controls.Add(this.textBoxBasic);
            this.Controls.Add(this.textBoxName);
            this.Name = "Salary";
            this.Text = "Salary Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBasic;
        private System.Windows.Forms.TextBox textBoxHousePer;
        private System.Windows.Forms.TextBox textBoxMedicalPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button totalSalaryButton;
    }
}

