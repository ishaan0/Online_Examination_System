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
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace TEST
{


    public partial class ParticipantInfo : Form
    {

        public string ExamDate;
        public string ExamTime;

        private string GetFilePathAnswer()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode + "_" + ExamTeacherInfo.StudentId + "_Answer" + ".txt";
            return path;
        }
        public ParticipantInfo()
        {
            InitializeComponent();
        }

        private void FillUpStudentInfo()
        {
            ParticipantInfoHeaderCreate();

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string query = "Select Student_Id,Password from Student_Master where Teacher_Id='" + ExamTeacherInfo.ExamTeacherId + "'  AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "' AND Marks= '-1'";

            sqlcon.readDatathroughAdapter(query, table);

            if(table.Rows.Count == 0)
            {
                sqlcon.closeConn();
                resultShow();
            }


            for (int i = 0; i < table.Rows.Count; i++)
            {

                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Student_Id"].ToString());
                listitem.SubItems.Add(dr["Password"].ToString());
                listView_participant_info.Items.Add(listitem);
            }
            sqlcon.closeConn();
        }

        private void ParticipantInfoHeaderCreate()
        {
            listView_participant_info.Clear();
            listView_participant_info.Columns.Add("                    Student Id", 370, HorizontalAlignment.Center);
            listView_participant_info.Columns.Add("Password", 370, HorizontalAlignment.Center);

        }

        private void ParticipantInfo_Load(object sender, EventArgs e)
        {
            panel1_result.Hide();
            if (IsExamEnd())
            {
                resultShow();
                return;
            }
            FillUpStudentInfo();
        }

        private void FillUpMarkInfo()
        {
            MarkInfoHeaderCreate();

            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();

            string query = "Select Student_Id,Marks from Student_Master where Teacher_Id='" + ExamTeacherInfo.ExamTeacherId + "'  AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "' AND Marks != '-1'";

            sqlcon.readDatathroughAdapter(query, table);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                DataRow dr = table.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Student_Id"].ToString());
                listitem.SubItems.Add(dr["Marks"].ToString());
                listView_show_result.Items.Add(listitem);
            }
            sqlcon.closeConn();
        }

        private void MarkInfoHeaderCreate()
        {
            listView_show_result.Clear();
            listView_show_result.Columns.Add("                    Student Id", 370, HorizontalAlignment.Center);
            listView_show_result.Columns.Add("Marks", 370, HorizontalAlignment.Center);
        }


        private void resultShow()
        {
            panel1_result.Show();
            FillUpMarkInfo();
            button_show_result.Text = "Hide";
            button_show_result.Enabled = false;
            button_enter_participant_info.Enabled = false;
            button_participant_remove.Enabled = false;
        }

        

        private void SetExamDateTime()
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();
            string query = "Select Exam_Date,Exam_Time from Exam_Master Where Teacher_Id= '" + ExamTeacherInfo.ExamTeacherId + "' AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "'";
            sqlcon.readDatathroughAdapter(query, table);

            if (table.Rows.Count == 1)
            {
                ExamDate = table.Rows[0]["Exam_Date"].ToString();
                ExamTime = table.Rows[0]["Exam_Time"].ToString();
            }
            else MessageBox.Show("Exam date and time not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlcon.closeConn();
        }

        private string GetExamDuration()
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();
            string duration = "";
            string query = "Select Exam_Duration from Exam_Master Where Teacher_Id= '" + ExamTeacherInfo.ExamTeacherId + "' AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "'";
            sqlcon.readDatathroughAdapter(query, table);

            if (table.Rows.Count == 1)
            {
                duration = table.Rows[0]["Exam_Duration"].ToString();
                duration = duration.Substring(0, 5);
            }
            else MessageBox.Show("Exam duration not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlcon.closeConn();
            return duration;
        }

        private DateTime GetExamLastTime()
        {
            //DateTime examEndTime = Convert.ToDateTime(ExamTime);
            DateTime examEndTime = DateTime.ParseExact(ExamTime, "hh:mm tt", null);
            string examDuration = GetExamDuration();

            TimeSpan duration = new TimeSpan(0, (Int32.Parse(examDuration.Substring(0, 2))), (Int32.Parse(examDuration.Substring(3, 2))), 0);
            examEndTime = examEndTime.Add(duration);

            return examEndTime;
        }

        private bool IsValidTime(string currentTime, string examTime)
        {
            // DateTime exmTime = Convert.ToDateTime(examTime);
            DateTime exmTime = DateTime.ParseExact(examTime, "hh:mm tt", null);
            DateTime endTime = GetExamLastTime();
            DateTime crntTime = DateTime.Now;

            if (crntTime > endTime)
            {
                return true;
            }
            return false;

        }

        private bool IsExamEnd()
        {
            // work pending .. 
            SetExamDateTime();
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string time = DateTime.Now.ToString("hh:mm tt");

            if (DateTime.ParseExact(ExamDate, "dd.MM.yyyy", null) > DateTime.ParseExact(date, "dd.MM.yyyy", null) ||
                (DateTime.ParseExact(ExamDate, "dd.MM.yyyy", null) == DateTime.ParseExact(date, "dd.MM.yyyy", null) && IsValidTime(time, ExamTime)))
            {
                DBAccess sqlcon = new DBAccess();
                string mark = "0";

                string query = "Update Student_Master SET Marks= '" + mark + "' where Teacher_Id= '" + ExamTeacherInfo.ExamTeacherId + "' AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "' AND Marks = '"+"-1"+"'";
                SqlCommand updateCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(updateCommand);
                sqlcon.closeConn();
                if (row > 0)
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("Absent student marks unable to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }

                return false;
        }

        private void button_participant_remove_Click(object sender, EventArgs e)
        {
            if (listView_participant_info.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_participant_info.SelectedItems[0];
                string studentId = item.SubItems[0].Text;
                ExamTeacherInfo.StudentId = studentId;

                DBAccess sqlcon = new DBAccess();
                DataTable table = new DataTable();

                string query = "Delete from Student_Master Where Teacher_Id = '" + ExamTeacherInfo.ExamTeacherId + "'  AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "' AND Student_Id= '" + ExamTeacherInfo.StudentId + "'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillUpStudentInfo();

                }
                else
                {
                    MessageBox.Show("Data unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                sqlcon.closeConn();
            }
            else
            {
                MessageBox.Show("Please select a student Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button_enter_participant_info_Click(object sender, EventArgs e)
        {
            if (listView_participant_info.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_participant_info.SelectedItems[0];
                string studentId = item.SubItems[0].Text;
                ExamTeacherInfo.StudentId = studentId;


                if (File.Exists(GetFilePathAnswer()))
                {
                    AnswerSheetUi answerSheet = new AnswerSheetUi();
                    answerSheet.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Exam is not completed yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Please select a student Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            TeacherPanelUi back = new TeacherPanelUi();
            back.Show();
            this.Hide();
        }

        private void button_show_result_Click(object sender, EventArgs e)
        {
            if(button_show_result.Text == "Show")
            {
                button_show_result.Text = "Hide";
                FillUpMarkInfo();
                panel1_result.Show();
                button_enter_participant_info.Enabled = false;
                button_participant_remove.Enabled = false;
            }
            else
            {
                button_show_result.Text = "Show";
                FillUpStudentInfo();
                panel1_result.Hide();
                button_enter_participant_info.Enabled = true;
                button_participant_remove.Enabled = true;
            }

        }
    }
}
