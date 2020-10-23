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
        public const string AnsversFilePath = ".\\ansvers.bin";

        private List<Question> QuestionList;
        private List<KeyValuePair<string,string>> AnsverList;

        public FormMain()
        {
            InitializeComponent();

            QuestionList = new List<Question>();
            AnsverList = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GenerateUniqueStringKey("Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text Lonng text "));
            }
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
        List<string> test_keys = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void SaveListToFile(List<Question> questionList, List<KeyValuePair<string, string>> ansverList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;

            if (questionList != null)
            {
                stream = new FileStream(QuestionsFilePath, FileMode.OpenOrCreate, FileAccess.Read);
                formatter.Serialize(stream, questionList);
                stream.Close();
            }
            if (ansverList != null)
            {
                stream = new FileStream(AnsversFilePath, FileMode.OpenOrCreate, FileAccess.Read);
                formatter.Serialize(stream, ansverList);
                stream.Close();
            }
        }

        private void LoadQeustions(ref List<Question> questionList, ref List<KeyValuePair<string, string>> ansverList)
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
            if (ansverList != null)
            {
                try
                {
                    stream = new FileStream(AnsversFilePath, FileMode.Open, FileAccess.Read);
                    if (stream.Length != 0)
                    {
                        ansverList = (List<KeyValuePair<string, string>>)formatter.Deserialize(stream);
                    }
                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    stream = new FileStream(AnsversFilePath, FileMode.Create);
                    stream.Close();
                }
            }
        }

        public List<KeyValuePair<string, string>> LoadAnsver()
        {
            IFormatter formatter = new BinaryFormatter();
            List<KeyValuePair<string, string>> list = null;
            Stream stream = null;
            try
            {
                stream = new FileStream(AnsversFilePath, FileMode.Open, FileAccess.Read);
                if (stream.Length != 0) list = (List<KeyValuePair<string, string>>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                stream = new FileStream(AnsversFilePath, FileMode.Create);
            }

            return list;
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

