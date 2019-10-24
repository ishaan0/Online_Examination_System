using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class LogInUi : Form
    {       

        public LogInUi()
        {
            InitializeComponent();
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string designation = comboBox_designation.Text;

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshPage();
            }
            else if(designation.Equals("ADMIN") || designation.Equals("TEACHER"))
            {
                string query = "Select * from User_Master Where User_Id= '" + username + "' AND Password= '" + password + "' AND Designation= '"+designation+"'";

                sqlcon.readDatathroughAdapter(query, table);
                if(table.Rows.Count == 1)
                {
                    MessageBox.Show("Logged In Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillExamTeacherInfo(username, "abcd", "abcd");

                    sqlcon.closeConn();

                    if (designation == "ADMIN")
                    {
                        AdminPanelUi nextPage = new AdminPanelUi();
                        nextPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        TeacherPanelUi nextPage = new TeacherPanelUi();
                        nextPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefreshPage();
                }
            }
            else if(designation.Equals("STUDENT"))
            {

                string query = "Select * from Student_Master Where Student_Id= '" + username + "' AND Password= '" + password + "'";
                SqlCommand selectQuery = new SqlCommand(query);
                
                sqlcon.readDatathroughAdapter(query, table);

                if (table.Rows.Count == 1)
                {
                    table.Clear();
                    query = "Select Teacher_Id,Course_Code from Student_Master Where Student_Id= '" + username + "' AND Password= '" + password + "'";
                    sqlcon.readDatathroughAdapter(query, table);

                    string teacherId = table.Rows[0]["Teacher_Id"].ToString();
                    string courseCode = table.Rows[0]["Course_Code"].ToString();
                    FillExamTeacherInfo(teacherId, courseCode,username);
                    if (isAvailableStudent())
                    {
                        sqlcon.closeConn();
                        StudentPanelUi studentPanel = new StudentPanelUi();
                        studentPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your already submit your answer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshPage();
                    }
                    
                }
                else MessageBox.Show("Incorect id or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Please select a designation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            sqlcon.closeConn();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshPage()
        {
            textBox_username.Text = "";
            textBox_password.Text = "";
            comboBox_designation.SelectedIndex = -1;  
        }

        private void FillExamTeacherInfo(string teacherId,string courseCode,string studentId)
        {
            ExamTeacherInfo.ExamTeacherId = teacherId;
            ExamTeacherInfo.ExamCourseCode = courseCode;
            ExamTeacherInfo.StudentId = studentId;
        }
        private string GetFilePathAnswer()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode + "_" + ExamTeacherInfo.StudentId + "_Answer" + ".txt";
            return path;
        }
        private bool isAvailableStudent()
        {
            if (File.Exists(GetFilePathAnswer()))
            {
                return false;
            }
            return true;
        }

        private void LogInUi_Load(object sender, EventArgs e)
        {

        }
    }
}
