namespace LibraryTraining
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReplacingBooks = new System.Windows.Forms.TabPage();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnItemDown = new System.Windows.Forms.Button();
            this.btnItemUp = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnGenNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentifyingAreas = new System.Windows.Forms.TabPage();
            this.lblScoreRemark = new System.Windows.Forms.Label();
            this.lblUserScore2 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateColumns = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindingCallNumbers = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUserScore3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tboxDescriptionCall = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserScoreDescrip = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ReplacingBooks.SuspendLayout();
            this.IdentifyingAreas.SuspendLayout();
            this.FindingCallNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReplacingBooks);
            this.tabControl1.Controls.Add(this.IdentifyingAreas);
            this.tabControl1.Controls.Add(this.FindingCallNumbers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 533);
            this.tabControl1.TabIndex = 2;
            // 
            // ReplacingBooks
            // 
            this.ReplacingBooks.Controls.Add(this.lblUserScore);
            this.ReplacingBooks.Controls.Add(this.lblUserMessage);
            this.ReplacingBooks.Controls.Add(this.label7);
            this.ReplacingBooks.Controls.Add(this.label6);
            this.ReplacingBooks.Controls.Add(this.btnItemDown);
            this.ReplacingBooks.Controls.Add(this.btnItemUp);
            this.ReplacingBooks.Controls.Add(this.btnCheckOrder);
            this.ReplacingBooks.Controls.Add(this.btnGenNumbers);
            this.ReplacingBooks.Controls.Add(this.listBox1);
            this.ReplacingBooks.Controls.Add(this.label1);
            this.ReplacingBooks.Location = new System.Drawing.Point(4, 29);
            this.ReplacingBooks.Name = "ReplacingBooks";
            this.ReplacingBooks.Padding = new System.Windows.Forms.Padding(3);
            this.ReplacingBooks.Size = new System.Drawing.Size(852, 500);
            this.ReplacingBooks.TabIndex = 0;
            this.ReplacingBooks.Text = "Replacing Books";
            this.ReplacingBooks.UseVisualStyleBackColor = true;
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(699, 142);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(0, 20);
            this.lblUserScore.TabIndex = 9;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Location = new System.Drawing.Point(659, 197);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(0, 20);
            this.lblUserMessage.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Your Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rearrange the Numbers in Ascending order";
            // 
            // btnItemDown
            // 
            this.btnItemDown.Location = new System.Drawing.Point(474, 264);
            this.btnItemDown.Name = "btnItemDown";
            this.btnItemDown.Size = new System.Drawing.Size(75, 75);
            this.btnItemDown.TabIndex = 5;
            this.btnItemDown.Text = "\\/";
            this.btnItemDown.UseVisualStyleBackColor = true;
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // btnItemUp
            // 
            this.btnItemUp.Location = new System.Drawing.Point(474, 142);
            this.btnItemUp.Name = "btnItemUp";
            this.btnItemUp.Size = new System.Drawing.Size(75, 75);
            this.btnItemUp.TabIndex = 4;
            this.btnItemUp.Text = "/\\";
            this.btnItemUp.UseVisualStyleBackColor = true;
            this.btnItemUp.Click += new System.EventHandler(this.btnItemUp_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(223, 417);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(220, 32);
            this.btnCheckOrder.TabIndex = 3;
            this.btnCheckOrder.Text = "Check Order ";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnGenNumbers
            // 
            this.btnGenNumbers.Location = new System.Drawing.Point(223, 70);
            this.btnGenNumbers.Name = "btnGenNumbers";
            this.btnGenNumbers.Size = new System.Drawing.Size(220, 30);
            this.btnGenNumbers.TabIndex = 2;
            this.btnGenNumbers.Text = "Generate Numbers ";
            this.btnGenNumbers.UseVisualStyleBackColor = true;
            this.btnGenNumbers.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(223, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 264);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replacing Books:";
            // 
            // IdentifyingAreas
            // 
            this.IdentifyingAreas.Controls.Add(this.lblScoreRemark);
            this.IdentifyingAreas.Controls.Add(this.lblUserScore2);
            this.IdentifyingAreas.Controls.Add(this.btnAnswer);
            this.IdentifyingAreas.Controls.Add(this.listBox3);
            this.IdentifyingAreas.Controls.Add(this.listBox2);
            this.IdentifyingAreas.Controls.Add(this.label8);
            this.IdentifyingAreas.Controls.Add(this.btnGenerateColumns);
            this.IdentifyingAreas.Controls.Add(this.label4);
            this.IdentifyingAreas.Controls.Add(this.label2);
            this.IdentifyingAreas.Location = new System.Drawing.Point(4, 29);
            this.IdentifyingAreas.Name = "IdentifyingAreas";
            this.IdentifyingAreas.Padding = new System.Windows.Forms.Padding(3);
            this.IdentifyingAreas.Size = new System.Drawing.Size(852, 500);
            this.IdentifyingAreas.TabIndex = 1;
            this.IdentifyingAreas.Text = "Identifying Areas";
            this.IdentifyingAreas.UseVisualStyleBackColor = true;
            // 
            // lblScoreRemark
            // 
            this.lblScoreRemark.AutoSize = true;
            this.lblScoreRemark.Location = new System.Drawing.Point(660, 191);
            this.lblScoreRemark.Name = "lblScoreRemark";
            this.lblScoreRemark.Size = new System.Drawing.Size(0, 20);
            this.lblScoreRemark.TabIndex = 9;
            // 
            // lblUserScore2
            // 
            this.lblUserScore2.AutoSize = true;
            this.lblUserScore2.Location = new System.Drawing.Point(680, 148);
            this.lblUserScore2.Name = "lblUserScore2";
            this.lblUserScore2.Size = new System.Drawing.Size(0, 20);
            this.lblUserScore2.TabIndex = 8;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(240, 393);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(227, 31);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Answer!";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(359, 148);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(220, 204);
            this.listBox3.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(105, 148);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 204);
            this.listBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Your Score:";
            // 
            // btnGenerateColumns
            // 
            this.btnGenerateColumns.Location = new System.Drawing.Point(240, 80);
            this.btnGenerateColumns.Name = "btnGenerateColumns";
            this.btnGenerateColumns.Size = new System.Drawing.Size(227, 31);
            this.btnGenerateColumns.TabIndex = 2;
            this.btnGenerateColumns.Text = "Generate Columns";
            this.btnGenerateColumns.UseVisualStyleBackColor = true;
            this.btnGenerateColumns.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Match the columns \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identifying Areas:";
            // 
            // FindingCallNumbers
            // 
            this.FindingCallNumbers.Controls.Add(this.lblUserScoreDescrip);
            this.FindingCallNumbers.Controls.Add(this.button4);
            this.FindingCallNumbers.Controls.Add(this.button3);
            this.FindingCallNumbers.Controls.Add(this.button2);
            this.FindingCallNumbers.Controls.Add(this.lblUserScore3);
            this.FindingCallNumbers.Controls.Add(this.label9);
            this.FindingCallNumbers.Controls.Add(this.button1);
            this.FindingCallNumbers.Controls.Add(this.tboxDescriptionCall);
            this.FindingCallNumbers.Controls.Add(this.listBox4);
            this.FindingCallNumbers.Controls.Add(this.label5);
            this.FindingCallNumbers.Controls.Add(this.label3);
            this.FindingCallNumbers.Location = new System.Drawing.Point(4, 29);
            this.FindingCallNumbers.Name = "FindingCallNumbers";
            this.FindingCallNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.FindingCallNumbers.Size = new System.Drawing.Size(852, 500);
            this.FindingCallNumbers.TabIndex = 2;
            this.FindingCallNumbers.Text = "Finding Call Numbers";
            this.FindingCallNumbers.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Answer !";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Answer !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add New Description ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUserScore3
            // 
            this.lblUserScore3.AutoSize = true;
            this.lblUserScore3.Location = new System.Drawing.Point(738, 61);
            this.lblUserScore3.Name = "lblUserScore3";
            this.lblUserScore3.Size = new System.Drawing.Size(0, 20);
            this.lblUserScore3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(702, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Your Score:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Answer !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // tboxDescriptionCall
            // 
            this.tboxDescriptionCall.Location = new System.Drawing.Point(53, 139);
            this.tboxDescriptionCall.Name = "tboxDescriptionCall";
            this.tboxDescriptionCall.ReadOnly = true;
            this.tboxDescriptionCall.Size = new System.Drawing.Size(743, 27);
            this.tboxDescriptionCall.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(53, 190);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(743, 164);
            this.listBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complete the Quiz by matching call numbers to the description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Finding Call Numbers:";
            // 
            // lblUserScoreDescrip
            // 
            this.lblUserScoreDescrip.AutoSize = true;
            this.lblUserScoreDescrip.Location = new System.Drawing.Point(706, 89);
            this.lblUserScoreDescrip.Name = "lblUserScoreDescrip";
            this.lblUserScoreDescrip.Size = new System.Drawing.Size(0, 20);
            this.lblUserScoreDescrip.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ReplacingBooks.ResumeLayout(false);
            this.ReplacingBooks.PerformLayout();
            this.IdentifyingAreas.ResumeLayout(false);
            this.IdentifyingAreas.PerformLayout();
            this.FindingCallNumbers.ResumeLayout(false);
            this.FindingCallNumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReplacingBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage IdentifyingAreas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage FindingCallNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGenNumbers;
        private System.Windows.Forms.Button btnItemDown;
        private System.Windows.Forms.Button btnItemUp;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerateColumns;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lblUserScore2;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblScoreRemark;
        private System.Windows.Forms.Label lblUserScore3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboxDescriptionCall;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblUserScoreDescrip;
    }
}

