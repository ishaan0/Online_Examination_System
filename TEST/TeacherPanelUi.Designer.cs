namespace TEST
{
    partial class TeacherPanelUi
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
            this.tabControl_teacher_panel = new System.Windows.Forms.TabControl();
            this.tabPage_teacher_exam_list = new System.Windows.Forms.TabPage();
            this.button_enter_exam = new System.Windows.Forms.Button();
            this.button_currentExam_remove = new System.Windows.Forms.Button();
            this.listView_teacher_current_exam = new System.Windows.Forms.ListView();
            this.columnHeader_course_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_exam_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_current_exam_infor = new System.Windows.Forms.Label();
            this.tabPage_create_exam = new System.Windows.Forms.TabPage();
            this.comboBox_duration_mm = new System.Windows.Forms.ComboBox();
            this.comboBox_am_pm = new System.Windows.Forms.ComboBox();
            this.comboBox_exam_time_mm = new System.Windows.Forms.ComboBox();
            this.comboBox_duration_hh = new System.Windows.Forms.ComboBox();
            this.comboBox_exam_time_hh = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_exam_date_time = new System.Windows.Forms.DateTimePicker();
            this.label_duration_mm = new System.Windows.Forms.Label();
            this.label_duration_hh = new System.Windows.Forms.Label();
            this.label_exam_time_mm = new System.Windows.Forms.Label();
            this.label_exam_time_hh = new System.Windows.Forms.Label();
            this.label_exam_info = new System.Windows.Forms.Label();
            this.textBox_total_students = new System.Windows.Forms.TextBox();
            this.label_exam_duration = new System.Windows.Forms.Label();
            this.textBox_total_marks = new System.Windows.Forms.TextBox();
            this.label_exam_time = new System.Windows.Forms.Label();
            this.textBox_course_code = new System.Windows.Forms.TextBox();
            this.label_exam_date = new System.Windows.Forms.Label();
            this.label_total_student = new System.Windows.Forms.Label();
            this.label_total_marks = new System.Windows.Forms.Label();
            this.label_course_code = new System.Windows.Forms.Label();
            this.button_refresh_exam_info = new System.Windows.Forms.Button();
            this.button_save_exam_details = new System.Windows.Forms.Button();
            this.tabPage_change_password_teacher = new System.Windows.Forms.TabPage();
            this.button_change_password = new System.Windows.Forms.Button();
            this.button_refresh_teacher_password = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_new_password_teacher = new System.Windows.Forms.TextBox();
            this.textBox_retype_password_teacher = new System.Windows.Forms.TextBox();
            this.textBox_prev_password_teacher = new System.Windows.Forms.TextBox();
            this.label_new_password = new System.Windows.Forms.Label();
            this.label_retype_password = new System.Windows.Forms.Label();
            this.label_prev_password = new System.Windows.Forms.Label();
            this.tabPage_log_out = new System.Windows.Forms.TabPage();
            this.tabControl_teacher_panel.SuspendLayout();
            this.tabPage_teacher_exam_list.SuspendLayout();
            this.tabPage_create_exam.SuspendLayout();
            this.tabPage_change_password_teacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_teacher_panel
            // 
            this.tabControl_teacher_panel.Controls.Add(this.tabPage_teacher_exam_list);
            this.tabControl_teacher_panel.Controls.Add(this.tabPage_create_exam);
            this.tabControl_teacher_panel.Controls.Add(this.tabPage_change_password_teacher);
            this.tabControl_teacher_panel.Controls.Add(this.tabPage_log_out);
            this.tabControl_teacher_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_teacher_panel.Location = new System.Drawing.Point(1, 2);
            this.tabControl_teacher_panel.Name = "tabControl_teacher_panel";
            this.tabControl_teacher_panel.SelectedIndex = 0;
            this.tabControl_teacher_panel.Size = new System.Drawing.Size(791, 500);
            this.tabControl_teacher_panel.TabIndex = 0;
            this.tabControl_teacher_panel.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_teacher_panel_Selected);
            // 
            // tabPage_teacher_exam_list
            // 
            this.tabPage_teacher_exam_list.BackColor = System.Drawing.Color.Black;
            this.tabPage_teacher_exam_list.Controls.Add(this.button_enter_exam);
            this.tabPage_teacher_exam_list.Controls.Add(this.button_currentExam_remove);
            this.tabPage_teacher_exam_list.Controls.Add(this.listView_teacher_current_exam);
            this.tabPage_teacher_exam_list.Controls.Add(this.label_current_exam_infor);
            this.tabPage_teacher_exam_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_teacher_exam_list.ForeColor = System.Drawing.Color.White;
            this.tabPage_teacher_exam_list.Location = new System.Drawing.Point(4, 34);
            this.tabPage_teacher_exam_list.Name = "tabPage_teacher_exam_list";
            this.tabPage_teacher_exam_list.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_teacher_exam_list.Size = new System.Drawing.Size(783, 462);
            this.tabPage_teacher_exam_list.TabIndex = 0;
            this.tabPage_teacher_exam_list.Text = "Exam List";
            // 
            // button_enter_exam
            // 
            this.button_enter_exam.BackColor = System.Drawing.Color.OliveDrab;
            this.button_enter_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter_exam.ForeColor = System.Drawing.Color.Black;
            this.button_enter_exam.Location = new System.Drawing.Point(440, 397);
            this.button_enter_exam.Name = "button_enter_exam";
            this.button_enter_exam.Size = new System.Drawing.Size(153, 54);
            this.button_enter_exam.TabIndex = 1;
            this.button_enter_exam.Text = "Enter";
            this.button_enter_exam.UseVisualStyleBackColor = false;
            this.button_enter_exam.Click += new System.EventHandler(this.button_enter_exam_Click);
            // 
            // button_currentExam_remove
            // 
            this.button_currentExam_remove.BackColor = System.Drawing.Color.Red;
            this.button_currentExam_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_currentExam_remove.ForeColor = System.Drawing.Color.Black;
            this.button_currentExam_remove.Location = new System.Drawing.Point(153, 397);
            this.button_currentExam_remove.Name = "button_currentExam_remove";
            this.button_currentExam_remove.Size = new System.Drawing.Size(153, 54);
            this.button_currentExam_remove.TabIndex = 2;
            this.button_currentExam_remove.Text = "Remove";
            this.button_currentExam_remove.UseVisualStyleBackColor = false;
            this.button_currentExam_remove.Click += new System.EventHandler(this.button_currentExam_remove_Click);
            // 
            // listView_teacher_current_exam
            // 
            this.listView_teacher_current_exam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_course_code,
            this.columnHeader_exam_date,
            this.columnHeader_exam_time,
            this.columnHeader_exam_duration});
            this.listView_teacher_current_exam.FullRowSelect = true;
            this.listView_teacher_current_exam.GridLines = true;
            this.listView_teacher_current_exam.Location = new System.Drawing.Point(23, 50);
            this.listView_teacher_current_exam.Name = "listView_teacher_current_exam";
            this.listView_teacher_current_exam.Size = new System.Drawing.Size(743, 328);
            this.listView_teacher_current_exam.TabIndex = 0;
            this.listView_teacher_current_exam.UseCompatibleStateImageBehavior = false;
            this.listView_teacher_current_exam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_course_code
            // 
            this.columnHeader_course_code.Text = "    Course Code";
            this.columnHeader_course_code.Width = 213;
            // 
            // columnHeader_exam_date
            // 
            this.columnHeader_exam_date.Text = "Date";
            this.columnHeader_exam_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_date.Width = 192;
            // 
            // columnHeader_exam_time
            // 
            this.columnHeader_exam_time.Text = "Time";
            this.columnHeader_exam_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_time.Width = 180;
            // 
            // columnHeader_exam_duration
            // 
            this.columnHeader_exam_duration.Text = "Duration";
            this.columnHeader_exam_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_exam_duration.Width = 153;
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
            // tabPage_create_exam
            // 
            this.tabPage_create_exam.BackColor = System.Drawing.Color.Black;
            this.tabPage_create_exam.Controls.Add(this.comboBox_duration_mm);
            this.tabPage_create_exam.Controls.Add(this.comboBox_am_pm);
            this.tabPage_create_exam.Controls.Add(this.comboBox_exam_time_mm);
            this.tabPage_create_exam.Controls.Add(this.comboBox_duration_hh);
            this.tabPage_create_exam.Controls.Add(this.comboBox_exam_time_hh);
            this.tabPage_create_exam.Controls.Add(this.dateTimePicker_exam_date_time);
            this.tabPage_create_exam.Controls.Add(this.label_duration_mm);
            this.tabPage_create_exam.Controls.Add(this.label_duration_hh);
            this.tabPage_create_exam.Controls.Add(this.label_exam_time_mm);
            this.tabPage_create_exam.Controls.Add(this.label_exam_time_hh);
            this.tabPage_create_exam.Controls.Add(this.label_exam_info);
            this.tabPage_create_exam.Controls.Add(this.textBox_total_students);
            this.tabPage_create_exam.Controls.Add(this.label_exam_duration);
            this.tabPage_create_exam.Controls.Add(this.textBox_total_marks);
            this.tabPage_create_exam.Controls.Add(this.label_exam_time);
            this.tabPage_create_exam.Controls.Add(this.textBox_course_code);
            this.tabPage_create_exam.Controls.Add(this.label_exam_date);
            this.tabPage_create_exam.Controls.Add(this.label_total_student);
            this.tabPage_create_exam.Controls.Add(this.label_total_marks);
            this.tabPage_create_exam.Controls.Add(this.label_course_code);
            this.tabPage_create_exam.Controls.Add(this.button_refresh_exam_info);
            this.tabPage_create_exam.Controls.Add(this.button_save_exam_details);
            this.tabPage_create_exam.Location = new System.Drawing.Point(4, 34);
            this.tabPage_create_exam.Name = "tabPage_create_exam";
            this.tabPage_create_exam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_create_exam.Size = new System.Drawing.Size(783, 462);
            this.tabPage_create_exam.TabIndex = 1;
            this.tabPage_create_exam.Text = "Create Exam";
            // 
            // comboBox_duration_mm
            // 
            this.comboBox_duration_mm.FormattingEnabled = true;
            this.comboBox_duration_mm.Location = new System.Drawing.Point(474, 347);
            this.comboBox_duration_mm.Name = "comboBox_duration_mm";
            this.comboBox_duration_mm.Size = new System.Drawing.Size(66, 33);
            this.comboBox_duration_mm.TabIndex = 13;
            // 
            // comboBox_am_pm
            // 
            this.comboBox_am_pm.FormattingEnabled = true;
            this.comboBox_am_pm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox_am_pm.Location = new System.Drawing.Point(560, 293);
            this.comboBox_am_pm.Name = "comboBox_am_pm";
            this.comboBox_am_pm.Size = new System.Drawing.Size(66, 33);
            this.comboBox_am_pm.TabIndex = 9;
            // 
            // comboBox_exam_time_mm
            // 
            this.comboBox_exam_time_mm.FormattingEnabled = true;
            this.comboBox_exam_time_mm.Location = new System.Drawing.Point(474, 293);
            this.comboBox_exam_time_mm.Name = "comboBox_exam_time_mm";
            this.comboBox_exam_time_mm.Size = new System.Drawing.Size(66, 33);
            this.comboBox_exam_time_mm.TabIndex = 8;
            // 
            // comboBox_duration_hh
            // 
            this.comboBox_duration_hh.FormattingEnabled = true;
            this.comboBox_duration_hh.Location = new System.Drawing.Point(321, 347);
            this.comboBox_duration_hh.Name = "comboBox_duration_hh";
            this.comboBox_duration_hh.Size = new System.Drawing.Size(66, 33);
            this.comboBox_duration_hh.TabIndex = 11;
            // 
            // comboBox_exam_time_hh
            // 
            this.comboBox_exam_time_hh.FormattingEnabled = true;
            this.comboBox_exam_time_hh.Location = new System.Drawing.Point(321, 293);
            this.comboBox_exam_time_hh.Name = "comboBox_exam_time_hh";
            this.comboBox_exam_time_hh.Size = new System.Drawing.Size(66, 33);
            this.comboBox_exam_time_hh.TabIndex = 6;
            // 
            // dateTimePicker_exam_date_time
            // 
            this.dateTimePicker_exam_date_time.Location = new System.Drawing.Point(252, 247);
            this.dateTimePicker_exam_date_time.MinDate = new System.DateTime(2019, 9, 13, 0, 0, 0, 0);
            this.dateTimePicker_exam_date_time.Name = "dateTimePicker_exam_date_time";
            this.dateTimePicker_exam_date_time.Size = new System.Drawing.Size(488, 31);
            this.dateTimePicker_exam_date_time.TabIndex = 4;
            // 
            // label_duration_mm
            // 
            this.label_duration_mm.BackColor = System.Drawing.Color.White;
            this.label_duration_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration_mm.Location = new System.Drawing.Point(403, 347);
            this.label_duration_mm.Name = "label_duration_mm";
            this.label_duration_mm.Size = new System.Drawing.Size(55, 33);
            this.label_duration_mm.TabIndex = 12;
            this.label_duration_mm.Text = "MM";
            // 
            // label_duration_hh
            // 
            this.label_duration_hh.BackColor = System.Drawing.Color.White;
            this.label_duration_hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration_hh.Location = new System.Drawing.Point(256, 347);
            this.label_duration_hh.Name = "label_duration_hh";
            this.label_duration_hh.Size = new System.Drawing.Size(49, 33);
            this.label_duration_hh.TabIndex = 10;
            this.label_duration_hh.Text = "HH";
            // 
            // label_exam_time_mm
            // 
            this.label_exam_time_mm.BackColor = System.Drawing.Color.White;
            this.label_exam_time_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exam_time_mm.Location = new System.Drawing.Point(403, 293);
            this.label_exam_time_mm.Name = "label_exam_time_mm";
            this.label_exam_time_mm.Size = new System.Drawing.Size(55, 33);
            this.label_exam_time_mm.TabIndex = 7;
            this.label_exam_time_mm.Text = "MM";
            // 
            // label_exam_time_hh
            // 
            this.label_exam_time_hh.BackColor = System.Drawing.Color.White;
            this.label_exam_time_hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exam_time_hh.Location = new System.Drawing.Point(256, 293);
            this.label_exam_time_hh.Name = "label_exam_time_hh";
            this.label_exam_time_hh.Size = new System.Drawing.Size(49, 33);
            this.label_exam_time_hh.TabIndex = 5;
            this.label_exam_time_hh.Text = "HH";
            // 
            // label_exam_info
            // 
            this.label_exam_info.AutoSize = true;
            this.label_exam_info.BackColor = System.Drawing.Color.White;
            this.label_exam_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exam_info.Location = new System.Drawing.Point(344, 23);
            this.label_exam_info.Name = "label_exam_info";
            this.label_exam_info.Size = new System.Drawing.Size(127, 29);
            this.label_exam_info.TabIndex = 14;
            this.label_exam_info.Text = "Exam Info";
            // 
            // textBox_total_students
            // 
            this.textBox_total_students.Location = new System.Drawing.Point(252, 137);
            this.textBox_total_students.Name = "textBox_total_students";
            this.textBox_total_students.Size = new System.Drawing.Size(488, 31);
            this.textBox_total_students.TabIndex = 2;
            // 
            // label_exam_duration
            // 
            this.label_exam_duration.AutoSize = true;
            this.label_exam_duration.ForeColor = System.Drawing.Color.White;
            this.label_exam_duration.Location = new System.Drawing.Point(28, 355);
            this.label_exam_duration.Name = "label_exam_duration";
            this.label_exam_duration.Size = new System.Drawing.Size(166, 25);
            this.label_exam_duration.TabIndex = 0;
            this.label_exam_duration.Text = "Exam Duration";
            // 
            // textBox_total_marks
            // 
            this.textBox_total_marks.Location = new System.Drawing.Point(252, 189);
            this.textBox_total_marks.Name = "textBox_total_marks";
            this.textBox_total_marks.Size = new System.Drawing.Size(488, 31);
            this.textBox_total_marks.TabIndex = 3;
            // 
            // label_exam_time
            // 
            this.label_exam_time.AutoSize = true;
            this.label_exam_time.ForeColor = System.Drawing.Color.White;
            this.label_exam_time.Location = new System.Drawing.Point(28, 301);
            this.label_exam_time.Name = "label_exam_time";
            this.label_exam_time.Size = new System.Drawing.Size(128, 25);
            this.label_exam_time.TabIndex = 7;
            this.label_exam_time.Text = "Exam Time";
            // 
            // textBox_course_code
            // 
            this.textBox_course_code.Location = new System.Drawing.Point(252, 85);
            this.textBox_course_code.Name = "textBox_course_code";
            this.textBox_course_code.Size = new System.Drawing.Size(488, 31);
            this.textBox_course_code.TabIndex = 1;
            // 
            // label_exam_date
            // 
            this.label_exam_date.AutoSize = true;
            this.label_exam_date.ForeColor = System.Drawing.Color.White;
            this.label_exam_date.Location = new System.Drawing.Point(28, 247);
            this.label_exam_date.Name = "label_exam_date";
            this.label_exam_date.Size = new System.Drawing.Size(126, 25);
            this.label_exam_date.TabIndex = 0;
            this.label_exam_date.Text = "Exam Date";
            // 
            // label_total_student
            // 
            this.label_total_student.AutoSize = true;
            this.label_total_student.ForeColor = System.Drawing.Color.White;
            this.label_total_student.Location = new System.Drawing.Point(28, 139);
            this.label_total_student.Name = "label_total_student";
            this.label_total_student.Size = new System.Drawing.Size(165, 25);
            this.label_total_student.TabIndex = 17;
            this.label_total_student.Text = "Total Students";
            // 
            // label_total_marks
            // 
            this.label_total_marks.AutoSize = true;
            this.label_total_marks.ForeColor = System.Drawing.Color.White;
            this.label_total_marks.Location = new System.Drawing.Point(28, 193);
            this.label_total_marks.Name = "label_total_marks";
            this.label_total_marks.Size = new System.Drawing.Size(136, 25);
            this.label_total_marks.TabIndex = 18;
            this.label_total_marks.Text = "Total Marks";
            // 
            // label_course_code
            // 
            this.label_course_code.AutoSize = true;
            this.label_course_code.ForeColor = System.Drawing.Color.White;
            this.label_course_code.Location = new System.Drawing.Point(28, 85);
            this.label_course_code.Name = "label_course_code";
            this.label_course_code.Size = new System.Drawing.Size(149, 25);
            this.label_course_code.TabIndex = 16;
            this.label_course_code.Text = "Course Code";
            // 
            // button_refresh_exam_info
            // 
            this.button_refresh_exam_info.BackColor = System.Drawing.Color.Chocolate;
            this.button_refresh_exam_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh_exam_info.Location = new System.Drawing.Point(476, 397);
            this.button_refresh_exam_info.Name = "button_refresh_exam_info";
            this.button_refresh_exam_info.Size = new System.Drawing.Size(116, 45);
            this.button_refresh_exam_info.TabIndex = 15;
            this.button_refresh_exam_info.Text = "REFRESH";
            this.button_refresh_exam_info.UseVisualStyleBackColor = false;
            this.button_refresh_exam_info.Click += new System.EventHandler(this.button_refresh_exam_info_Click);
            // 
            // button_save_exam_details
            // 
            this.button_save_exam_details.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save_exam_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_exam_details.ForeColor = System.Drawing.Color.Black;
            this.button_save_exam_details.Location = new System.Drawing.Point(624, 397);
            this.button_save_exam_details.Name = "button_save_exam_details";
            this.button_save_exam_details.Size = new System.Drawing.Size(116, 45);
            this.button_save_exam_details.TabIndex = 14;
            this.button_save_exam_details.Text = "SAVE";
            this.button_save_exam_details.UseVisualStyleBackColor = false;
            this.button_save_exam_details.Click += new System.EventHandler(this.button_save_exam_details_Click);
            // 
            // tabPage_change_password_teacher
            // 
            this.tabPage_change_password_teacher.BackColor = System.Drawing.Color.Black;
            this.tabPage_change_password_teacher.Controls.Add(this.button_change_password);
            this.tabPage_change_password_teacher.Controls.Add(this.button_refresh_teacher_password);
            this.tabPage_change_password_teacher.Controls.Add(this.button_cancel);
            this.tabPage_change_password_teacher.Controls.Add(this.textBox_new_password_teacher);
            this.tabPage_change_password_teacher.Controls.Add(this.textBox_retype_password_teacher);
            this.tabPage_change_password_teacher.Controls.Add(this.textBox_prev_password_teacher);
            this.tabPage_change_password_teacher.Controls.Add(this.label_new_password);
            this.tabPage_change_password_teacher.Controls.Add(this.label_retype_password);
            this.tabPage_change_password_teacher.Controls.Add(this.label_prev_password);
            this.tabPage_change_password_teacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_change_password_teacher.Location = new System.Drawing.Point(4, 34);
            this.tabPage_change_password_teacher.Name = "tabPage_change_password_teacher";
            this.tabPage_change_password_teacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_change_password_teacher.Size = new System.Drawing.Size(783, 462);
            this.tabPage_change_password_teacher.TabIndex = 2;
            this.tabPage_change_password_teacher.Text = "Change Password";
            // 
            // button_change_password
            // 
            this.button_change_password.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_change_password.Location = new System.Drawing.Point(561, 275);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(122, 27);
            this.button_change_password.TabIndex = 4;
            this.button_change_password.Text = " CHANGE";
            this.button_change_password.UseVisualStyleBackColor = true;
            this.button_change_password.Click += new System.EventHandler(this.button_change_password_Click);
            // 
            // button_refresh_teacher_password
            // 
            this.button_refresh_teacher_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh_teacher_password.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_refresh_teacher_password.Location = new System.Drawing.Point(357, 276);
            this.button_refresh_teacher_password.Name = "button_refresh_teacher_password";
            this.button_refresh_teacher_password.Size = new System.Drawing.Size(117, 27);
            this.button_refresh_teacher_password.TabIndex = 5;
            this.button_refresh_teacher_password.Text = "REFRESH";
            this.button_refresh_teacher_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_refresh_teacher_password.UseVisualStyleBackColor = true;
            this.button_refresh_teacher_password.Click += new System.EventHandler(this.button_refresh_teacher_password_Click);
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
            // textBox_new_password_teacher
            // 
            this.textBox_new_password_teacher.Location = new System.Drawing.Point(421, 136);
            this.textBox_new_password_teacher.Name = "textBox_new_password_teacher";
            this.textBox_new_password_teacher.Size = new System.Drawing.Size(262, 31);
            this.textBox_new_password_teacher.TabIndex = 2;
            // 
            // textBox_retype_password_teacher
            // 
            this.textBox_retype_password_teacher.Location = new System.Drawing.Point(421, 186);
            this.textBox_retype_password_teacher.Name = "textBox_retype_password_teacher";
            this.textBox_retype_password_teacher.Size = new System.Drawing.Size(262, 31);
            this.textBox_retype_password_teacher.TabIndex = 3;
            // 
            // textBox_prev_password_teacher
            // 
            this.textBox_prev_password_teacher.Location = new System.Drawing.Point(421, 84);
            this.textBox_prev_password_teacher.Name = "textBox_prev_password_teacher";
            this.textBox_prev_password_teacher.Size = new System.Drawing.Size(262, 31);
            this.textBox_prev_password_teacher.TabIndex = 1;
            // 
            // label_new_password
            // 
            this.label_new_password.AutoSize = true;
            this.label_new_password.ForeColor = System.Drawing.Color.White;
            this.label_new_password.Location = new System.Drawing.Point(119, 139);
            this.label_new_password.Name = "label_new_password";
            this.label_new_password.Size = new System.Drawing.Size(173, 25);
            this.label_new_password.TabIndex = 2;
            this.label_new_password.Text = "New Password:";
            // 
            // label_retype_password
            // 
            this.label_retype_password.AutoSize = true;
            this.label_retype_password.ForeColor = System.Drawing.Color.White;
            this.label_retype_password.Location = new System.Drawing.Point(119, 189);
            this.label_retype_password.Name = "label_retype_password";
            this.label_retype_password.Size = new System.Drawing.Size(269, 25);
            this.label_retype_password.TabIndex = 1;
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
            this.tabPage_log_out.Size = new System.Drawing.Size(783, 462);
            this.tabPage_log_out.TabIndex = 3;
            this.tabPage_log_out.Text = "Log Out";
            // 
            // TeacherPanelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.tabControl_teacher_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherPanelUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanelUi";
            this.Load += new System.EventHandler(this.TeacherPanelUi_Load);
            this.tabControl_teacher_panel.ResumeLayout(false);
            this.tabPage_teacher_exam_list.ResumeLayout(false);
            this.tabPage_teacher_exam_list.PerformLayout();
            this.tabPage_create_exam.ResumeLayout(false);
            this.tabPage_create_exam.PerformLayout();
            this.tabPage_change_password_teacher.ResumeLayout(false);
            this.tabPage_change_password_teacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_teacher_panel;
        private System.Windows.Forms.TabPage tabPage_teacher_exam_list;
        private System.Windows.Forms.Button button_currentExam_remove;
        private System.Windows.Forms.ListView listView_teacher_current_exam;
        private System.Windows.Forms.ColumnHeader columnHeader_course_code;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_date;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_time;
        private System.Windows.Forms.ColumnHeader columnHeader_exam_duration;
        private System.Windows.Forms.Label label_current_exam_infor;
        private System.Windows.Forms.TabPage tabPage_create_exam;
        private System.Windows.Forms.TextBox textBox_total_students;
        private System.Windows.Forms.TextBox textBox_total_marks;
        private System.Windows.Forms.TextBox textBox_course_code;
        private System.Windows.Forms.Label label_total_student;
        private System.Windows.Forms.Label label_total_marks;
        private System.Windows.Forms.Label label_course_code;
        private System.Windows.Forms.Button button_refresh_exam_info;
        private System.Windows.Forms.Button button_save_exam_details;
        private System.Windows.Forms.TabPage tabPage_change_password_teacher;
        private System.Windows.Forms.Button button_change_password;
        private System.Windows.Forms.Button button_refresh_teacher_password;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_new_password_teacher;
        private System.Windows.Forms.TextBox textBox_retype_password_teacher;
        private System.Windows.Forms.TextBox textBox_prev_password_teacher;
        private System.Windows.Forms.Label label_new_password;
        private System.Windows.Forms.Label label_retype_password;
        private System.Windows.Forms.Label label_prev_password;
        private System.Windows.Forms.TabPage tabPage_log_out;
        private System.Windows.Forms.Button button_enter_exam;
        private System.Windows.Forms.Label label_exam_info;
        private System.Windows.Forms.Label label_exam_duration;
        private System.Windows.Forms.Label label_exam_time;
        private System.Windows.Forms.Label label_exam_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_exam_date_time;
        private System.Windows.Forms.ComboBox comboBox_duration_mm;
        private System.Windows.Forms.ComboBox comboBox_exam_time_mm;
        private System.Windows.Forms.ComboBox comboBox_duration_hh;
        private System.Windows.Forms.ComboBox comboBox_exam_time_hh;
        private System.Windows.Forms.Label label_duration_mm;
        private System.Windows.Forms.Label label_duration_hh;
        private System.Windows.Forms.Label label_exam_time_mm;
        private System.Windows.Forms.Label label_exam_time_hh;
        private System.Windows.Forms.ComboBox comboBox_am_pm;
    }
}