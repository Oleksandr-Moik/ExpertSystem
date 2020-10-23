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
        public const string QuestionsFilePath = ".\\questions.bin";
        public const string AnswersFilePath = ".\\Answers.bin";

        private List<Question> QuestionList;
        private List<KeyValuePair<string,string>> AnswerList;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            QuestionList = new List<Question>();
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

        private void SaveListsToFiles(List<Question> questionList, List<KeyValuePair<string, string>> AnswerList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;

            if (questionList != null)
            {
                stream = new FileStream(QuestionsFilePath, FileMode.OpenOrCreate, FileAccess.Read);
                formatter.Serialize(stream, questionList);
                stream.Close();
            }
            if (AnswerList != null)
            {
                stream = new FileStream(AnswersFilePath, FileMode.OpenOrCreate, FileAccess.Read);
                formatter.Serialize(stream, AnswerList);
                stream.Close();
            }
        }

        private void LoadListsFromFiles(ref List<Question> questionList, ref List<KeyValuePair<string, string>> AnswerList)
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
                        questionList = (List<Question>)formatter.Deserialize(stream);
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

        public List<Question> GetQuestionList()
        {
            return QuestionList;
        }

        public List<KeyValuePair<string, string>> GetAnswerList()
        {
            return AnswerList;
        }

        public void AddAnswer(string text)
        {

        }

        public void RemoveAnswer(string key)
        {

        }

        public void UpdateAnswer(string key, string new_text)
        {

        }

        public void GetAnswer(string key)
        {

        }


        public Question AddQuestion(Question q)
        {
            return null;
        }

        public void RemoveQuestion(string key)
        {

        }

        public void UpdateQuestion(string key, Question q)
        {

        }

        public void GetQuetion(string key)
        {

        }

        public string GenerateUniqueStringKey(string salt)
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
            builder.Append(Convert.ToInt64(salt[random.Next(0, salt.Length)]));
            builder.Append(dateTime.Millisecond.ToString());
            return builder.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        
    }

}

