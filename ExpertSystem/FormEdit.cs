using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class FormEdit : Form
    {
        private FormMain formMain;
        private string SelectedAnswerKey;
        
        //private string SelectedQuestionKey;
        private Question SelectedQuestion;
        private KeyValuePair<string, string> Child_Yes;
        private KeyValuePair<string, string> Child_No;

        public FormEdit(FormMain fromMain)
        {
            InitializeComponent();

            this.formMain = fromMain;

            comboBox_Answers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Questions.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            LoadAnswerListToComboAndGrid(comboBox_Answers, dataGridView_Answers);
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
        }

       
        private void LoadQuestionListToComboAndGrid(ComboBox comboBox, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            comboBox.Items.Clear();
            
            foreach (Question question in formMain.GetQuestionList())
            {
                dataGridView.Rows.Add(question.Text);
                comboBox.Items.Add(question.Text);
            }
            if (comboBox.Items.Count != 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
       
        private void LoadAnswerListToComboAndGrid(ComboBox comboBox, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            comboBox.Items.Clear();

            foreach (KeyValuePair<string, string> answer in formMain.GetAnswerList())
            {
                dataGridView.Rows.Add(answer.Value);
                comboBox.Items.Add(answer.Value);
            }
            if (comboBox.Items.Count != 0)
            {
                comboBox.SelectedIndex = 0;
            }
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
        }

        private void LoadAnswersToComboBox(ComboBox comboBox, string key)
        {
            comboBox.Items.Clear();
            foreach (KeyValuePair<string, string> answer in formMain.GetAnswerList())
            {
                comboBox.Items.Add(answer.Value);
                if(answer.Key == key)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        private void comboBox_Answers_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> answer = SelectAnswer(((ComboBox)sender).SelectedIndex);
            
            SelectedAnswerKey = answer.Key;
            textBox_AnswerText.Text = answer.Value;
        }

        private KeyValuePair<string, string> SelectAnswer(int index)
        {
            return (KeyValuePair<string, string>)formMain
                    .GetAnswerList()
                    .ToArray()
                    .GetValue(index);
        }

        private Question SelectQuestion(int index)
        {
            return (Question)formMain
                .GetQuestionList()
                .ToArray()
                .GetValue(index);
        }

        private void button_CreateAnswer_Click(object sender, EventArgs e)
        {
            formMain.AddAnswer(textBox_AnswerText.Text);
            LoadAnswerListToComboAndGrid(comboBox_Answers, dataGridView_Answers);
            comboBox_Answers.SelectedIndex = comboBox_Answers.Items.Count - 1;
            formMain.SaveAnswerListToFile();
        }

        private void button_RemoveAnswer_Click(object sender, EventArgs e)
        {
            formMain.RemoveAnswer(SelectedAnswerKey);
            comboBox_Answers.SelectedIndex = 0;
            LoadAnswerListToComboAndGrid(comboBox_Answers, dataGridView_Answers);
            formMain.SaveAnswerListToFile();
        }

        private void button_UpdateAnswer_Click(object sender, EventArgs e)
        {
            string text = textBox_AnswerText.Text;
            formMain.UpdateAnswer(SelectedAnswerKey, text);
            LoadAnswerListToComboAndGrid(comboBox_Answers, dataGridView_Answers);
            formMain.SaveAnswerListToFile();
        }


        private void comboBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedQuestion = SelectQuestion(((ComboBox)sender).SelectedIndex);

            textBox_QuestionText.Text = SelectedQuestion.Text;
            comboBox_yes_child.Text = "";
            comboBox_no_child.Text = "";
            //if (SelectedQuestion.Text == "Question test") SelectedQuestion.KeyIndex = "head";

            if (SelectedQuestion.NextYesChild_IsAnswer) // yes
            {
                checkBox_yes_isAnswer.Checked = true;
                Child_Yes = formMain.GetAnswer(SelectedQuestion.NextYesAnswer_KeyIndex);
                LoadAnswersToComboBox(comboBox_yes_child, Child_Yes.Key);
            }
            else
            {
                checkBox_yes_isAnswer.Checked = false;
                Question question = formMain.GetQuetion(SelectedQuestion.NextYesQuestion__KeyIndex);
                Child_Yes = new KeyValuePair<string, string>(question.Key,question.Text);
                LoadQuestionsToComboBox(comboBox_yes_child, Child_Yes.Key);
            }

            if (SelectedQuestion.NextNoChild_IsAnswer) //no
            {
                checkBox_no_isAnswer.Checked = true;
                Child_No = formMain.GetAnswer(SelectedQuestion.NextNoAnswer_KeyIndex);
                LoadAnswersToComboBox(comboBox_no_child, Child_No.Key);
            }
            else
            {
                checkBox_no_isAnswer.Checked = false;
                Question question = formMain.GetQuetion(SelectedQuestion.NextNoQuestion_KeyIndex);
                Child_No = new KeyValuePair<string, string>(question.Key, question.Text);
                LoadQuestionsToComboBox(comboBox_no_child, Child_No.Key);
            }
        }

        private void button_CreateQuetion_Click(object sender, EventArgs e)
        {
            Question question = new Question(FormMain.GenerateUniqueStringKey(), textBox_QuestionText.Text);
            SelectedQuestion = question;

            SelectedQuestion.NextYesChild_IsAnswer = checkBox_yes_isAnswer.Checked;
            SelectedQuestion.NextNoChild_IsAnswer = checkBox_no_isAnswer.Checked;

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextYesAnswer_KeyIndex = Child_Yes.Key;
            }
            else
            {
                SelectedQuestion.NextYesQuestion__KeyIndex = Child_Yes.Key;
            }

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextNoAnswer_KeyIndex = Child_No.Key;
            }
            else
            {
                SelectedQuestion.NextNoQuestion_KeyIndex = Child_No.Key;
            }
            
            formMain.AddQuestion(SelectedQuestion);
            formMain.SaveQuestionListToFile();
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = comboBox_Questions.Items.Count - 1;
        }

        private void button_RemoveQuestion_Click(object sender, EventArgs e)
        {
            formMain.RemoveQuestion(SelectedQuestion.Key);
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
        }

        private void button_UpdateQuestion_Click(object sender, EventArgs e)
        {
            SelectedQuestion.Text = textBox_QuestionText.Text;

            formMain.UpdateQuestion(SelectedQuestion.Key, SelectedQuestion);            
            formMain.SaveQuestionListToFile();
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = comboBox_Questions.Items.Count - 1;
        }

        private void button_UpdateTreeStructure_Click(object sender, EventArgs e)
        {
            SelectedQuestion.NextYesChild_IsAnswer = checkBox_yes_isAnswer.Checked;
            SelectedQuestion.NextNoChild_IsAnswer = checkBox_no_isAnswer.Checked;

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextYesAnswer_KeyIndex = Child_Yes.Key;
            }
            else
            {
                SelectedQuestion.NextYesQuestion__KeyIndex = Child_Yes.Key;
            }

            if (checkBox_no_isAnswer.Checked)
            {
                SelectedQuestion.NextNoAnswer_KeyIndex = Child_No.Key;
            }
            else
            {
                SelectedQuestion.NextNoQuestion_KeyIndex = Child_No.Key;
            }

            formMain.UpdateQuestion(SelectedQuestion.Key, SelectedQuestion);
            formMain.SaveQuestionListToFile();
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = comboBox_Questions.Items.Count - 1;
        }

        private void button_DiscardTreeChanges_Click(object sender, EventArgs e)
        {
            int index = comboBox_Questions.SelectedIndex;
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = index;
        }

        private void checkBox_yes_isAnswer_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_yes_child.Text = "";
            if (checkBox_yes_isAnswer.Checked)
            {
                LoadAnswersToComboBox(comboBox_yes_child, Child_Yes.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox_yes_child, Child_Yes.Key);
            }
        }
        private void checkBox_no_isAnswer_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_no_child.Text = "";
            if (checkBox_no_isAnswer.Checked)
            {
                LoadAnswersToComboBox(comboBox_no_child, Child_No.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox_no_child, Child_No.Key);
            }
        }

        private void comboBox_yes_child_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_yes_isAnswer.Checked)
            {
                Child_Yes = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                Child_Yes = new KeyValuePair<string, string>(q.Key, q.Text);
            }
        }
        private void comboBox_no_child_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_no_isAnswer.Checked)
            {
                Child_No = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                Child_No = new KeyValuePair<string, string>(q.Key, q.Text);
            }
        }
    }
}
