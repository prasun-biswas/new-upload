namespace windows_from
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.datacountTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.addcountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.numberlistBox = new System.Windows.Forms.ListBox();
            this.setButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datacountTextBox);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.addcountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of data";
            // 
            // datacountTextBox
            // 
            this.datacountTextBox.Location = new System.Drawing.Point(154, 20);
            this.datacountTextBox.Name = "datacountTextBox";
            this.datacountTextBox.Size = new System.Drawing.Size(100, 20);
            this.datacountTextBox.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(217, 91);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // addcountLabel
            // 
            this.addcountLabel.AutoSize = true;
            this.addcountLabel.Location = new System.Drawing.Point(187, 126);
            this.addcountLabel.Name = "addcountLabel";
            this.addcountLabel.Size = new System.Drawing.Size(13, 13);
            this.addcountLabel.TabIndex = 3;
            this.addcountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Count";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(217, 49);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(33, 49);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(158, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(229, 208);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // numberlistBox
            // 
            this.numberlistBox.FormattingEnabled = true;
            this.numberlistBox.Location = new System.Drawing.Point(45, 208);
            this.numberlistBox.Name = "numberlistBox";
            this.numberlistBox.Size = new System.Drawing.Size(178, 121);
            this.numberlistBox.TabIndex = 2;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(272, 44);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 7;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 356);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.numberlistBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Addcount info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label addcountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox numberlistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datacountTextBox;
        private System.Windows.Forms.Button setButton;
    }
}

