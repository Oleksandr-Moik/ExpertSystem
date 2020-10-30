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
    public partial class FormEditQuestions : Form
    {
        private Question SelectedQuestion;
        private FormEditStructure formEditStructure;

        public FormEditQuestions(FormEditStructure form)
        {
            InitializeComponent();

            formEditStructure = form;
        }

        private void FormEditQuestions_Load(object sender, EventArgs e)
        {
            formEditStructure.LoadQuestionsToComboBox(comboBox1, FormMain.GetHeadQuestionKey());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedQuestion = formEditStructure.SelectQuestion(((ComboBox)sender).SelectedIndex);
            textBox1.Text = SelectedQuestion.Text;
            FormEditStructure.CheckOnHeadQuestion(checkBox1, SelectedQuestion);
        }
        // remove
        private void button1_Click(object sender, EventArgs e)
        {
            formEditStructure.formMain.RemoveQuestion(SelectedQuestion.Key);
            formEditStructure.formMain.SaveQuestionListToFile();
            formEditStructure.LoadQuestionsToComboBox(comboBox1, FormMain.GetHeadQuestionKey());
        }
        // edit
        private void button2_Click(object sender, EventArgs e)
        {
            SelectedQuestion.Text = textBox1.Text;

            formEditStructure.formMain.UpdateQuestion(SelectedQuestion);
            formEditStructure.formMain.SaveQuestionListToFile();
            formEditStructure.LoadQuestionsToComboBox(comboBox1, SelectedQuestion.Key);
        }
        // create
        private void button3_Click(object sender, EventArgs e)
        {
            string key = formEditStructure.formMain.CreateAndAddQuestion(textBox1.Text);
            formEditStructure.formMain.SaveQuestionListToFile();
            formEditStructure.LoadQuestionsToComboBox(comboBox1, key);
        }
        //finish
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMain.SetHeadQuestion(SelectedQuestion.Key);
            FormEditStructure.CheckOnHeadQuestion(checkBox1, SelectedQuestion);
        }
    }
}
