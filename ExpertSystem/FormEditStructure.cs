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
        private string SelectedAnswerKey;
        private Question SelectedQuestion;
        private KeyValuePair<string, string> LeftChild;
        private KeyValuePair<string, string> RightChild;

        public FormEditStructure(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
        }
        private void FormEditStructure_Load(object sender, EventArgs e)
        {

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
                if (answer.Key == key)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        // save structure
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //discard
        private void button2_Click(object sender, EventArgs e)
        {

        }
        // left is answer
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        // right is answer

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        }

      
    }
}
