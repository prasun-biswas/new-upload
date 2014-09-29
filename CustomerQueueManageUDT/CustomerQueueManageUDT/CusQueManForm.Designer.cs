namespace CustomerQueueManageUDT
{
    partial class CusQueManForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComplain = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComplainShow = new System.Windows.Forms.TextBox();
            this.textBoxNameShow = new System.Windows.Forms.TextBox();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewQueue = new System.Windows.Forms.ListView();
            this.columnHeaderSerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonEnqueue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxComplain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue customer";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.Location = new System.Drawing.Point(318, 16);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(75, 23);
            this.buttonEnqueue.TabIndex = 4;
            this.buttonEnqueue.Text = "Enqueue";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBoxComplain
            // 
            this.textBoxComplain.Location = new System.Drawing.Point(148, 57);
            this.textBoxComplain.Name = "textBoxComplain";
            this.textBoxComplain.Size = new System.Drawing.Size(100, 20);
            this.textBoxComplain.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDequeue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxComplainShow);
            this.groupBox2.Controls.Add(this.textBoxNameShow);
            this.groupBox2.Controls.Add(this.textBoxSerialNo);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue customer";
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.Location = new System.Drawing.Point(295, 21);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(75, 23);
            this.buttonDequeue.TabIndex = 6;
            this.buttonDequeue.Text = "Dequeue";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serial No";
            // 
            // textBoxComplainShow
            // 
            this.textBoxComplainShow.Location = new System.Drawing.Point(150, 84);
            this.textBoxComplainShow.Name = "textBoxComplainShow";
            this.textBoxComplainShow.Size = new System.Drawing.Size(147, 20);
            this.textBoxComplainShow.TabIndex = 2;
            // 
            // textBoxNameShow
            // 
            this.textBoxNameShow.Location = new System.Drawing.Point(150, 53);
            this.textBoxNameShow.Name = "textBoxNameShow";
            this.textBoxNameShow.Size = new System.Drawing.Size(147, 20);
            this.textBoxNameShow.TabIndex = 1;
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Location = new System.Drawing.Point(150, 19);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialNo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Queue Status";
            // 
            // listViewQueue
            // 
            this.listViewQueue.AllowColumnReorder = true;
            this.listViewQueue.AllowDrop = true;
            this.listViewQueue.BackgroundImageTiled = true;
            this.listViewQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSerialNo,
            this.columnHeaderName,
            this.columnHeaderComplain});
            this.listViewQueue.Location = new System.Drawing.Point(160, 208);
            this.listViewQueue.Name = "listViewQueue";
            this.listViewQueue.ShowItemToolTips = true;
            this.listViewQueue.Size = new System.Drawing.Size(521, 120);
            this.listViewQueue.TabIndex = 4;
            this.listViewQueue.UseCompatibleStateImageBehavior = false;
            this.listViewQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSerialNo
            // 
            this.columnHeaderSerialNo.Text = "Serial NO";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name of Customer";
            this.columnHeaderName.Width = 113;
            // 
            // columnHeaderComplain
            // 
            this.columnHeaderComplain.Text = "Customers Complain";
            this.columnHeaderComplain.Width = 214;
            // 
            // CusQueManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(832, 368);
            this.Controls.Add(this.listViewQueue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CusQueManForm";
            this.Text = "Customer Queue Management Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComplain;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComplainShow;
        private System.Windows.Forms.TextBox textBoxNameShow;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewQueue;
        private System.Windows.Forms.ColumnHeader columnHeaderSerialNo;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderComplain;
    }
}

