namespace TEST
{
    partial class StudentPanelUi
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox_answer_show = new System.Windows.Forms.RichTextBox();
            this.richTextBox_question_show = new System.Windows.Forms.RichTextBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_question_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_remaing_answer = new System.Windows.Forms.Label();
            this.label_answer_sheet = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.label_marks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_exam = new System.Windows.Forms.Timer(this.components);
            this.label_hour = new System.Windows.Forms.Label();
            this.label_minute = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_reload_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_answer_show
            // 
            this.richTextBox_answer_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_answer_show.Location = new System.Drawing.Point(225, 168);
            this.richTextBox_answer_show.Name = "richTextBox_answer_show";
            this.richTextBox_answer_show.Size = new System.Drawing.Size(535, 231);
            this.richTextBox_answer_show.TabIndex = 2;
            this.richTextBox_answer_show.Text = "";
            // 
            // richTextBox_question_show
            // 
            this.richTextBox_question_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_question_show.Location = new System.Drawing.Point(225, 71);
            this.richTextBox_question_show.Name = "richTextBox_question_show";
            this.richTextBox_question_show.ReadOnly = true;
            this.richTextBox_question_show.Size = new System.Drawing.Size(535, 81);
            this.richTextBox_question_show.TabIndex = 1;
            this.richTextBox_question_show.Text = "";
            // 
            // label_answer
            // 
            this.label_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer.ForeColor = System.Drawing.Color.White;
            this.label_answer.Location = new System.Drawing.Point(33, 168);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(156, 31);
            this.label_answer.TabIndex = 2;
            this.label_answer.Text = "Answer        :";
            // 
            // label_question_number
            // 
            this.label_question_number.AutoSize = true;
            this.label_question_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question_number.ForeColor = System.Drawing.Color.White;
            this.label_question_number.Location = new System.Drawing.Point(139, 71);
            this.label_question_number.Name = "label_question_number";
            this.label_question_number.Size = new System.Drawing.Size(25, 25);
            this.label_question_number.TabIndex = 3;
            this.label_question_number.Text = "1";
            this.label_question_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Question  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_remaing_answer
            // 
            this.label_remaing_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_remaing_answer.ForeColor = System.Drawing.Color.DimGray;
            this.label_remaing_answer.Location = new System.Drawing.Point(12, 215);
            this.label_remaing_answer.Name = "label_remaing_answer";
            this.label_remaing_answer.Size = new System.Drawing.Size(177, 32);
            this.label_remaing_answer.TabIndex = 8;
            this.label_remaing_answer.Text = "5 answer remaining";
            this.label_remaing_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_answer_sheet
            // 
            this.label_answer_sheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer_sheet.ForeColor = System.Drawing.Color.White;
            this.label_answer_sheet.Location = new System.Drawing.Point(284, 12);
            this.label_answer_sheet.Name = "label_answer_sheet";
            this.label_answer_sheet.Size = new System.Drawing.Size(255, 35);
            this.label_answer_sheet.TabIndex = 9;
            this.label_answer_sheet.Text = "Answer Sheet";
            this.label_answer_sheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.DarkOrange;
            this.button_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finish.ForeColor = System.Drawing.Color.Black;
            this.button_finish.Location = new System.Drawing.Point(636, 423);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(124, 54);
            this.button_finish.TabIndex = 5;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = false;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Olive;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Black;
            this.button_next.Location = new System.Drawing.Point(499, 423);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(124, 54);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.SeaGreen;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Black;
            this.button_previous.Location = new System.Drawing.Point(362, 423);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(124, 54);
            this.button_previous.TabIndex = 4;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // label_marks
            // 
            this.label_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marks.ForeColor = System.Drawing.Color.Silver;
            this.label_marks.Location = new System.Drawing.Point(696, 12);
            this.label_marks.Name = "label_marks";
            this.label_marks.Size = new System.Drawing.Size(63, 32);
            this.label_marks.TabIndex = 11;
            this.label_marks.Text = "100";
            this.label_marks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(627, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_exam
            // 
            this.timer_exam.Enabled = true;
            this.timer_exam.Interval = 1000;
            this.timer_exam.Tick += new System.EventHandler(this.timer_exam_Tick);
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hour.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label_hour.Location = new System.Drawing.Point(34, 12);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(29, 20);
            this.label_hour.TabIndex = 8;
            this.label_hour.Text = "00";
            this.label_hour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minute.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label_minute.Location = new System.Drawing.Point(77, 12);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(29, 20);
            this.label_minute.TabIndex = 8;
            this.label_minute.Text = "00";
            this.label_minute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_second.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label_second.Location = new System.Drawing.Point(120, 17);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(21, 13);
            this.label_second.TabIndex = 8;
            this.label_second.Text = "00";
            this.label_second.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(63, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(106, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_reload_page
            // 
            this.button_reload_page.BackColor = System.Drawing.Color.Teal;
            this.button_reload_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reload_page.ForeColor = System.Drawing.Color.Black;
            this.button_reload_page.Location = new System.Drawing.Point(225, 423);
            this.button_reload_page.Name = "button_reload_page";
            this.button_reload_page.Size = new System.Drawing.Size(116, 54);
            this.button_reload_page.TabIndex = 6;
            this.button_reload_page.Text = "Reload";
            this.button_reload_page.UseVisualStyleBackColor = false;
            this.button_reload_page.Click += new System.EventHandler(this.button_reload_page_Click);
            // 
            // StudentPanelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.button_reload_page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_marks);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label_minute);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.label_remaing_answer);
            this.Controls.Add(this.label_answer_sheet);
            this.Controls.Add(this.richTextBox_answer_show);
            this.Controls.Add(this.richTextBox_question_show);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_question_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentPanelUi";
            this.Text = "StudentPanelUi";
            this.Load += new System.EventHandler(this.StudentPanelUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_answer_show;
        private System.Windows.Forms.RichTextBox richTextBox_question_show;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_question_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_remaing_answer;
        private System.Windows.Forms.Label label_answer_sheet;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Label label_marks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_exam;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_reload_page;
    }
}