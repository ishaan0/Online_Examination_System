namespace TEST
{
    partial class ParticipantInfo
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
            this.label_participant_info = new System.Windows.Forms.Label();
            this.listView_participant_info = new System.Windows.Forms.ListView();
            this.columnHeader_student_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_enter_participant_info = new System.Windows.Forms.Button();
            this.button_participant_remove = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.panel1_result = new System.Windows.Forms.Panel();
            this.listView_show_result = new System.Windows.Forms.ListView();
            this.columnHeader_name_student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_marks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_show_result = new System.Windows.Forms.Button();
            this.panel1_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_participant_info
            // 
            this.label_participant_info.BackColor = System.Drawing.Color.White;
            this.label_participant_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_participant_info.Location = new System.Drawing.Point(25, 26);
            this.label_participant_info.Name = "label_participant_info";
            this.label_participant_info.Size = new System.Drawing.Size(743, 56);
            this.label_participant_info.TabIndex = 0;
            this.label_participant_info.Text = "Participant Info";
            this.label_participant_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_participant_info
            // 
            this.listView_participant_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_student_id,
            this.columnHeader_password});
            this.listView_participant_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_participant_info.FullRowSelect = true;
            this.listView_participant_info.GridLines = true;
            this.listView_participant_info.Location = new System.Drawing.Point(25, 85);
            this.listView_participant_info.Name = "listView_participant_info";
            this.listView_participant_info.Size = new System.Drawing.Size(743, 332);
            this.listView_participant_info.TabIndex = 0;
            this.listView_participant_info.UseCompatibleStateImageBehavior = false;
            this.listView_participant_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_student_id
            // 
            this.columnHeader_student_id.Text = "                    Student Id";
            this.columnHeader_student_id.Width = 370;
            // 
            // columnHeader_password
            // 
            this.columnHeader_password.Text = "Password";
            this.columnHeader_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_password.Width = 370;
            // 
            // button_enter_participant_info
            // 
            this.button_enter_participant_info.BackColor = System.Drawing.Color.OliveDrab;
            this.button_enter_participant_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter_participant_info.ForeColor = System.Drawing.Color.Black;
            this.button_enter_participant_info.Location = new System.Drawing.Point(231, 433);
            this.button_enter_participant_info.Name = "button_enter_participant_info";
            this.button_enter_participant_info.Size = new System.Drawing.Size(153, 54);
            this.button_enter_participant_info.TabIndex = 1;
            this.button_enter_participant_info.Text = "Enter";
            this.button_enter_participant_info.UseVisualStyleBackColor = false;
            this.button_enter_participant_info.Click += new System.EventHandler(this.button_enter_participant_info_Click);
            // 
            // button_participant_remove
            // 
            this.button_participant_remove.BackColor = System.Drawing.Color.Red;
            this.button_participant_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_participant_remove.ForeColor = System.Drawing.Color.Black;
            this.button_participant_remove.Location = new System.Drawing.Point(48, 433);
            this.button_participant_remove.Name = "button_participant_remove";
            this.button_participant_remove.Size = new System.Drawing.Size(153, 54);
            this.button_participant_remove.TabIndex = 2;
            this.button_participant_remove.Text = "Remove";
            this.button_participant_remove.UseVisualStyleBackColor = false;
            this.button_participant_remove.Click += new System.EventHandler(this.button_participant_remove_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkCyan;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.Black;
            this.button_back.Location = new System.Drawing.Point(414, 433);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(153, 54);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel1_result
            // 
            this.panel1_result.Controls.Add(this.listView_show_result);
            this.panel1_result.Controls.Add(this.label1);
            this.panel1_result.Location = new System.Drawing.Point(12, 12);
            this.panel1_result.Name = "panel1_result";
            this.panel1_result.Size = new System.Drawing.Size(768, 405);
            this.panel1_result.TabIndex = 4;
            // 
            // listView_show_result
            // 
            this.listView_show_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name_student,
            this.columnHeader_marks});
            this.listView_show_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_show_result.FullRowSelect = true;
            this.listView_show_result.GridLines = true;
            this.listView_show_result.Location = new System.Drawing.Point(13, 85);
            this.listView_show_result.Name = "listView_show_result";
            this.listView_show_result.Size = new System.Drawing.Size(743, 317);
            this.listView_show_result.TabIndex = 1;
            this.listView_show_result.UseCompatibleStateImageBehavior = false;
            this.listView_show_result.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_name_student
            // 
            this.columnHeader_name_student.Text = "                    Student Id";
            this.columnHeader_name_student.Width = 370;
            // 
            // columnHeader_marks
            // 
            this.columnHeader_marks.Text = "Marks";
            this.columnHeader_marks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_marks.Width = 370;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exam Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_show_result
            // 
            this.button_show_result.BackColor = System.Drawing.Color.SlateBlue;
            this.button_show_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_result.ForeColor = System.Drawing.Color.Black;
            this.button_show_result.Location = new System.Drawing.Point(597, 433);
            this.button_show_result.Name = "button_show_result";
            this.button_show_result.Size = new System.Drawing.Size(153, 54);
            this.button_show_result.TabIndex = 3;
            this.button_show_result.Text = "Show";
            this.button_show_result.UseVisualStyleBackColor = false;
            this.button_show_result.Click += new System.EventHandler(this.button_show_result_Click);
            // 
            // ParticipantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.panel1_result);
            this.Controls.Add(this.button_show_result);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_enter_participant_info);
            this.Controls.Add(this.button_participant_remove);
            this.Controls.Add(this.listView_participant_info);
            this.Controls.Add(this.label_participant_info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParticipantInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParticipantInfo";
            this.Load += new System.EventHandler(this.ParticipantInfo_Load);
            this.panel1_result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_participant_info;
        private System.Windows.Forms.ListView listView_participant_info;
        private System.Windows.Forms.ColumnHeader columnHeader_student_id;
        private System.Windows.Forms.Button button_enter_participant_info;
        private System.Windows.Forms.Button button_participant_remove;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ColumnHeader columnHeader_password;
        private System.Windows.Forms.Panel panel1_result;
        private System.Windows.Forms.ListView listView_show_result;
        private System.Windows.Forms.ColumnHeader columnHeader_name_student;
        private System.Windows.Forms.ColumnHeader columnHeader_marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_show_result;
    }
}