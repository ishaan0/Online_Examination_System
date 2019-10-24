namespace TEST
{
    partial class QuestionPaperUi
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
            this.button_question_refresh = new System.Windows.Forms.Button();
            this.button_question_remove = new System.Windows.Forms.Button();
            this.button_question_add = new System.Windows.Forms.Button();
            this.textBox_question_marks = new System.Windows.Forms.TextBox();
            this.label_marks = new System.Windows.Forms.Label();
            this.label_Question = new System.Windows.Forms.Label();
            this.richTextBox_question = new System.Windows.Forms.RichTextBox();
            this.button_question_finish = new System.Windows.Forms.Button();
            this.listView_Question_info = new System.Windows.Forms.ListView();
            this.columnHeader_question_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_marks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_notification_marks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_question_refresh
            // 
            this.button_question_refresh.BackColor = System.Drawing.Color.Chocolate;
            this.button_question_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_question_refresh.Location = new System.Drawing.Point(663, 382);
            this.button_question_refresh.Name = "button_question_refresh";
            this.button_question_refresh.Size = new System.Drawing.Size(102, 68);
            this.button_question_refresh.TabIndex = 5;
            this.button_question_refresh.Text = "Refresh";
            this.button_question_refresh.UseVisualStyleBackColor = false;
            this.button_question_refresh.Click += new System.EventHandler(this.button_question_refresh_Click);
            // 
            // button_question_remove
            // 
            this.button_question_remove.BackColor = System.Drawing.Color.Red;
            this.button_question_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_question_remove.Location = new System.Drawing.Point(663, 256);
            this.button_question_remove.Name = "button_question_remove";
            this.button_question_remove.Size = new System.Drawing.Size(102, 68);
            this.button_question_remove.TabIndex = 4;
            this.button_question_remove.Text = "Remove";
            this.button_question_remove.UseVisualStyleBackColor = false;
            this.button_question_remove.Click += new System.EventHandler(this.button_question_remove_Click);
            // 
            // button_question_add
            // 
            this.button_question_add.BackColor = System.Drawing.Color.LimeGreen;
            this.button_question_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_question_add.ForeColor = System.Drawing.Color.Black;
            this.button_question_add.Location = new System.Drawing.Point(663, 49);
            this.button_question_add.Name = "button_question_add";
            this.button_question_add.Size = new System.Drawing.Size(102, 57);
            this.button_question_add.TabIndex = 6;
            this.button_question_add.Text = "ADD";
            this.button_question_add.UseVisualStyleBackColor = false;
            this.button_question_add.Click += new System.EventHandler(this.button_question_add_Click);
            // 
            // textBox_question_marks
            // 
            this.textBox_question_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_question_marks.Location = new System.Drawing.Point(241, 151);
            this.textBox_question_marks.Name = "textBox_question_marks";
            this.textBox_question_marks.Size = new System.Drawing.Size(396, 31);
            this.textBox_question_marks.TabIndex = 2;
            // 
            // label_marks
            // 
            this.label_marks.AutoSize = true;
            this.label_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marks.ForeColor = System.Drawing.Color.White;
            this.label_marks.Location = new System.Drawing.Point(33, 151);
            this.label_marks.Name = "label_marks";
            this.label_marks.Size = new System.Drawing.Size(76, 25);
            this.label_marks.TabIndex = 23;
            this.label_marks.Text = "Marks";
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.ForeColor = System.Drawing.Color.White;
            this.label_Question.Location = new System.Drawing.Point(33, 49);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(106, 25);
            this.label_Question.TabIndex = 21;
            this.label_Question.Text = "Question";
            // 
            // richTextBox_question
            // 
            this.richTextBox_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_question.Location = new System.Drawing.Point(241, 49);
            this.richTextBox_question.Name = "richTextBox_question";
            this.richTextBox_question.Size = new System.Drawing.Size(396, 96);
            this.richTextBox_question.TabIndex = 1;
            this.richTextBox_question.Text = "";
            // 
            // button_question_finish
            // 
            this.button_question_finish.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_question_finish.Enabled = false;
            this.button_question_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_question_finish.ForeColor = System.Drawing.Color.Black;
            this.button_question_finish.Location = new System.Drawing.Point(663, 125);
            this.button_question_finish.Name = "button_question_finish";
            this.button_question_finish.Size = new System.Drawing.Size(102, 57);
            this.button_question_finish.TabIndex = 18;
            this.button_question_finish.Text = "FINISH";
            this.button_question_finish.UseVisualStyleBackColor = false;
            this.button_question_finish.Click += new System.EventHandler(this.button_question_finish_Click);
            // 
            // listView_Question_info
            // 
            this.listView_Question_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_question_info,
            this.columnHeader_marks});
            this.listView_Question_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Question_info.FullRowSelect = true;
            this.listView_Question_info.GridLines = true;
            this.listView_Question_info.Location = new System.Drawing.Point(33, 221);
            this.listView_Question_info.Name = "listView_Question_info";
            this.listView_Question_info.Size = new System.Drawing.Size(604, 266);
            this.listView_Question_info.TabIndex = 28;
            this.listView_Question_info.UseCompatibleStateImageBehavior = false;
            this.listView_Question_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_question_info
            // 
            this.columnHeader_question_info.Text = "                             Question Info";
            this.columnHeader_question_info.Width = 441;
            // 
            // columnHeader_marks
            // 
            this.columnHeader_marks.Text = "Marks";
            this.columnHeader_marks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_notification_marks
            // 
            this.label_notification_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification_marks.ForeColor = System.Drawing.Color.Gray;
            this.label_notification_marks.Location = new System.Drawing.Point(38, 13);
            this.label_notification_marks.Name = "label_notification_marks";
            this.label_notification_marks.Size = new System.Drawing.Size(727, 23);
            this.label_notification_marks.TabIndex = 29;
            this.label_notification_marks.Text = " ";
            this.label_notification_marks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionPaperUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.label_notification_marks);
            this.Controls.Add(this.listView_Question_info);
            this.Controls.Add(this.richTextBox_question);
            this.Controls.Add(this.textBox_question_marks);
            this.Controls.Add(this.label_marks);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.button_question_refresh);
            this.Controls.Add(this.button_question_remove);
            this.Controls.Add(this.button_question_finish);
            this.Controls.Add(this.button_question_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionPaperUi";
            this.Text = "QuestionPaperUi";
            this.Load += new System.EventHandler(this.QuestionPaperUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_question_refresh;
        private System.Windows.Forms.Button button_question_remove;
        private System.Windows.Forms.Button button_question_add;
        private System.Windows.Forms.TextBox textBox_question_marks;
        private System.Windows.Forms.Label label_marks;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.RichTextBox richTextBox_question;
        private System.Windows.Forms.Button button_question_finish;
        private System.Windows.Forms.ListView listView_Question_info;
        private System.Windows.Forms.Label label_notification_marks;
        private System.Windows.Forms.ColumnHeader columnHeader_question_info;
        private System.Windows.Forms.ColumnHeader columnHeader_marks;
    }
}