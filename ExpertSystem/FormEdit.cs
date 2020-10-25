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
        private KeyValuePair<string, string> Leaf_YesLeft;
        private KeyValuePair<string, string> Leaf_NoRight;

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
                if (question.KeyIndex == key)
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
            comboBox_yes_leaf.Text = "";
            comboBox_no_leaf.Text = "";


            if (SelectedQuestion.NextLeftLeaf_IsAnswer) // yes
            {
                checkBox_yes_isAnswer.Checked = true;
                Leaf_YesLeft = formMain.GetAnswer(SelectedQuestion.NextLeftAnswer_KeyIndex);
                LoadAnswersToComboBox(comboBox_yes_leaf, Leaf_YesLeft.Key);
            }
            else
            {
                checkBox_yes_isAnswer.Checked = false;
                Question question = formMain.GetQuetion(SelectedQuestion.NextLeftQuestion__KeyIndex);
                Leaf_YesLeft = new KeyValuePair<string, string>(question.KeyIndex,question.Text);
                LoadQuestionsToComboBox(comboBox_yes_leaf, Leaf_YesLeft.Key);
            }

            if (SelectedQuestion.NextRightLeaf_IsAnswer) //no
            {
                checkBox_no_isAnswer.Checked = true;
                Leaf_NoRight = formMain.GetAnswer(SelectedQuestion.NextRightAnswer_KeyIndex);
                LoadAnswersToComboBox(comboBox_no_leaf, Leaf_NoRight.Key);
            }
            else
            {
                checkBox_no_isAnswer.Checked = false;
                Question question = formMain.GetQuetion(SelectedQuestion.NextRightQuestion_KeyIndex);
                Leaf_NoRight = new KeyValuePair<string, string>(question.KeyIndex, question.Text);
                LoadQuestionsToComboBox(comboBox_no_leaf, Leaf_NoRight.Key);
            }
        }

        private void button_CreateQuetion_Click(object sender, EventArgs e)
        {
            Question question = new Question(FormMain.GenerateUniqueStringKey(), textBox_QuestionText.Text);
            SelectedQuestion = question;

            SelectedQuestion.NextLeftLeaf_IsAnswer = checkBox_yes_isAnswer.Checked;
            SelectedQuestion.NextRightLeaf_IsAnswer = checkBox_no_isAnswer.Checked;

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextLeftAnswer_KeyIndex = Leaf_YesLeft.Key;
            }
            else
            {
                SelectedQuestion.NextLeftQuestion__KeyIndex = Leaf_YesLeft.Key;
            }

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextRightAnswer_KeyIndex = Leaf_NoRight.Key;
            }
            else
            {
                SelectedQuestion.NextRightQuestion_KeyIndex = Leaf_NoRight.Key;
            }
            
            formMain.AddQuestion(SelectedQuestion);
            formMain.SaveQuestionListToFile();
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = comboBox_Questions.Items.Count - 1;
        }

        private void button_RemoveQuestion_Click(object sender, EventArgs e)
        {
            formMain.RemoveQuestion(SelectedQuestion.KeyIndex);
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
        }

        private void button_UpdateQuestion_Click(object sender, EventArgs e)
        {
            SelectedQuestion.Text = textBox_QuestionText.Text;

            formMain.UpdateQuestion(SelectedQuestion.KeyIndex, SelectedQuestion);            
            formMain.SaveQuestionListToFile();
            LoadQuestionListToComboAndGrid(comboBox_Questions, dataGridView_Questions);
            comboBox_Questions.SelectedIndex = comboBox_Questions.Items.Count - 1;
        }

        private void button_UpdateTreeStructure_Click(object sender, EventArgs e)
        {
            SelectedQuestion.NextLeftLeaf_IsAnswer = checkBox_yes_isAnswer.Checked;
            SelectedQuestion.NextRightLeaf_IsAnswer = checkBox_no_isAnswer.Checked;

            if (checkBox_yes_isAnswer.Checked)
            {
                SelectedQuestion.NextLeftAnswer_KeyIndex = Leaf_YesLeft.Key;
            }
            else
            {
                SelectedQuestion.NextLeftQuestion__KeyIndex = Leaf_YesLeft.Key;
            }

            if (checkBox_no_isAnswer.Checked)
            {
                SelectedQuestion.NextRightAnswer_KeyIndex = Leaf_NoRight.Key;
            }
            else
            {
                SelectedQuestion.NextRightQuestion_KeyIndex = Leaf_NoRight.Key;
            }

            formMain.UpdateQuestion(SelectedQuestion.KeyIndex, SelectedQuestion);
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
            comboBox_yes_leaf.Text = "";
            if (checkBox_yes_isAnswer.Checked)
            {
                LoadAnswersToComboBox(comboBox_yes_leaf, Leaf_YesLeft.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox_yes_leaf, Leaf_YesLeft.Key);
            }
        }
        private void checkBox_no_isAnswer_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_no_leaf.Text = "";
            if (checkBox_no_isAnswer.Checked)
            {
                LoadAnswersToComboBox(comboBox_no_leaf, Leaf_NoRight.Key);
            }
            else
            {
                LoadQuestionsToComboBox(comboBox_no_leaf, Leaf_NoRight.Key);
            }
        }

        private void comboBox_yes_leaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_yes_isAnswer.Checked)
            {
                Leaf_YesLeft = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                Leaf_YesLeft = new KeyValuePair<string, string>(q.KeyIndex, q.Text);
            }
        }
        private void comboBox_no_leaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_no_isAnswer.Checked)
            {
                Leaf_NoRight = SelectAnswer(((ComboBox)sender).SelectedIndex);
            }
            else
            {
                Question q = SelectQuestion(((ComboBox)sender).SelectedIndex);
                Leaf_NoRight = new KeyValuePair<string, string>(q.KeyIndex, q.Text);
            }
        }
    }
}
