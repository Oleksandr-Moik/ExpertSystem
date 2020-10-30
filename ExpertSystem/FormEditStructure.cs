using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class FormEditStructure : Form
    {
        private FormMain formMain;
        private Question SelectedQuestion;
        private KeyValuePair<string, string> LeftChild_KeyText;
        private KeyValuePair<string, string> RightChild_KeyText;

        public FormEditStructure(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
        }
        private void FormEditStructure_Load(object sender, EventArgs e)
        {
            LoadQuestionsToComboBox(comboBox1, FormMain.GetHeadQuestionKey());
        }

        private void LoadQuestionsToComboBox(ComboBox comboBox, string key)
        {
            comboBox.Items.Clear();
            foreach (Question question in formMain.GetQuestionList())
            {
                comboBox.Items.Add(question.Text);
                if (question.Key == key)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
            if (key == "")
            {
                if(comboBox.Items.Count!=0)comboBox.SelectedIndex = 0;
            }
        }
        private void LoadAnswersToComboBox(ComboBox comboBox, string key)
        {
            comboBox.Items.Clear();
            foreach (KeyValuePair<string, string> answer in formMain.GetAnswerList())
            {
                comboBox.Items.Add(answer.Value);
                if (answer.Key == key)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        // save structure
        private void button1_Click(object sender, EventArgs e)
        {
            SelectedQuestion.LeftText = textBox1.Text;
            SelectedQuestion.LeftChild_IsAnswer = checkBox1.Checked;
            SelectedQuestion.LeftChild = LeftChild_KeyText.Key;

            SelectedQuestion.RightText = textBox2.Text;
            SelectedQuestion.RightChild_IsAnswer = checkBox2.Checked;
            SelectedQuestion.RightChild = RightChild_KeyText.Key;

            formMain.UpdateQuestion(SelectedQuestion);
            formMain.SaveQuestionListToFile();
            LoadQuestionsToComboBox(comboBox1,"");
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }
        //discard
        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            LoadQuestionsToComboBox(comboBox1,"");
            comboBox1.SelectedIndex = index;
        }
        // left is answer
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            if (checkBox1.Checked)
            {
                LoadAnswersToComboBox(comboBox2, LeftChild_KeyText.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox2, LeftChild_KeyText.Key);
            }
        }
        // right is answer
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            if (checkBox2.Checked)
            {
                LoadAnswersToComboBox(comboBox3, LeftChild_KeyText.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox3, LeftChild_KeyText.Key);
            }
        }
        // form question
        private void button5_Click(object sender, EventArgs e)
        {
            FormEditQuestions formEditQuestions = new FormEditQuestions();
            formEditQuestions.StartPosition = FormStartPosition.CenterParent;
            formEditQuestions.ShowDialog();
        }
        // form answers
        private void button3_Click(object sender, EventArgs e)
        {
            FormEditAnswers formEditAnswers = new FormEditAnswers();
            formEditAnswers.StartPosition = FormStartPosition.CenterParent;
            formEditAnswers.ShowDialog();
        }
        // close
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // select
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedQuestion = SelectQuestion(((ComboBox)sender).SelectedIndex);
            CheckOnHeadQuestion();

            comboBox2.Text = "";
            comboBox3.Text = "";

            textBox1.Text = SelectedQuestion.LeftText;
            textBox2.Text = SelectedQuestion.RightText;

            checkBox1.Checked = SelectedQuestion.LeftChild_IsAnswer;
            checkBox2.Checked = SelectedQuestion.RightChild_IsAnswer;

            if (SelectedQuestion.LeftChild_IsAnswer)
            {
                LeftChild_KeyText = formMain.GetAnswer(SelectedQuestion.LeftChild);
                LoadAnswersToComboBox(comboBox2, LeftChild_KeyText.Key);
            }
            else
            {
                Question question = formMain.GetQuetion(SelectedQuestion.NextLeftQuestion__KeyIndex);
                LeftChild_KeyText = new KeyValuePair<string, string>(question.Key, question.Text);
                LoadQuestionsToComboBox(comboBox2, LeftChild_KeyText.Key);
            }

            if (SelectedQuestion.RightChild_IsAnswer)
            {
                RightChild_KeyText = formMain.GetAnswer(SelectedQuestion.RightChild);
                LoadAnswersToComboBox(comboBox3, RightChild_KeyText.Key);
            }
            else
            {
                Question question = formMain.GetQuetion(SelectedQuestion.RightChild);
                RightChild_KeyText = new KeyValuePair<string, string>(question.Key, question.Text);
                LoadQuestionsToComboBox(comboBox3, RightChild_KeyText.Key);
            }
        }

        public KeyValuePair<string, string> SelectAnswer(int index)
        {
            return (KeyValuePair<string, string>)formMain
                    .GetAnswerList()
                    .ToArray()
                    .GetValue(index);
        }
        public Question SelectQuestion(int index)
        {
            return (Question)formMain
                .GetQuestionList()
                .ToArray()
                .GetValue(index);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                LeftChild_KeyText = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                LeftChild_KeyText = new KeyValuePair<string, string>(q.Key, q.Text);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                RightChild_KeyText = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                RightChild_KeyText = new KeyValuePair<string, string>(q.Key, q.Text);
            }
        }
        // set head
        private void button6_Click(object sender, EventArgs e)
        {
            FormMain.SetHeadQuestion(SelectedQuestion.Key);
            CheckOnHeadQuestion();
        }

        private void CheckOnHeadQuestion()
        {
            checkBox3.Checked = FormMain.GetHeadQuestionKey() == SelectedQuestion.Key;
        }
    }
}
