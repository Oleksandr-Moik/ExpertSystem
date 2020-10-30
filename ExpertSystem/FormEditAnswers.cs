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
    public partial class FormEditAnswers : Form
    {
        private KeyValuePair<string, string> SelectedAnswer;
        private FormEditStructure formEditStructure;

        public FormEditAnswers(FormEditStructure form)
        {
            InitializeComponent();

            formEditStructure = form;
        }

        private void FormEditAnswers_Load(object sender, EventArgs e)
        {
            formEditStructure.LoadAnswersToComboBox(comboBox1, "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAnswer = formEditStructure.SelectAnswer(((ComboBox)sender).SelectedIndex);
            textBox1.Text = SelectedAnswer.Value;
        }
        // finish
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // remove
        private void button1_Click(object sender, EventArgs e)
        {
            formEditStructure.formMain.RemoveAnswer(SelectedAnswer.Key);
            formEditStructure.formMain.SaveAnswerListToFile();
            formEditStructure.LoadAnswersToComboBox(comboBox1, FormMain.GetHeadQuestionKey());
        }
        // edit
        private void button2_Click(object sender, EventArgs e)
        {
            formEditStructure.formMain.UpdateAnswer(SelectedAnswer.Key, textBox1.Text);
            formEditStructure.formMain.SaveAnswerListToFile();
            formEditStructure.LoadAnswersToComboBox(comboBox1, SelectedAnswer.Key);
        }
        // create
        private void button3_Click(object sender, EventArgs e)
        {
            string key = formEditStructure.formMain.CreateAndAddAnswer(textBox1.Text);
            formEditStructure.formMain.SaveAnswerListToFile();
            formEditStructure.LoadAnswersToComboBox(comboBox1, key);
        }
    }
}
