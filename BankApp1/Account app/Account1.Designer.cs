namespace Account_app
{
    partial class Account1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.acnoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositeButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.customerTextBox);
            this.groupBox1.Controls.Add(this.acnoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(256, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // createButton
            // 
            this.createButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.createButton.Location = new System.Drawing.Point(186, 87);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(56, 28);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(94, 53);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(149, 20);
            this.customerTextBox.TabIndex = 3;
            // 
            // acnoTextBox
            // 
            this.acnoTextBox.Location = new System.Drawing.Point(94, 22);
            this.acnoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.acnoTextBox.Name = "acnoTextBox";
            this.acnoTextBox.Size = new System.Drawing.Size(149, 20);
            this.acnoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AC Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportButton);
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.depositeButton);
            this.groupBox2.Controls.Add(this.balanceTextBox);
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Location = new System.Drawing.Point(28, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(256, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(84, 98);
            this.reportButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(142, 34);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(158, 53);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(68, 32);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(82, 53);
            this.depositeButton.Margin = new System.Windows.Forms.Padding(2);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(72, 32);
            this.depositeButton.TabIndex = 2;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(82, 29);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(144, 20);
            this.balanceTextBox.TabIndex = 1;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(20, 29);
            this.Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // Account1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account1";
            this.Text = "Account UI";
          
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox acnoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label Amount;
    }
}

