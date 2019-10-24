using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class StudentPanelUi : Form
    {
        public bool isActive;
        public int MilSecond;
        public int Second;
        public int Minute;
        public int Hour;
        public string ExamDate;
        public string ExamTime;
        public int IndexQuestion { get; set; }
        public int TotalQuestions { get; set; }
        public int QuestionNumber { get; set; }
        List<string> Questions = new List<string>();
        List<string> Answers = new List<string>();
        public StudentPanelUi()
        {
            InitializeComponent();
            isActive = false;
        }
        private void SetExamDateTime()
        {
            DBAccess sqlcon = new DBAccess();
            DataTable table = new DataTable();
            string query = "Select Exam_Date,Exam_Time from Exam_Master Where Teacher_Id= '" + ExamTeacherInfo.ExamTeacherId + "' AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "'";
            sqlcon.readDatathroughAdapter(query, table);

            if(table.Rows.Count == 1)
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

            if(table.Rows.Count == 1)
            {
                duration = table.Rows[0]["Exam_Duration"].ToString();
                duration = duration.Substring(0, 5);
            }
            else MessageBox.Show("Exam duration not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlcon.closeConn();
            return duration;
        }
        private void timer_exam_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {

                Second--;

                if(Second <= 0)
                {
                    Second = 59;
                    Minute--;
                }
                if(Minute == 0)
                {
                    Minute = 59;
                    Hour--;
                }
                if(Minute == 0 && Hour == 0)
                {
                    makeDisable();
                }
                ShowTimer();


            }
        }
        private void ShowTimer()
        {
            
            label_hour.Text = string.Format("{0:00}",Hour);
            label_minute.Text = string.Format("{0:00}", Minute);
            label_second.Text = string.Format("{0:00}", Second);
        }
        private bool IsValidTime(string currentTime, string examTime)
        {
            //DateTime exmTime = Convert.ToDateTime(examTime);
            DateTime exmTime = DateTime.ParseExact(examTime, "hh:mm tt", null);
            DateTime endTime = GetExamLastTime();
            DateTime crntTime = DateTime.Now;
           
            if (exmTime <= crntTime  && (crntTime < endTime ))
            {
                return true;
            }
            return false;

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

        private void CreateFile()
        {
            if (!File.Exists(GetFilePathAnswer()))
            {
                File.CreateText(GetFilePathAnswer()).Dispose();
            }
        }

        
        private string GetFilePathQuestion()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode + "_Question" + ".txt";
            return path;
        }
        private string GetFilePathAnswer()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode + "_" + ExamTeacherInfo.StudentId + "_Answer" + ".txt";
            return path;
        }
        private void ShowQuestionAndAnswer()
        {
            
            label_question_number.Text = (QuestionNumber).ToString();
            label_remaing_answer.Text = (TotalQuestions - QuestionNumber).ToString() + " answer remaining";

            richTextBox_question_show.Text = Questions[IndexQuestion];
            richTextBox_answer_show.Text = Answers[IndexQuestion];
            label_marks.Text = Questions[IndexQuestion + 1];
            
        }
        private void StudentPanelUi_Load(object sender, EventArgs e)
        {
            loadFunction();
        }
        private void loadFunction()
        {
            // pending ..
            // format hh:mm tt
            //Convert.ToDateTime("2.3.4");
            Second = 59;
            SetExamDateTime();
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string time = DateTime.Now.ToString("hh:mm tt");

            //if ((Convert.ToDateTime(ExamDate)).Date == (Convert.ToDateTime(date)).Date && IsValidTime(time, ExamTime))
            if(DateTime.ParseExact(ExamDate,"dd.MM.yyyy",null) == DateTime.ParseExact(date, "dd.MM.yyyy", null) && IsValidTime(time, ExamTime))
            {
                makeEnable();
                string timeDuration = (GetExamDuration().Substring(0, 5));

                DateTime crntTime = DateTime.Now;
                DateTime endTime = GetExamLastTime();
                TimeSpan diff = endTime - crntTime;
                
                Hour = diff.Hours;
                Minute = diff.Minutes;
 
                ShowTimer();

                IndexQuestion = -2;
                QuestionNumber = 1;

                if (!File.Exists(GetFilePathQuestion()))
                {
                    MessageBox.Show("Question file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogInUi loginPage = new LogInUi();
                    loginPage.Show();
                    this.Hide();
                }
                else
                {
                    using (StreamReader read = new StreamReader(GetFilePathQuestion()))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            if (line != "★★★")
                            {
                                Questions.Add(line);
                            }
                        }
                    }
                }
                TotalQuestions = (Questions.Count) / 2;
                for (int i = 0; i < TotalQuestions * 2; i++)
                    Answers.Add(" ");
                Answers.Add(" ");
                IndexQuestion = IndexQuestion + 2;
                ShowQuestionAndAnswer();
                button_previous.Enabled = false;
                if (QuestionNumber == TotalQuestions)
                    button_next.Enabled = false;
                CreateFile();
            }
            else
            {
                MessageBox.Show("Exam is not running", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makeDisable();
            }
        }
        private void makeDisable()
        {
            FlipEnableForm(false);
        }
        private void makeEnable()
        {
            FlipEnableForm(true);
        }
        private void FlipEnableForm(bool val)
        {
            richTextBox_question_show.Enabled = val;
            richTextBox_answer_show.Enabled = val;
            label_marks.Enabled = val;
            label_remaing_answer.Enabled = val;
            button_previous.Enabled = val;
            button_next.Enabled = val;
            label_hour.Enabled = val;
            label7.Enabled = val;
            label_minute.Enabled = val;
            label8.Enabled = val;
            label_second.Enabled = val;
            label_question_number.Enabled = val;
            isActive = val;

        }
        private void button_next_Click(object sender, EventArgs e)
        {
            string ans = richTextBox_answer_show.Text;
            if (ans.Equals(""))
                ans = " ";

            Answers[IndexQuestion] = ans;
            Answers[IndexQuestion+1] = "★★★";
            QuestionNumber += 1;
            IndexQuestion = IndexQuestion + 2;
            ShowQuestionAndAnswer();
            button_previous.Enabled = true;

            if (QuestionNumber == TotalQuestions)
                button_next.Enabled = false;

        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            string ans = richTextBox_answer_show.Text;
            if (ans.Equals(""))
                ans = " ";

            Answers[IndexQuestion] = ans;
            Answers[IndexQuestion+1] = "★★★";
            QuestionNumber -= 1;
            IndexQuestion = IndexQuestion - 2;
            ShowQuestionAndAnswer();
            button_next.Enabled = true;

            if (QuestionNumber == 1)
                button_previous.Enabled = false;

        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to finish ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                if (File.Exists(GetFilePathAnswer()))
                {
                    using (StreamWriter file = new StreamWriter(GetFilePathAnswer()))
                    {
                        foreach (string line in Answers)
                        {
                            file.WriteLine(line);
                            
                        }
                    }

                    LogInUi logInPage = new LogInUi();
                    logInPage.Show();
                    this.Hide();

                }
                else MessageBox.Show("Not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_reload_page_Click(object sender, EventArgs e)
        {
            if(!isActive)
                loadFunction();
        }
    }
}
