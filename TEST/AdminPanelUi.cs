using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace TEST
{
    public partial class AdminPanelUi : Form
    {

        public AdminPanelUi()
        {
            InitializeComponent();
        }

        private void AdminPanelUi_Load_1(object sender, EventArgs e)
        {
            CurrentExamInfoFillUp();
        }

        private void button_teacher_add_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            
            string teacherName = textBox_teacher_name.Text;
            string teacherId = textBox_teacher_id.Text;
            string teacherPassword = textBox_teacher_password.Text;
            string designation = "TEACHER";

            if (teacherName.Equals("") || teacherId.Equals("") || teacherPassword.Equals(""))
            {
                MessageBox.Show("Please fillup all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTeacherInfo();
            }
            else
            {
                string query = "Insert into User_Master(User_Id,User_Name,Password,Designation) values('" + teacherId + "','" + teacherName + "','" + teacherPassword + "','" + designation + "')";
                SqlCommand insertCommand = new SqlCommand("insert into User_Master(User_Id,User_Name,Password,Designation) values(@teacherId,@teacherName,@teacherPassword,@designation)");
                
                insertCommand.Parameters.AddWithValue("@teacherId", teacherId);
                insertCommand.Parameters.AddWithValue("@teacherName", teacherName);
                insertCommand.Parameters.AddWithValue("@teacherPassword", teacherPassword);
                insertCommand.Parameters.AddWithValue("@designation", designation);

                int row = sqlcon.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillUpTeachersInfo();
                    RefreshTeacherInfo();
                }
                else
                {
                    MessageBox.Show("Data unable to added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefreshTeacherInfo();
                }
            }
            sqlcon.closeConn();
        }

        private void FillUpTeachersInfo()
        {
            TeacherInfoHeaderCreate();
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string admin = "admin";
            string query = "Select USER_NAME,User_Id,Password from User_Master where User_Id != '" + admin + "' AND User_Name != '"+"admin"+"'";

            sqlcon.readDatathroughAdapter(query, table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                
                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["USER_NAME"].ToString());
                listitem.SubItems.Add(dr["User_Id"].ToString());
                listitem.SubItems.Add(dr["Password"].ToString());

                listView_teachers_info.Items.Add(listitem);
            }
            sqlcon.closeConn();
        }

        private void RefreshTeacherInfo()
        {
            textBox_teacher_name.Text = "";
            textBox_teacher_id.Text = "";
            textBox_teacher_password.Text = "";
        }

        private void button_teacher_remove_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            if(listView_teachers_info.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_teachers_info.SelectedItems[0];
                string teacherId = item.SubItems[1].Text;

                string query = "Delete from User_Master Where User_Id = '" + teacherId + "'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillUpTeachersInfo();
                    RefreshTeacherInfo();
                }
                else
                {
                    MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefreshTeacherInfo();
                }
                
            }
            else
            {
                MessageBox.Show("Please Select a data to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTeacherInfo();
            }
            sqlcon.closeConn();
        }

        private void TeacherInfoHeaderCreate()
        {
            listView_teachers_info.Clear();
            listView_teachers_info.Clear();
            listView_teachers_info.Columns.Add("          Name", 206, HorizontalAlignment.Center);
            listView_teachers_info.Columns.Add("Teacher Id", 204, HorizontalAlignment.Center);
            listView_teachers_info.Columns.Add("Password", 204, HorizontalAlignment.Center);

        }

        private void button_teacher_refresh_Click(object sender, EventArgs e)
        {
            RefreshTeacherInfo();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string oldPassword = textBox_prev_password.Text;
            string newPassword = textBox_new_password.Text;
            string reTypedPassword = textBox_retype_password.Text;

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
                string username = "admin";
                
                string query = "Select * from User_Master where User_Id= '" + username + "' AND Password= '" + oldPassword + "'";
                sqlcon.readDatathroughAdapter(query, table);

                if (table.Rows.Count == 1)
                {
                    
                    query = "Update User_Master SET Password= '" + newPassword + "' where User_Id = '" + "admin" + "'";
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
            textBox_prev_password.Text = "";
            textBox_new_password.Text = "";
            textBox_retype_password.Text = "";
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshCangePassword();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_admin_panel_Selected(object sender, TabControlEventArgs e)
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
            else if(e.TabPage == tabPage_teacher_info)
            {
                FillUpTeachersInfo();
            }
            else if(e.TabPage == tabPage_current_exams)
            {
                CurrentExamInfoFillUp();
            }
        }


        private void CurrentExamInfoFillUp()
        {
            CurrentExamInfoHeaderCreate();

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            
            string query = "Select Course_Code,Teacher_Id,Exam_Date,Exam_Time,Exam_Duration from Exam_Master ";

            sqlcon.readDatathroughAdapter(query, table);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Course_Code"].ToString());
                listitem.SubItems.Add(dr["Teacher_Id"].ToString());
                listitem.SubItems.Add(dr["Exam_Date"].ToString());
                listitem.SubItems.Add(dr["Exam_Time"].ToString());
                listitem.SubItems.Add(dr["Exam_Duration"].ToString());

                listView_current_exam.Items.Add(listitem);
            }
            sqlcon.closeConn();
        }

        private void CurrentExamInfoHeaderCreate()
        {
            listView_current_exam.Clear();
            listView_current_exam.Columns.Add("Course Code", 155, HorizontalAlignment.Left);
            listView_current_exam.Columns.Add("Teacher Id", 174, HorizontalAlignment.Center);
            listView_current_exam.Columns.Add("Date", 138, HorizontalAlignment.Center);
            listView_current_exam.Columns.Add("Time", 143, HorizontalAlignment.Center);
            listView_current_exam.Columns.Add("Duration", 129, HorizontalAlignment.Center);

        }

        private void button_currentExam_remove_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            if (listView_current_exam.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_current_exam.SelectedItems[0];
                string courseCode = item.SubItems[0].Text;
                string teacherId = item.SubItems[1].Text;

                string query = "Delete from Exam_Master Where Teacher_Id = '" + teacherId + "' AND Course_Code= '"+courseCode+"'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(deleteCommand);

                if (row == 1)
                {
                    row = 0;
                    query = "Delete from Student_Master Where Teacher_Id = '" + teacherId + "' AND Course_Code= '" + courseCode + "'";
                    SqlCommand dltCommand = new SqlCommand(query);

                    row = sqlcon.executeQuery(dltCommand);

                    if(row > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CurrentExamInfoFillUp();
                    }
                    else
                    {
                        MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

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

        
    }
}
