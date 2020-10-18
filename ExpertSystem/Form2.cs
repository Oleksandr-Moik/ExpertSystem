using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form2 : Form
    {
        private const string FilePath_Criteries = ".\\criteries.bin";

        public List<KeyValuePair<int, string>> Criteries;
        public int last_id;
        private int curent_critery_id = -1;

        public Form2()
        {
            InitializeComponent();
            Criteries = new List<KeyValuePair<int, string>>();
        }

        private void button_createModeCritery_Click(object sender, EventArgs e)
        {
            groupBox_CriteryTab.Text = "Створення";
            comboBox_CriteryTab.SelectedItem = 0;
            button_CreateNewCritery.Visible = true;
            button_SaveCriteryEditing.Visible = false;
            textBox_CriteryTitle.Text = "";
        }
        private void button_EditCritery_Click(object sender, EventArgs e)
        {
            groupBox_CriteryTab.Text = "Редагування";
            button_CreateNewCritery.Visible = false;
            button_SaveCriteryEditing.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCriteries();
            button_createModeCritery_Click(sender, e);
        }

        private void LoadCriteries()
        {
            ComboBox combo = comboBox_CriteryTab;
            DataGridView grid = dataGridView_CriteryTabAllCriteries;
            
            Read_Criteries();

            combo.Items.Clear();
            grid.Rows.Clear();

            combo.Items.Add("(none)");

            if (Criteries.Count != 0)
            {
                foreach (KeyValuePair<int, string> critery in Criteries)
                {
                    combo.Items.Add(critery.Value);
                    grid.Rows.Add(critery.Key, critery.Value);
                    last_id = critery.Key;
                }
            }
            combo.SelectedIndex = 0;
        }

        private void button_RemoveCritery_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int, string> pair in Criteries)
            {
                if (pair.Key == curent_critery_id)
                {
                    Criteries.Remove(pair);
                    break;
                }
            }
            RefreshCriteries();
            label_underComboBoxCritery_Info.Text = "Видалено";
        }

        private void Write_Criteries()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FilePath_Criteries, FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, Criteries);
            stream.Close();
        }

        private void Read_Criteries()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;
            try
            {
                stream = new FileStream(FilePath_Criteries, FileMode.Open, FileAccess.Read);
                if(stream.Length!=0)Criteries = (List<KeyValuePair<int, string>>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                stream = new FileStream(FilePath_Criteries, FileMode.CreateNew);
            }
        }

        private void button_SaveCriteryEditing_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> new_criteries = new List<KeyValuePair<int, string>>();
            foreach (KeyValuePair<int, string> pair in Criteries)
            {
                if (pair.Key == curent_critery_id)
                {
                    KeyValuePair<int, string> new_pair = new KeyValuePair<int, string>(curent_critery_id, textBox_CriteryTitle.Text);
                    new_criteries.Add(new_pair);
                }
                else
                {
                    new_criteries.Add(pair);
                }
            }
            Criteries = new_criteries;

            RefreshCriteries();
            label_underInputCriteryText_Info.Text = "Збережено";
        }

        private void comboBox_CriteryTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_CriteryTitle.Text = comboBox_CriteryTab.SelectedItem.ToString();
            curent_critery_id = (comboBox_CriteryTab.SelectedIndex) - 1;
            label_underComboBoxCritery_Info.Text = "";
            label_underInputCriteryText_Info.Text = "";
        }

        private void button_CreateNewCritery_Click(object sender, EventArgs e)
        {
            int new_id = ++last_id;
            Criteries.Add(new KeyValuePair<int, string>(new_id, textBox_CriteryTitle.Text));
            
            RefreshCriteries();
            label_underInputCriteryText_Info.Text = "Створено";
        }

        private void RefreshCriteries()
        {
            Write_Criteries();
            Read_Criteries();
            LoadCriteries();
        }
    }
}
