using ExpertSystem.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class FormMain : Form
    {
        public static bool DEBUG = true;

        public const string QuestionsFilePath = ".\\questions.bin";
        public const string AnswersFilePath = ".\\Answers.bin";
        public const string HeadKeyFilePath = ".\\head.txt";

        private ArrayList QuestionList;
        private List<KeyValuePair<string,string>> AnswerList;

        private Question CurrentQuestion;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            QuestionList = new ArrayList();
            AnswerList = new List<KeyValuePair<string, string>>();

            LoadListsFromFiles(ref QuestionList, ref AnswerList);
            CurrentQuestion = GetQuetion(GetHeadQuestionKey());
        }

        public static string GetHeadQuestionKey()
        {
            FileStream fileStream = new FileStream(HeadKeyFilePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            string key = streamReader.ReadLine();
            streamReader.Close();
            fileStream.Close();
            return key;
        }
        public static void SetHeadQuestion(string key)
        {
            FileStream fileStream = new FileStream(HeadKeyFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.WriteLine(key);
            streamWriter.Close();
            fileStream.Close();
        }
        public static string GenerateUniqueStringKey()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            DateTime dateTime = DateTime.Now;
            char ch;
            for (int i = 0; i < 12; i++)
            {
                ch = (i % 2 == 0) ?
                    Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))) :
                    Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                builder.Append(ch);
            }
            builder.Append(dateTime.Millisecond.ToString());
            return builder.ToString();
        }

        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void DisableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void LoadQuestion(string key)
        {
            string privious_text = CurrentQuestion.Text;
            
            CurrentQuestion = GetQuetion(key);
            if (CurrentQuestion.Key != "")
            {
                richTextBox_content.Text = CurrentQuestion.Text;
                button1.Text = CurrentQuestion.LeftText;
                button2.Text = CurrentQuestion.RightText;
                EnableButtons();
            }
            else
            {
                richTextBox_content.Text = "Question with keyIndex "+key+" not founded\n" +
                    "Previous question - " + privious_text;
                DisableButtons();
            }
        }

        private void LoadAnswer(string key)
        {
            KeyValuePair<string, string> answer = GetAnswer(key);
            if (answer.Key != "")
            {
                richTextBox_content.Text = "Висновок системи:\nВам підходить\n";
                richTextBox_content.Text += answer.Value;
            }
            else
            {
                richTextBox_content.Text = "Question with keyIndex " + key + " not founded\n" +
                    "Previous question - " + CurrentQuestion.Text;
            }
            DisableButtons();
        }

        public void SaveQuestionListToFile()
        {
            this.SaveListsToFiles(QuestionList, null);
        }
        public void SaveAnswerListToFile()
        {
            this.SaveListsToFiles(null, AnswerList);
        }
        private void SaveListsToFiles(ArrayList questionList, List<KeyValuePair<string, string>> AnswerList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;

            if (questionList != null)
            {
                stream = new FileStream(QuestionsFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(stream, questionList);
                stream.Close();
            }
            if (AnswerList != null)
            {
                stream = new FileStream(AnswersFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(stream, AnswerList);
                stream.Close();
            }
        }
        
        private void LoadListsFromFiles(ref ArrayList questionList, ref List<KeyValuePair<string, string>> AnswerList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;

            if (questionList != null)
            {
                try
                {
                    stream = new FileStream(QuestionsFilePath, FileMode.Open, FileAccess.Read);
                    if (stream.Length != 0)
                    {
                        questionList = (ArrayList)formatter.Deserialize(stream);
                    }
                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    stream = new FileStream(QuestionsFilePath, FileMode.Create);
                    stream.Close();
                }
            }
            if (AnswerList != null)
            {
                try
                {
                    stream = new FileStream(AnswersFilePath, FileMode.Open, FileAccess.Read);
                    if (stream.Length != 0)
                    {
                        AnswerList = (List<KeyValuePair<string, string>>)formatter.Deserialize(stream);
                    }
                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    stream = new FileStream(AnswersFilePath, FileMode.Create);
                    stream.Close();
                }
            }
        }

        public ArrayList GetQuestionList()
        {
            return QuestionList;
        }
        public List<KeyValuePair<string, string>> GetAnswerList()
        {
            return AnswerList;
        }

        public string CreateAndAddAnswer(string text)
        {
            string key = GenerateUniqueStringKey();
            AnswerList.Add(new KeyValuePair<string, string>(key, text));
            return key;
        }
        public void RemoveAnswer(string key)
        {
            foreach(KeyValuePair<string, string> ansver in AnswerList)
            {
                if(ansver.Key == key)
                {
                    AnswerList.Remove(ansver);
                    break;
                }
            }
        }
        public void UpdateAnswer(string key, string new_text)
        {
            foreach (KeyValuePair<string, string> ansver in AnswerList)
            {
                if (ansver.Key == key)
                {
                    AnswerList.Remove(ansver);
                    AnswerList.Add(new KeyValuePair<string, string>(key, new_text));
                    break;
                }
            }
        }
        public KeyValuePair<string, string> GetAnswer(string key)
        {
            foreach(KeyValuePair<string, string> answer in AnswerList)
            {
                if(answer.Key == key)
                {
                    return answer;
                }
            }
            return new KeyValuePair<string, string>("","");
        }

        public string CreateAndAddQuestion(string text)
        {
            string key = GenerateUniqueStringKey();
            QuestionList.Add(new Question(key, text));
            return key;
        }
        public void RemoveQuestion(string key)
        {
            foreach(Question question in QuestionList)
            {
                if (question.Key == key)
                {
                    QuestionList.Remove(question);
                    break;
                }
            }
        }
        public void UpdateQuestion(Question q)
        {
            foreach (Question question in QuestionList)
            {
                if (question.Key == q.Key)
                {
                    // todo updating quetion

                    //q.Key = question.Key;

                    //q.NextLeftAnswer_KeyIndex = question.NextLeftAnswer_KeyIndex;
                    //q.NextRightAnswer_KeyIndex = question.NextRightAnswer_KeyIndex;
                    //q.NextLeftQuestion__KeyIndex = question.NextLeftQuestion__KeyIndex;
                    //q.NextRightQuestion_KeyIndex = question.NextRightQuestion_KeyIndex;
                    //q.LeftChild_IsAnswer = question.LeftChild_IsAnswer;
                    //q.RightChild_IsAnswer= question.RightChild_IsAnswer;
                    
                    QuestionList.Remove(question);
                    QuestionList.Add(q);
                    
                    break;
                }
            }
        }
        public Question GetQuetion(string key)
        {
            foreach(Question question in QuestionList)
            {
                if(question.Key == key)
                {
                    return question;
                }
            }
            return new Question("","");
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadLeftChild();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadRightChild();
        }

        private void LoadLeftChild()
        {
            // todo change property on child elements
            if (CurrentQuestion.LeftChild_IsAnswer)
            {
                //LoadAnswer(CurrentQuestion.LeftChild);
                LoadAnswer(CurrentQuestion.NextLeftAnswer_KeyIndex);
            }
            else
            {
                //LoadQuestion(CurrentQuestion.LeftChild);
                LoadQuestion(CurrentQuestion.NextLeftQuestion__KeyIndex);
            }
        }

        private void LoadRightChild()
        {
            // todo change property on child elements
            if (CurrentQuestion.RightChild_IsAnswer)
            {
                //LoadAnswer(CurrentQuestion.RightChild);
                LoadAnswer(CurrentQuestion.NextRightAnswer_KeyIndex);
            }
            else
            {
                //LoadQuestion(CurrentQuestion.RightChild);
                LoadQuestion(CurrentQuestion.NextRightQuestion_KeyIndex);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(".\\Helper\\help_test.chm");
            }
            catch (Exception)
            {
                return;
            }
        }


        private void startTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadQuestion(GetHeadQuestionKey());
        }

        private void editSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormEditStructure(this);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            };
        }
    }

}

