using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class QuestionPaperUi : Form
    {
        public string TeacherId { get;private set; }
        public string CourseCode { get; private set; }
        public string TotalMarks { get; private set; }
        private List<string> QuestionList = new List<string>();
        private List<string> QuestionMarks = new List<string>();
        public QuestionPaperUi()
        {
            InitializeComponent();
        }

        private void button_question_add_Click(object sender, EventArgs e)
        {
            string question = richTextBox_question.Text;
            string marks = textBox_question_marks.Text;
            if(question.Equals("") || marks.Equals(""))
            {
                MessageBox.Show("Fill up full data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshQuestionAndMarks();
                return;
            }
            int remainingMarks=0;
            int currentMarks=0;

            try
            {
                remainingMarks = Int32.Parse(TotalMarks);
                currentMarks = Int32.Parse(marks);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please put integer value for marks", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(remainingMarks == 0)
            {
                MessageBox.Show("You cannot add more question", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshQuestionAndMarks();
                return;
            }
            if((remainingMarks-currentMarks) < 0)
            {
                MessageBox.Show("Marks is invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshQuestionAndMarks();
                return;
            }
            remainingMarks -= currentMarks;
            TotalMarks = remainingMarks.ToString();
            MessageBox.Show("Data added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            QuestionList.Add(question);
            QuestionMarks.Add(marks);
            FillUpQuestionInfo();
            
            RefreshQuestionAndMarks();
            label_notification_marks.Text = TotalMarks + " Marks Remaining";
            if (remainingMarks == 0)
                button_question_finish.Enabled = true;
        }

        private void QuestionPaperUi_Load(object sender, EventArgs e)
        {
            
            TeacherId = ExamTeacherInfo.ExamTeacherId;
            CourseCode = ExamTeacherInfo.ExamCourseCode;
            TotalMarks = ExamTeacherInfo.ExamTotalMarks;
            label_notification_marks.Text = TotalMarks + " Marks Remaining";
            CreateFile();
            button_question_finish.Enabled = false;
            FillUpQuestionInfo();
        }

        private void CreateFile()
        {
            if (!File.Exists(GetFilePath()))
            {
                File.CreateText(GetFilePath()).Dispose();
            }
        }
        
        private string GetFilePath()
        {
            string path = Environment.CurrentDirectory + "/Exam_files/" + TeacherId + "_" + CourseCode + "_Question"  + ".txt";
            return path;
        }

        void RefreshQuestionAndMarks()
        {
            richTextBox_question.Text = "";
            textBox_question_marks.Text = "";

        }

        private void button_question_finish_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (File.Exists(GetFilePath()))
            {
                using (StreamWriter file = new StreamWriter(GetFilePath()))
                {
                    foreach (string line in QuestionList)
                    {
                        file.WriteLine(line);
                        file.WriteLine("★★★");
                        file.WriteLine(QuestionMarks[i]);
                        file.WriteLine("★★★");
                        i++;
                    }
                }

                TeacherPanelUi teacherPanel = new TeacherPanelUi();
                teacherPanel.Show();
                this.Hide();

            }
            else MessageBox.Show("Not found","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FillUpQuestionInfo()
        {
            int i = 0;
            QuestionInfoHeaderCreate();
            foreach (string qsn in QuestionList)
            {
                ListViewItem listitem = new ListViewItem(qsn);
                listitem.SubItems.Add(QuestionMarks[i]);
                listView_Question_info.Items.Add(listitem);
                i++; 
            }
        }

        private void QuestionInfoHeaderCreate()
        {
            listView_Question_info.Clear();
            listView_Question_info.Columns.Add("                             Question Info", 441, HorizontalAlignment.Center);
            listView_Question_info.Columns.Add("Marks", 161, HorizontalAlignment.Center);

        }

        private void button_question_refresh_Click(object sender, EventArgs e)
        {
            RefreshQuestionAndMarks();
        }

        private void button_question_remove_Click(object sender, EventArgs e)
        {
            string questions = "iiii";
            if (listView_Question_info.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Question_info.SelectedItems[0];
                questions = item.SubItems[0].Text;


                for (int i = 0; i < QuestionList.Count; i++)
                {
                    if (QuestionList[i].Equals(questions))
                    {
                        TotalMarks = (Int32.Parse(TotalMarks) + Int32.Parse(QuestionMarks[i])).ToString();
                        QuestionList.RemoveAt(i);
                        QuestionMarks.RemoveAt(i);
                        MessageBox.Show("Data remove successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillUpQuestionInfo();
                        RefreshQuestionAndMarks();
                        label_notification_marks.Text = TotalMarks + " Marks Remaining";
                        if(TotalMarks != "0")
                        {
                            button_question_finish.Enabled = false;
                        }
                        return;
                    }
                }
                MessageBox.Show("Error occurd", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select a question", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
