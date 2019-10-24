namespace TEST
{
    partial class AdminPanelUi
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
            this.tabControl_admin_panel = new System.Windows.Forms.TabControl();
            this.tabPage_current_exams = new System.Windows.Forms.TabPage();
            this.button_currentExam_remove = new System.Windows.Forms.Button();
            this.listView_current_exam = new System.Windows.Forms.ListView();
            this.columnHeader_course_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_teacher_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_current_exam_infor = new System.Windows.Forms.Label();
            this.tabPage_teacher_info = new System.Windows.Forms.TabPage();
            this.textBox_teacher_id = new System.Windows.Forms.TextBox();
            this.textBox_teacher_password = new System.Windows.Forms.TextBox();
            this.textBox_teacher_name = new System.Windows.Forms.TextBox();
            this.label_teacher_id = new System.Windows.Forms.Label();
            this.label_teacher_password = new System.Windows.Forms.Label();
            this.label_teacher_name = new System.Windows.Forms.Label();
            this.button_teacher_refresh = new System.Windows.Forms.Button();
            this.button_teacher_remove = new System.Windows.Forms.Button();
            this.button_teacher_add = new System.Windows.Forms.Button();
            this.listView_teachers_info = new System.Windows.Forms.ListView();
            this.columnHeader_teacher_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_teacher_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_teacher_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_teachers_info = new System.Windows.Forms.Label();
            this.tabPage_change_password = new System.Windows.Forms.TabPage();
            this.button_change = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_retype_password = new System.Windows.Forms.TextBox();
            this.textBox_prev_password = new System.Windows.Forms.TextBox();
            this.label_new_password = new System.Windows.Forms.Label();
            this.label_retype_password = new System.Windows.Forms.Label();
            this.label_prev_password = new System.Windows.Forms.Label();
            this.tabPage_log_out = new System.Windows.Forms.TabPage();
            this.tabControl_admin_panel.SuspendLayout();
            this.tabPage_current_exams.SuspendLayout();
            this.tabPage_teacher_info.SuspendLayout();
            this.tabPage_change_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_admin_panel
            // 
            this.tabControl_admin_panel.Controls.Add(this.tabPage_current_exams);
            this.tabControl_admin_panel.Controls.Add(this.tabPage_teacher_info);
            this.tabControl_admin_panel.Controls.Add(this.tabPage_change_password);
            this.tabControl_admin_panel.Controls.Add(this.tabPage_log_out);
            this.tabControl_admin_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_admin_panel.Location = new System.Drawing.Point(-5, 1);
            this.tabControl_admin_panel.Name = "tabControl_admin_panel";
            this.tabControl_admin_panel.SelectedIndex = 0;
            this.tabControl_admin_panel.Size = new System.Drawing.Size(801, 500);
            this.tabControl_admin_panel.TabIndex = 0;
            this.tabControl_admin_panel.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_admin_panel_Selected);
            // 
            // tabPage_current_exams
            // 
            this.tabPage_current_exams.BackColor = System.Drawing.Color.Black;
            this.tabPage_current_exams.Controls.Add(this.button_currentExam_remove);
            this.tabPage_current_exams.Controls.Add(this.listView_current_exam);
            this.tabPage_current_exams.Controls.Add(this.label_current_exam_infor);
            this.tabPage_current_exams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_current_exams.ForeColor = System.Drawing.Color.White;
            this.tabPage_current_exams.Location = new System.Drawing.Point(4, 34);
            this.tabPage_current_exams.Name = "tabPage_current_exams";
            this.tabPage_current_exams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_current_exams.Size = new System.Drawing.Size(793, 462);
            this.tabPage_current_exams.TabIndex = 0;
            this.tabPage_current_exams.Text = "Current Exams";
            // 
            // button_currentExam_remove
            // 
            this.button_currentExam_remove.BackColor = System.Drawing.Color.Red;
            this.button_currentExam_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_currentExam_remove.ForeColor = System.Drawing.Color.Black;
            this.button_currentExam_remove.Location = new System.Drawing.Point(266, 388);
            this.button_currentExam_remove.Name = "button_currentExam_remove";
            this.button_currentExam_remove.Size = new System.Drawing.Size(229, 54);
            this.button_currentExam_remove.TabIndex = 1;
            this.button_currentExam_remove.Text = "Remove";
            this.button_currentExam_remove.UseVisualStyleBackColor = false;
            this.button_currentExam_remove.Click += new System.EventHandler(this.button_currentExam_remove_Click);
            // 
            // listView_current_exam
            // 
            this.listView_current_exam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_course_code,
            this.columnHeader_exam_teacher_id,
            this.columnHeader_exam_date,
            this.columnHeader_exam_time,
            this.columnHeader_exam_duration});
            this.listView_current_exam.FullRowSelect = true;
            this.listView_current_exam.GridLines = true;
            this.listView_current_exam.Location = new System.Drawing.Point(23, 50);
            this.listView_current_exam.Name = "listView_current_exam";
            this.listView_current_exam.Size = new System.Drawing.Size(743, 328);
            this.listView_current_exam.TabIndex = 0;
            this.listView_current_exam.UseCompatibleStateImageBehavior = false;
            this.listView_current_exam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_course_code
            // 
            this.columnHeader_course_code.Text = "Course Code";
            this.columnHeader_course_code.Width = 155;
            // 
            // columnHeader_exam_teacher_id
            // 
            this.columnHeader_exam_teacher_id.Text = "Teacher Id";
            this.columnHeader_exam_teacher_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_teacher_id.Width = 174;
            // 
            // columnHeader_exam_date
            // 
            this.columnHeader_exam_date.Text = "Date";
            this.columnHeader_exam_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_date.Width = 138;
            // 
            // columnHeader_exam_time
            // 
            this.columnHeader_exam_time.Text = "Time";
            this.columnHeader_exam_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_time.Width = 143;
            // 
            // columnHeader_exam_duration
            // 
            this.columnHeader_exam_duration.Text = "Duration";
            this.columnHeader_exam_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_duration.Width = 129;
            // 
            // label_current_exam_infor
            // 
            this.label_current_exam_infor.AutoSize = true;
            this.label_current_exam_infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_exam_infor.Location = new System.Drawing.Point(304, 3);
            this.label_current_exam_infor.Name = "label_current_exam_infor";
            this.label_current_exam_infor.Size = new System.Drawing.Size(170, 29);
            this.label_current_exam_infor.TabIndex = 0;
            this.label_current_exam_infor.Text = "Current Exam";
            // 
            // tabPage_teacher_info
            // 
            this.tabPage_teacher_info.BackColor = System.Drawing.Color.Black;
            this.tabPage_teacher_info.Controls.Add(this.textBox_teacher_id);
            this.tabPage_teacher_info.Controls.Add(this.textBox_teacher_password);
            this.tabPage_teacher_info.Controls.Add(this.textBox_teacher_name);
            this.tabPage_teacher_info.Controls.Add(this.label_teacher_id);
            this.tabPage_teacher_info.Controls.Add(this.label_teacher_password);
            this.tabPage_teacher_info.Controls.Add(this.label_teacher_name);
            this.tabPage_teacher_info.Controls.Add(this.button_teacher_refresh);
            this.tabPage_teacher_info.Controls.Add(this.button_teacher_remove);
            this.tabPage_teacher_info.Controls.Add(this.button_teacher_add);
            this.tabPage_teacher_info.Controls.Add(this.listView_teachers_info);
            this.tabPage_teacher_info.Controls.Add(this.label_teachers_info);
            this.tabPage_teacher_info.Location = new System.Drawing.Point(4, 34);
            this.tabPage_teacher_info.Name = "tabPage_teacher_info";
            this.tabPage_teacher_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_teacher_info.Size = new System.Drawing.Size(793, 462);
            this.tabPage_teacher_info.TabIndex = 1;
            this.tabPage_teacher_info.Text = "Teachers Info";
            // 
            // textBox_teacher_id
            // 
            this.textBox_teacher_id.Location = new System.Drawing.Point(253, 52);
            this.textBox_teacher_id.Name = "textBox_teacher_id";
            this.textBox_teacher_id.Size = new System.Drawing.Size(359, 31);
            this.textBox_teacher_id.TabIndex = 2;
            // 
            // textBox_teacher_password
            // 
            this.textBox_teacher_password.Location = new System.Drawing.Point(253, 92);
            this.textBox_teacher_password.Name = "textBox_teacher_password";
            this.textBox_teacher_password.Size = new System.Drawing.Size(359, 31);
            this.textBox_teacher_password.TabIndex = 3;
            // 
            // textBox_teacher_name
            // 
            this.textBox_teacher_name.Location = new System.Drawing.Point(253, 12);
            this.textBox_teacher_name.Name = "textBox_teacher_name";
            this.textBox_teacher_name.Size = new System.Drawing.Size(359, 31);
            this.textBox_teacher_name.TabIndex = 1;
            // 
            // label_teacher_id
            // 
            this.label_teacher_id.AutoSize = true;
            this.label_teacher_id.ForeColor = System.Drawing.Color.White;
            this.label_teacher_id.Location = new System.Drawing.Point(29, 58);
            this.label_teacher_id.Name = "label_teacher_id";
            this.label_teacher_id.Size = new System.Drawing.Size(124, 25);
            this.label_teacher_id.TabIndex = 0;
            this.label_teacher_id.Text = "Teacher Id";
            // 
            // label_teacher_password
            // 
            this.label_teacher_password.AutoSize = true;
            this.label_teacher_password.ForeColor = System.Drawing.Color.White;
            this.label_teacher_password.Location = new System.Drawing.Point(29, 99);
            this.label_teacher_password.Name = "label_teacher_password";
            this.label_teacher_password.Size = new System.Drawing.Size(114, 25);
            this.label_teacher_password.TabIndex = 0;
            this.label_teacher_password.Text = "Password";
            // 
            // label_teacher_name
            // 
            this.label_teacher_name.AutoSize = true;
            this.label_teacher_name.ForeColor = System.Drawing.Color.White;
            this.label_teacher_name.Location = new System.Drawing.Point(29, 17);
            this.label_teacher_name.Name = "label_teacher_name";
            this.label_teacher_name.Size = new System.Drawing.Size(165, 25);
            this.label_teacher_name.TabIndex = 0;
            this.label_teacher_name.Text = "Teacher Name";
            // 
            // button_teacher_refresh
            // 
            this.button_teacher_refresh.BackColor = System.Drawing.Color.Chocolate;
            this.button_teacher_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teacher_refresh.Location = new System.Drawing.Point(665, 339);
            this.button_teacher_refresh.Name = "button_teacher_refresh";
            this.button_teacher_refresh.Size = new System.Drawing.Size(102, 68);
            this.button_teacher_refresh.TabIndex = 6;
            this.button_teacher_refresh.Text = "Refresh";
            this.button_teacher_refresh.UseVisualStyleBackColor = false;
            this.button_teacher_refresh.Click += new System.EventHandler(this.button_teacher_refresh_Click);
            // 
            // button_teacher_remove
            // 
            this.button_teacher_remove.BackColor = System.Drawing.Color.Red;
            this.button_teacher_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teacher_remove.Location = new System.Drawing.Point(665, 212);
            this.button_teacher_remove.Name = "button_teacher_remove";
            this.button_teacher_remove.Size = new System.Drawing.Size(102, 68);
            this.button_teacher_remove.TabIndex = 5;
            this.button_teacher_remove.Text = "Remove";
            this.button_teacher_remove.UseVisualStyleBackColor = false;
            this.button_teacher_remove.Click += new System.EventHandler(this.button_teacher_remove_Click);
            // 
            // button_teacher_add
            // 
            this.button_teacher_add.BackColor = System.Drawing.Color.LimeGreen;
            this.button_teacher_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teacher_add.ForeColor = System.Drawing.Color.Black;
            this.button_teacher_add.Location = new System.Drawing.Point(665, 31);
            this.button_teacher_add.Name = "button_teacher_add";
            this.button_teacher_add.Size = new System.Drawing.Size(102, 68);
            this.button_teacher_add.TabIndex = 4;
            this.button_teacher_add.Text = "ADD";
            this.button_teacher_add.UseVisualStyleBackColor = false;
            this.button_teacher_add.Click += new System.EventHandler(this.button_teacher_add_Click);
            // 
            // listView_teachers_info
            // 
            this.listView_teachers_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_teacher_name,
            this.columnHeader_teacher_id,
            this.columnHeader_teacher_password});
            this.listView_teachers_info.FullRowSelect = true;
            this.listView_teachers_info.GridLines = true;
            this.listView_teachers_info.Location = new System.Drawing.Point(34, 185);
            this.listView_teachers_info.Name = "listView_teachers_info";
            this.listView_teachers_info.Size = new System.Drawing.Size(604, 257);
            this.listView_teachers_info.TabIndex = 0;
            this.listView_teachers_info.UseCompatibleStateImageBehavior = false;
            this.listView_teachers_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_teacher_name
            // 
            this.columnHeader_teacher_name.Text = "          Name";
            this.columnHeader_teacher_name.Width = 206;
            // 
            // columnHeader_teacher_id
            // 
            this.columnHeader_teacher_id.Text = "Teacher Id";
            this.columnHeader_teacher_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_teacher_id.Width = 204;
            // 
            // columnHeader_teacher_password
            // 
            this.columnHeader_teacher_password.Text = "Password";
            this.columnHeader_teacher_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_teacher_password.Width = 204;
            // 
            // label_teachers_info
            // 
            this.label_teachers_info.BackColor = System.Drawing.Color.White;
            this.label_teachers_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teachers_info.Location = new System.Drawing.Point(253, 136);
            this.label_teachers_info.Name = "label_teachers_info";
            this.label_teachers_info.Size = new System.Drawing.Size(168, 29);
            this.label_teachers_info.TabIndex = 0;
            this.label_teachers_info.Text = "Teachers Info";
            this.label_teachers_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_change_password
            // 
            this.tabPage_change_password.BackColor = System.Drawing.Color.Black;
            this.tabPage_change_password.Controls.Add(this.button_change);
            this.tabPage_change_password.Controls.Add(this.button_refresh);
            this.tabPage_change_password.Controls.Add(this.button_cancel);
            this.tabPage_change_password.Controls.Add(this.textBox_new_password);
            this.tabPage_change_password.Controls.Add(this.textBox_retype_password);
            this.tabPage_change_password.Controls.Add(this.textBox_prev_password);
            this.tabPage_change_password.Controls.Add(this.label_new_password);
            this.tabPage_change_password.Controls.Add(this.label_retype_password);
            this.tabPage_change_password.Controls.Add(this.label_prev_password);
            this.tabPage_change_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_change_password.Location = new System.Drawing.Point(4, 34);
            this.tabPage_change_password.Name = "tabPage_change_password";
            this.tabPage_change_password.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_change_password.Size = new System.Drawing.Size(793, 462);
            this.tabPage_change_password.TabIndex = 2;
            this.tabPage_change_password.Text = "Change Password";
            // 
            // button_change
            // 
            this.button_change.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_change.Location = new System.Drawing.Point(561, 275);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(122, 27);
            this.button_change.TabIndex = 4;
            this.button_change.Text = " CHANGE";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_refresh.Location = new System.Drawing.Point(357, 276);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(117, 27);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "REFRESH";
            this.button_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_cancel.Location = new System.Drawing.Point(124, 275);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(113, 27);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "CANCEL  ";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Location = new System.Drawing.Point(421, 136);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(262, 31);
            this.textBox_new_password.TabIndex = 2;
            // 
            // textBox_retype_password
            // 
            this.textBox_retype_password.Location = new System.Drawing.Point(421, 186);
            this.textBox_retype_password.Name = "textBox_retype_password";
            this.textBox_retype_password.Size = new System.Drawing.Size(262, 31);
            this.textBox_retype_password.TabIndex = 3;
            // 
            // textBox_prev_password
            // 
            this.textBox_prev_password.Location = new System.Drawing.Point(421, 84);
            this.textBox_prev_password.Name = "textBox_prev_password";
            this.textBox_prev_password.Size = new System.Drawing.Size(262, 31);
            this.textBox_prev_password.TabIndex = 1;
            // 
            // label_new_password
            // 
            this.label_new_password.AutoSize = true;
            this.label_new_password.ForeColor = System.Drawing.Color.White;
            this.label_new_password.Location = new System.Drawing.Point(119, 139);
            this.label_new_password.Name = "label_new_password";
            this.label_new_password.Size = new System.Drawing.Size(173, 25);
            this.label_new_password.TabIndex = 0;
            this.label_new_password.Text = "New Password:";
            // 
            // label_retype_password
            // 
            this.label_retype_password.AutoSize = true;
            this.label_retype_password.ForeColor = System.Drawing.Color.White;
            this.label_retype_password.Location = new System.Drawing.Point(119, 189);
            this.label_retype_password.Name = "label_retype_password";
            this.label_retype_password.Size = new System.Drawing.Size(269, 25);
            this.label_retype_password.TabIndex = 0;
            this.label_retype_password.Text = "Re-Type New Password:";
            // 
            // label_prev_password
            // 
            this.label_prev_password.AutoSize = true;
            this.label_prev_password.ForeColor = System.Drawing.Color.White;
            this.label_prev_password.Location = new System.Drawing.Point(119, 84);
            this.label_prev_password.Name = "label_prev_password";
            this.label_prev_password.Size = new System.Drawing.Size(220, 25);
            this.label_prev_password.TabIndex = 0;
            this.label_prev_password.Text = "Previous Password:";
            // 
            // tabPage_log_out
            // 
            this.tabPage_log_out.BackColor = System.Drawing.Color.Black;
            this.tabPage_log_out.Location = new System.Drawing.Point(4, 34);
            this.tabPage_log_out.Name = "tabPage_log_out";
            this.tabPage_log_out.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_log_out.Size = new System.Drawing.Size(793, 462);
            this.tabPage_log_out.TabIndex = 3;
            this.tabPage_log_out.Text = "Log Out";
            // 
            // AdminPanelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.tabControl_admin_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanelUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelUi";
            this.Load += new System.EventHandler(this.AdminPanelUi_Load_1);
            this.tabControl_admin_panel.ResumeLayout(false);
            this.tabPage_current_exams.ResumeLayout(false);
            this.tabPage_current_exams.PerformLayout();
            this.tabPage_teacher_info.ResumeLayout(false);
            this.tabPage_teacher_info.PerformLayout();
            this.tabPage_change_password.ResumeLayout(false);
            this.tabPage_change_password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_admin_panel;
        private System.Windows.Forms.TabPage tabPage_current_exams;
        private System.Windows.Forms.Label label_current_exam_infor;
        private System.Windows.Forms.TabPage tabPage_teacher_info;
        private System.Windows.Forms.TabPage tabPage_change_password;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.TextBox textBox_retype_password;
        private System.Windows.Forms.TextBox textBox_prev_password;
        private System.Windows.Forms.Label label_new_password;
        private System.Windows.Forms.Label label_retype_password;
        private System.Windows.Forms.Label label_prev_password;
        private System.Windows.Forms.ListView listView_current_exam;
        private System.Windows.Forms.Button button_teacher_refresh;
        private System.Windows.Forms.Button button_teacher_remove;
        private System.Windows.Forms.Button button_teacher_add;
        private System.Windows.Forms.ListView listView_teachers_info;
        private System.Windows.Forms.Label label_teachers_info;
        private System.Windows.Forms.ColumnHeader columnHeader_teacher_name;
        private System.Windows.Forms.ColumnHeader columnHeader_teacher_id;
        private System.Windows.Forms.ColumnHeader columnHeader_teacher_password;
        private System.Windows.Forms.TextBox textBox_teacher_id;
        private System.Windows.Forms.TextBox textBox_teacher_password;
        private System.Windows.Forms.TextBox textBox_teacher_name;
        private System.Windows.Forms.Label label_teacher_id;
        private System.Windows.Forms.Label label_teacher_password;
        private System.Windows.Forms.Label label_teacher_name;
        private System.Windows.Forms.TabPage tabPage_log_out;
        private System.Windows.Forms.Button button_currentExam_remove;
        private System.Windows.Forms.ColumnHeader columnHeader_course_code;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_teacher_id;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_date;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_time;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_duration;
    }
}