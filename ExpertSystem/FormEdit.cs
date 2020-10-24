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
        private string AnswerKey;
        private string QuestionKey;

        public FormEdit(FormMain fromMain)
        {
            InitializeComponent();

            this.formMain = fromMain;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            comboBox_Answers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Questions.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadAnswerList(comboBox_Answers, dataGridView_Answers);
            LoadQuetionList(comboBox_Questions, dataGridView_Questions);
        }

       
        private void LoadQuetionList(ComboBox comboBox, DataGridView dataGridView)
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

        private void LoadAnswerList(ComboBox comboBox, DataGridView dataGridView)
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

        private void comboBox_Answers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAnswer(((ComboBox)sender).SelectedIndex);
        }

        private void SelectAnswer(int index)
        {
            KeyValuePair<string, string> answer =
                (KeyValuePair<string, string>)formMain
                    .GetAnswerList()
                    .ToArray()
                    .GetValue(index);

            AnswerKey = answer.Key;
            textBox_AnswerText.Text = answer.Value;
            if(FormMain.DEBUG)label1.Text = AnswerKey;
        }

        private void button_CreateAnswer_Click(object sender, EventArgs e)
        {
            formMain.AddAnswer(textBox_AnswerText.Text);
            LoadAnswerList(comboBox_Answers, dataGridView_Answers);
            comboBox_Answers.SelectedIndex = comboBox_Answers.Items.Count - 1;
        }

        private void button_RemoveAnswer_Click(object sender, EventArgs e)
        {
            formMain.RemoveAnswer(AnswerKey);
            comboBox_Answers.SelectedIndex = 0;
            LoadAnswerList(comboBox_Answers, dataGridView_Answers);
            formMain.SaveAnswerListToFile();
        }

        private void button_UpdateAnswer_Click(object sender, EventArgs e)
        {
            string text = textBox_AnswerText.Text;
            formMain.UpdateAnswer(AnswerKey, text);
            LoadAnswerList(comboBox_Answers, dataGridView_Answers);
            formMain.SaveAnswerListToFile();
        }

        private void checkBox_yes_isAnsver_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
