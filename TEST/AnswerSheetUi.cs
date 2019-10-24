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
    public partial class AnswerSheetUi : Form
    {
      
        public int CurrentMark { get; set; }
        public int TotalMarks { get; set; }
        public int IndexQuestion { get; set; }
        public int TotalQuestions { get; set; }
        public int QuestionNumber { get; set; }
        List<string> Questions = new List<string>();
        List<string> Answers = new List<string>();
        public AnswerSheetUi()
        {
            QuestionNumber = 0;
            InitializeComponent();
        }

        private void AnswerSheetUi_Load(object sender, EventArgs e)
        {
            TotalMarks = 0;
            IndexQuestion = 0;
            QuestionNumber = QuestionNumber + 1;

            if (!File.Exists(GetFilePathAnswer()))
            {
                MessageBox.Show("Answer file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ParticipantInfo participantPage = new ParticipantInfo();
                participantPage.Show();
                this.Hide();
            }
            else
            {
                using(StreamReader read = new StreamReader(GetFilePathAnswer()))
                {
                    string line;
                    while((line = read.ReadLine()) != null)
                    {
                        Answers.Add(line);
                    }
                }
            }

            if (!File.Exists(GetFilePathQuestion()))
            {
                MessageBox.Show("Question file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TeacherPanelUi teacherPanel = new TeacherPanelUi();
                teacherPanel.Show();
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
            ShowQuestionAndAnswer();
        }

        private string GetFilePathQuestion()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode + "_Question" + ".txt";
            return path;
        }
        private string GetFilePathAnswer()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + ExamTeacherInfo.ExamTeacherId + "_" + ExamTeacherInfo.ExamCourseCode+"_"+ ExamTeacherInfo.StudentId + "_Answer" + ".txt";
            return path;
        }

        private void ShowQuestionAndAnswer()
        {
            
            label_student_id_show.Text = ExamTeacherInfo.StudentId;
            label_question_number.Text = (QuestionNumber).ToString();
            label_remaing_answer.Text = (TotalQuestions - QuestionNumber).ToString() + " answer remaining";
            CurrentMark = Int32.Parse(Questions[IndexQuestion + 1]);
            richTextBox_question_show.Text = Questions[IndexQuestion];
            richTextBox_answer_show.Text = Answers[IndexQuestion];
            label_full_marks.Text = Questions[IndexQuestion + 1];
            IndexQuestion = IndexQuestion + 2;
            textBox_given_marks.Text = "";
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            QuestionNumber = QuestionNumber + 1;

            string marks;
            try
            {
                marks = Int32.Parse(textBox_given_marks.Text).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please put integer value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_given_marks.Text = "";
                return;
            }
            if (Int32.Parse(marks) > CurrentMark)
            {
                MessageBox.Show("You can't give more marks", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_given_marks.Text = "";
                return;
            }
            TotalMarks += (Int32.Parse(marks));

            if (QuestionNumber > TotalQuestions)
            {
                DBAccess sqlcon = new DBAccess();

                string query = "Update Student_Master SET Marks= '" + TotalMarks.ToString() + "' where Student_Id = '" + ExamTeacherInfo.StudentId + "' AND Teacher_Id= '" + ExamTeacherInfo.ExamTeacherId + "' AND Course_Code= '" + ExamTeacherInfo.ExamCourseCode + "'";
                SqlCommand updateCommand = new SqlCommand(query);

                int row = sqlcon.executeQuery(updateCommand);
                if (row > 0)
                {
                    MessageBox.Show("Data added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccefull to add data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_given_marks.Text = "";
                }

                sqlcon.closeConn();
                ParticipantInfo back = new ParticipantInfo();
                back.Show();
                this.Hide();

            }
            else
            {

                ShowQuestionAndAnswer();
            }
                
        }
    }
}
