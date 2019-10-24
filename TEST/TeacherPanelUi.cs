using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace TEST
{
    public partial class TeacherPanelUi : Form
    {
        public TeacherPanelUi()
        {
            InitializeComponent();
        }


        // Enter Exam work is pending ... 
        private void button_enter_exam_Click(object sender, EventArgs e)
        {

            if (listView_teacher_current_exam.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_teacher_current_exam.SelectedItems[0];
                string courseCode = item.SubItems[0].Text;
                string teacherId = GetTeacherId();

                ExamTeacherInfo.ExamTeacherId = teacherId;
                ExamTeacherInfo.ExamCourseCode = courseCode;

                ParticipantInfo participateInfo = new ParticipantInfo();
                participateInfo.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please Select a data to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void button_currentExam_remove_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            if (listView_teacher_current_exam.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_teacher_current_exam.SelectedItems[0];
                string courseCode = item.SubItems[0].Text;
                string teacherId = GetTeacherId();


                string query = "Delete from Exam_Master Where Teacher_Id = '" + teacherId + "'  AND Course_Code= '"+courseCode+"'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(deleteCommand);

                if (row == 1)
                {
                    row = 0;
                    query = "Delete from Student_Master Where Teacher_Id = '" + teacherId + "'  AND Course_Code= '" + courseCode + "'";
                    SqlCommand dltCommand = new SqlCommand(query);

                    row = sqlcon.executeQuery(dltCommand);
                    if(row > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TeacherCurrentExamInfoFillup();
                    }
                    else MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            else
            {
                MessageBox.Show("Please Select a data to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            sqlcon.closeConn();
        }

        private void TeacherPanelUi_Load(object sender, EventArgs e)
        {
            TeacherCurrentExamInfoFillup();
        }

        private void TeacherCurrentExamInfoFillup()
        {
            TeacherCurrentExamInfoHeaderCreate();

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();
            string teacherId = GetTeacherId();


            string query = "Select Course_Code,Exam_Date,Exam_Time,Exam_Duration from Exam_Master where Teacher_Id='" + teacherId+"'";

            sqlcon.readDatathroughAdapter(query, table);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Course_Code"].ToString());
                listitem.SubItems.Add(dr["Exam_Date"].ToString());
                listitem.SubItems.Add(dr["Exam_Time"].ToString());
                listitem.SubItems.Add(dr["Exam_Duration"].ToString());

                listView_teacher_current_exam.Items.Add(listitem);
            }
            sqlcon.closeConn();

  

        }
        private void TeacherCurrentExamInfoHeaderCreate()
        {
            listView_teacher_current_exam.Clear();
            listView_teacher_current_exam.Columns.Add("    Course Code", 213, HorizontalAlignment.Center);
            listView_teacher_current_exam.Columns.Add("Date", 192, HorizontalAlignment.Center);
            listView_teacher_current_exam.Columns.Add("Time", 180, HorizontalAlignment.Center);
            listView_teacher_current_exam.Columns.Add("Duration", 153, HorizontalAlignment.Center);

        }

        private string GetTeacherId()
        {
            string teacherId = ExamTeacherInfo.ExamTeacherId;

            return teacherId;
        }

        private void tabControl_teacher_panel_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage_log_out)
            {
                DialogResult dr = MessageBox.Show("Are you want to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    LogInUi logInPage = new LogInUi();
                    logInPage.Show();
                    this.Hide();
                }
            }
            else if (e.TabPage == tabPage_teacher_exam_list)
            {
                TeacherCurrentExamInfoFillup(); 
            }
            else if (e.TabPage == tabPage_create_exam)
            {
                for(int i=0; i<13; i++)
                {
                    string strNumber = i.ToString();
                    if(strNumber.Count() == 1)
                    {
                        strNumber = "0" + strNumber;
                    }
                    comboBox_exam_time_hh.Items.Add(strNumber);
                    comboBox_duration_hh.Items.Add(strNumber);
                }

                for (int i = 0; i < 60; i++)
                {
                    string strNumber = i.ToString();
                    if (strNumber.Count() == 1)
                    {
                        strNumber = "0" + strNumber;
                    }
                    comboBox_exam_time_mm.Items.Add(strNumber);
                    comboBox_duration_mm.Items.Add(strNumber);
                }

            }
            
        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string oldPassword = textBox_prev_password_teacher.Text;
            string newPassword = textBox_new_password_teacher.Text;
            string reTypedPassword = textBox_retype_password_teacher.Text;

            if (oldPassword.Equals("") || newPassword.Equals("") || reTypedPassword.Equals(""))
            {
                MessageBox.Show("Please fillup full information", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (newPassword != reTypedPassword)
            {
                MessageBox.Show("Password doesn't match", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string teacherId = GetTeacherId();

                string query = "Select * from User_Master where User_Id= '" + teacherId + "' AND Password= '" + oldPassword + "'";
                sqlcon.readDatathroughAdapter(query, table);

                if (table.Rows.Count == 1)
                {

                    query = "Update User_Master SET Password= '" + newPassword + "' where User_Id = '" + teacherId + "'";
                    SqlCommand updateCommand = new SqlCommand(query);

                    int row = sqlcon.executeQuery(updateCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Data unable to updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Old Password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshCangePassword();
            sqlcon.closeConn();
        }

        private void RefreshCangePassword()
        {
            textBox_prev_password_teacher.Text = "";
            textBox_new_password_teacher.Text = "";
            textBox_retype_password_teacher.Text = "";
        }

        private void button_refresh_teacher_password_Click(object sender, EventArgs e)
        {
            RefreshCangePassword();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_exam_details_Click(object sender, EventArgs e)
        {
           
            string teacherId = GetTeacherId();
            string courseCode = textBox_course_code.Text;
            string totalStudent = textBox_total_students.Text;
            string totalMarks = textBox_total_marks.Text;
            if(courseCode.Contains(" "))
            {
                MessageBox.Show("Course Code cannot contain space", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExamInfo();
                return;
            }
            try
            {
                int stdNumber = Int32.Parse(textBox_total_students.Text);
                int markNumber = Int32.Parse(textBox_total_marks.Text);
                if (stdNumber == 0 || markNumber == 0)
                {
                    MessageBox.Show("Total student and total marks cannot be zero", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamInfo();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Total student and total marks should be integer value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExamInfo();
                return;
            }
            
            string date = dateTimePicker_exam_date_time.Value.ToString("dd.MM.yyyy");
            string time = comboBox_exam_time_hh.Text+ ":" + comboBox_exam_time_mm.Text + " " + comboBox_am_pm.Text;
            string duration = comboBox_duration_hh.Text+ ":" + comboBox_duration_mm.Text+" hour";

            if (IsDuplicateExamInfo(teacherId, courseCode))
            {
                MessageBox.Show("Can't take exam of same course code", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExamInfo();
                return;
            }


            if (IsExamInfoEmpty())
            {
                MessageBox.Show("Please enter full information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExamInfo();
                return;
            }
            else
            {
                
                DateTimePicker currentDate = new DateTimePicker();
                currentDate.Value = DateTime.Now;
                if(currentDate.Value.Date > dateTimePicker_exam_date_time.Value.Date)
                {
                    MessageBox.Show("Date is not valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamInfo();
                    return;
                }
                // format hh:mm tt
                string currentTime = GetCurrentTime();
                if (currentDate.Value == dateTimePicker_exam_date_time.Value && IsInvalidTime(currentTime, time))
                {
                    MessageBox.Show("Time is not valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamInfo();
                    return;
                }
            }
            
            DBAccess sqlcon = new DBAccess();

            
            string query = "insert into Exam_Master(Teacher_Id,Course_Code,Total_Students,Total_Marks,Exam_Date,Exam_Time,Exam_Duration) values(@teacherId,@courseCode,@totalStudent,@totalMarks,@date,@time,@duration)";
            SqlCommand insertCommand = new SqlCommand(query);
            
            insertCommand.Parameters.AddWithValue("@teacherId", teacherId);
            insertCommand.Parameters.AddWithValue("@courseCode", courseCode);
            insertCommand.Parameters.AddWithValue("@totalStudent", totalStudent);
            insertCommand.Parameters.AddWithValue("@totalMarks", totalMarks);
            insertCommand.Parameters.AddWithValue("@date", date);
            insertCommand.Parameters.AddWithValue("@time", time);
            insertCommand.Parameters.AddWithValue("@duration", duration);
            

            int row = sqlcon.executeQuery(insertCommand);
            
            if(row == 1)
            {
                MessageBox.Show("Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExamInfo();
            }
            else
            {
                MessageBox.Show("Data unable to added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshExamInfo();
            }
            sqlcon.closeConn();

            ExamTeacherInfo.ExamTeacherId = teacherId;
            ExamTeacherInfo.ExamCourseCode = courseCode;
            ExamTeacherInfo.ExamTotalStudents = totalStudent;
            ExamTeacherInfo.ExamTotalMarks = totalMarks;
            
            StudentAddUi studentAdd = new StudentAddUi();
            studentAdd.Show();
            this.Hide();
        }

        private void RefreshExamInfo()
        {
            textBox_course_code.Text = "";
            textBox_total_students.Text = "";
            textBox_total_marks.Text = "";
            dateTimePicker_exam_date_time.Value = DateTime.Now;
            comboBox_exam_time_hh.SelectedIndex = -1;
            comboBox_duration_hh.SelectedIndex = -1;
            comboBox_am_pm.SelectedIndex = -1;
        }

        private void button_refresh_exam_info_Click(object sender, EventArgs e)
        {
            RefreshExamInfo();
        }

        private bool IsExamInfoEmpty()
        {
            string courseCode = textBox_course_code.Text;
            string totalStudent = textBox_total_students.Text;
            string totalMarks = textBox_total_marks.Text;

            if (courseCode.Equals("") || totalStudent.Equals("") || totalMarks.Equals(""))
                return true;
            else if (comboBox_exam_time_hh.SelectedIndex == -1 || comboBox_exam_time_mm.SelectedIndex == -1 || comboBox_am_pm.SelectedIndex == -1)
                return true;
            else if (comboBox_duration_hh.SelectedIndex == -1 || comboBox_duration_mm.SelectedIndex == -1)
                return true;
            return false;
        }

        private string GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            string currentTime = time.ToString("hh:mm tt");
            return currentTime;
        }

        private bool IsInvalidTime(string currentTime, string examTime)
        {
            int cH, cM, eH, eM,i;
            cH= cM= eH= eM=i = 0;

            if (currentTime[6] > examTime[6])
                return true;
            else if (currentTime[6] < examTime[6])
                return false;

            i = 0;
            while (i < 2)
            {
                cH = (cH * 10) + currentTime[i];
                eH = (eH * 10) + examTime[i];
            }
            i = 3;
            while(i<5)
            {
                cM = (cM * 10) + currentTime[i];
                eM = (eM * 10) + examTime[i];
            }

            if (cH > eH)
                return true;
            else if (cH < eH)
                return false;

            if (cM >= eM)
                return true;

            return false;
        }

        private bool IsDuplicateExamInfo(string teacherId, string courseCode)
        {
            DBAccess sqlcon = new DBAccess();

            string query = "Select * from Exam_Master Where Teacher_Id= '" + teacherId + "' AND Course_Code= '" + courseCode + "'";
            SqlCommand selectCommand = new SqlCommand(query);

            int row = sqlcon.executeQuery(selectCommand);

            sqlcon.closeConn();
            if (row == 1)
                return true;
            return false;
        }

    }
}
