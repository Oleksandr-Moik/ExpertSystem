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

        private ArrayList QuestionList;
        private List<KeyValuePair<string,string>> AnswerList;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            QuestionList = new ArrayList();
            AnswerList = new List<KeyValuePair<string, string>>();

            LoadListsFromFiles(ref QuestionList, ref AnswerList);
        }

        /// <summary>
        /// edit button
        /// <para>open edit form as dialog</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if ((new FormEdit(this)).ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            };
        }

        /// <summary>
        /// launch test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
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

        public void AddAnswer(string text)
        {
            string key = GenerateUniqueStringKey();
            AnswerList.Add(new KeyValuePair<string, string>(key, text));
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
            return new KeyValuePair<string, string>();
        }


        public void AddQuestion(Question q)
        {
            QuestionList.Add(q);
        }

        public void RemoveQuestion(string key)
        {
            foreach(Question question in QuestionList)
            {
                if (question.KeyIndex == key)
                {
                    QuestionList.Remove(question);
                    break;
                }
            }
        }

        public void UpdateQuestion(string key, Question q)
        {
            foreach (Question question in QuestionList)
            {
                if (question.KeyIndex == key)
                {
                    q.KeyIndex = question.KeyIndex;
                    q.NextLeftAnswer_KeyIndex = question.NextLeftAnswer_KeyIndex;
                    q.NextRightAnswer_KeyIndex = question.NextRightAnswer_KeyIndex;
                    q.NextLeftQuestion__KeyIndex = question.NextLeftQuestion__KeyIndex;
                    q.NextRightQuestion_KeyIndex = question.NextRightQuestion_KeyIndex;
                    q.NextLeftLeaf_IsAnswer = question.NextLeftLeaf_IsAnswer;
                    q.NextRightLeaf_IsAnswer= question.NextRightLeaf_IsAnswer;
                    
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
                if(question.KeyIndex == key)
                {
                    return question;
                }
            }
            return new Question("","");
        }

        public static string GenerateUniqueStringKey()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            DateTime dateTime = DateTime.Now;
            char ch;
            for (int i = 0; i < 12; i++)
            {
                ch = (i%2==0)? 
                    Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))):
                    Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                builder.Append(ch);
            }
            builder.Append(dateTime.Millisecond.ToString());
            return builder.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }
        
    }

}

