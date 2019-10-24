using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace TEST
{
    public partial class StudentAddUi : Form
    {
        public string TeacherId { get;private set; }
        public string CourseCode { get; private set; }
        public string TotalStudents { get; private set; }
        public string TotalMarks { get; private set; }
        public StudentAddUi()
        {
            InitializeComponent();
        }

        
        private void StudentAddUi_Load(object sender, EventArgs e)
        {
            
            TeacherId = ExamTeacherInfo.ExamTeacherId;
            CourseCode = ExamTeacherInfo.ExamCourseCode;
            TotalStudents = ExamTeacherInfo.ExamTotalStudents;
            TotalMarks = ExamTeacherInfo.ExamTotalMarks;
            label_student_remaining.Text = TotalStudents + " student data remaining";
            //MessageBox.Show(TeacherId + " " + CourseCode + " " + TotalStudents + " " + TotalMarks);
            FillUpStudentInfo();
        }

        private void button_student_add_Click(object sender, EventArgs e)
        {
            if(TotalStudents == "0")
            {
                MessageBox.Show("You can not add more student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshStudentInfo();
                return;
            }

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string studentId = textBox_student_id.Text;
            string password = textBox_password.Text;
            string teacherId = TeacherId;
            string courseCode = CourseCode;
            string marks = "-1";

            if (studentId.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please fill up all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshStudentInfo();
            }
            else
            {
                String query = "Select * from Student_Master Where Student_Id= '"+studentId+"'AND Teacher_Id='"+ teacherId + "' AND Course_Code= '"+ courseCode + "'";
                SqlCommand selectCommand = new SqlCommand(query);
                sqlcon.readDatathroughAdapter(query, table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("You can't add same student twice", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshStudentInfo();
                }
                else
                {
                    table.Clear();
                    query = "Select * from Student_Master Where Student_Id= '" + studentId + "'AND Password= '"+password+"'";
                    sqlcon.readDatathroughAdapter(query, table);

                    if(table.Rows.Count > 0)
                    {
                        sqlcon.closeConn();
                        MessageBox.Show("You can't add same student twice", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshStudentInfo();
                        return;
                    }

                    query = "Insert into Student_Master(Student_Id, Password, Teacher_Id, Course_Code, Marks) values(@studentId, @password, @teacherId, @courseCode, @marks)";
                    SqlCommand insertCommand = new SqlCommand(query);

                    insertCommand.Parameters.AddWithValue("@studentId", studentId);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@teacherId", teacherId);
                    insertCommand.Parameters.AddWithValue("@courseCode", courseCode);
                    insertCommand.Parameters.AddWithValue("@marks", marks);

                    int row = sqlcon.executeQuery(insertCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TotalStudents = (Int32.Parse(TotalStudents) - 1).ToString();
                        FillUpStudentInfo();
                        RefreshStudentInfo();
                        label_student_remaining.Text = TotalStudents + " student data remaining";
                        if (TotalStudents == "0")
                        {
                            button_finish.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data unable to added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshStudentInfo();
                    }
                }
            }
            sqlcon.closeConn();
        }

        private void RefreshStudentInfo()
        {
            textBox_student_id.Text = "" ;
            textBox_password.Text = "";
        }

        private void FillUpStudentInfo()
        {
            StudentInfoHeaderCreate();
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string query = "Select Student_Id,Password from Student_Master Where Teacher_Id= '"+TeacherId+"' AND Course_Code= '"+CourseCode+"'";

            sqlcon.readDatathroughAdapter(query, table);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Student_Id"].ToString());
                listitem.SubItems.Add(dr["Password"].ToString());

                listView_student_info.Items.Add(listitem);
            }
            sqlcon.closeConn();
        }

        private void StudentInfoHeaderCreate()
        {
            listView_student_info.Clear();
            listView_student_info.Columns.Add("             Student Id", 339, HorizontalAlignment.Center);
            listView_student_info.Columns.Add("Password", 261, HorizontalAlignment.Center);
     
        }

        private void button_student_refresh_Click(object sender, EventArgs e)
        {
            RefreshStudentInfo();
        }

        private void button_student_remove_Click(object sender, EventArgs e)
        {

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            if (listView_student_info.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_student_info.SelectedItems[0];
                string studentId = item.SubItems[0].Text;
                string password = item.SubItems[1].Text;

                string query = "Delete from Student_Master Where Student_Id = '" + studentId + "' AND Password= '"+password+"'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TotalStudents = (Int32.Parse(TotalStudents) + 1).ToString();
                    FillUpStudentInfo();
                    RefreshStudentInfo();
                    label_student_remaining.Text = TotalStudents + " student data remaining";
                    button_finish.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefreshStudentInfo();
                }

            }
            else
            {
                MessageBox.Show("Please Select a data to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshStudentInfo();
            }
            sqlcon.closeConn();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            QuestionPaperUi questionAdd = new QuestionPaperUi();
            questionAdd.Show();
            this.Hide();
        }
    }
}
