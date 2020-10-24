﻿namespace ExpertSystem
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Criteries = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_no_isAnswer = new System.Windows.Forms.CheckBox();
            this.checkBox_yes_isAnswer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_RemoveQuestion = new System.Windows.Forms.Button();
            this.textBox_QuestionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DiscardTreeChanges = new System.Windows.Forms.Button();
            this.button_UpdateTreeStructure = new System.Windows.Forms.Button();
            this.button_UpdateQuestion = new System.Windows.Forms.Button();
            this.comboBox_Questions = new System.Windows.Forms.ComboBox();
            this.button_CreateQuetion = new System.Windows.Forms.Button();
            this.comboBox_no_leaf = new System.Windows.Forms.ComboBox();
            this.comboBox_yes_leaf = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView_Questions = new System.Windows.Forms.DataGridView();
            this.Column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button_RemoveAnswer = new System.Windows.Forms.Button();
            this.textBox_AnswerText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UpdateAnswer = new System.Windows.Forms.Button();
            this.comboBox_Answers = new System.Windows.Forms.ComboBox();
            this.button_CreateAnswer = new System.Windows.Forms.Button();
            this.dataGridView_Answers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_Criteries.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Questions)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Criteries
            // 
            this.tabControl_Criteries.Controls.Add(this.tabPage2);
            this.tabControl_Criteries.Controls.Add(this.tabPage3);
            this.tabControl_Criteries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Criteries.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Criteries.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Criteries.Name = "tabControl_Criteries";
            this.tabControl_Criteries.SelectedIndex = 0;
            this.tabControl_Criteries.Size = new System.Drawing.Size(814, 399);
            this.tabControl_Criteries.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView_Questions);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(806, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Questions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox_no_isAnswer);
            this.panel3.Controls.Add(this.checkBox_yes_isAnswer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button_RemoveQuestion);
            this.panel3.Controls.Add(this.textBox_QuestionText);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button_DiscardTreeChanges);
            this.panel3.Controls.Add(this.button_UpdateTreeStructure);
            this.panel3.Controls.Add(this.button_UpdateQuestion);
            this.panel3.Controls.Add(this.comboBox_Questions);
            this.panel3.Controls.Add(this.button_CreateQuetion);
            this.panel3.Controls.Add(this.comboBox_no_leaf);
            this.panel3.Controls.Add(this.comboBox_yes_leaf);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(251, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 362);
            this.panel3.TabIndex = 9;
            // 
            // checkBox_no_isAnswer
            // 
            this.checkBox_no_isAnswer.AutoSize = true;
            this.checkBox_no_isAnswer.Location = new System.Drawing.Point(398, 203);
            this.checkBox_no_isAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_no_isAnswer.Name = "checkBox_no_isAnswer";
            this.checkBox_no_isAnswer.Size = new System.Drawing.Size(90, 21);
            this.checkBox_no_isAnswer.TabIndex = 20;
            this.checkBox_no_isAnswer.Text = "is Answer";
            this.checkBox_no_isAnswer.UseVisualStyleBackColor = true;
            // 
            // checkBox_yes_isAnswer
            // 
            this.checkBox_yes_isAnswer.AutoSize = true;
            this.checkBox_yes_isAnswer.Location = new System.Drawing.Point(157, 202);
            this.checkBox_yes_isAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_yes_isAnswer.Name = "checkBox_yes_isAnswer";
            this.checkBox_yes_isAnswer.Size = new System.Drawing.Size(90, 21);
            this.checkBox_yes_isAnswer.TabIndex = 20;
            this.checkBox_yes_isAnswer.Text = "is Answer";
            this.checkBox_yes_isAnswer.UseVisualStyleBackColor = true;
            this.checkBox_yes_isAnswer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select question";
            // 
            // button_RemoveQuestion
            // 
            this.button_RemoveQuestion.Location = new System.Drawing.Point(196, 135);
            this.button_RemoveQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.button_RemoveQuestion.Name = "button_RemoveQuestion";
            this.button_RemoveQuestion.Size = new System.Drawing.Size(100, 28);
            this.button_RemoveQuestion.TabIndex = 19;
            this.button_RemoveQuestion.Text = "Remove";
            this.button_RemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // textBox_QuestionText
            // 
            this.textBox_QuestionText.Location = new System.Drawing.Point(33, 105);
            this.textBox_QuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_QuestionText.Name = "textBox_QuestionText";
            this.textBox_QuestionText.Size = new System.Drawing.Size(485, 22);
            this.textBox_QuestionText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Question";
            // 
            // button_DiscardTreeChanges
            // 
            this.button_DiscardTreeChanges.Location = new System.Drawing.Point(301, 289);
            this.button_DiscardTreeChanges.Margin = new System.Windows.Forms.Padding(4);
            this.button_DiscardTreeChanges.Name = "button_DiscardTreeChanges";
            this.button_DiscardTreeChanges.Size = new System.Drawing.Size(155, 28);
            this.button_DiscardTreeChanges.TabIndex = 17;
            this.button_DiscardTreeChanges.Text = "Discard changes";
            this.button_DiscardTreeChanges.UseVisualStyleBackColor = true;
            // 
            // button_UpdateTreeStructure
            // 
            this.button_UpdateTreeStructure.Location = new System.Drawing.Point(131, 289);
            this.button_UpdateTreeStructure.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateTreeStructure.Name = "button_UpdateTreeStructure";
            this.button_UpdateTreeStructure.Size = new System.Drawing.Size(155, 28);
            this.button_UpdateTreeStructure.TabIndex = 17;
            this.button_UpdateTreeStructure.Text = "Save changes";
            this.button_UpdateTreeStructure.UseVisualStyleBackColor = true;
            // 
            // button_UpdateQuestion
            // 
            this.button_UpdateQuestion.Location = new System.Drawing.Point(33, 135);
            this.button_UpdateQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateQuestion.Name = "button_UpdateQuestion";
            this.button_UpdateQuestion.Size = new System.Drawing.Size(155, 28);
            this.button_UpdateQuestion.TabIndex = 17;
            this.button_UpdateQuestion.Text = "Save Question";
            this.button_UpdateQuestion.UseVisualStyleBackColor = true;
            // 
            // comboBox_Questions
            // 
            this.comboBox_Questions.FormattingEnabled = true;
            this.comboBox_Questions.Location = new System.Drawing.Point(28, 33);
            this.comboBox_Questions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Questions.Name = "comboBox_Questions";
            this.comboBox_Questions.Size = new System.Drawing.Size(485, 24);
            this.comboBox_Questions.TabIndex = 11;
            // 
            // button_CreateQuetion
            // 
            this.button_CreateQuetion.Location = new System.Drawing.Point(418, 135);
            this.button_CreateQuetion.Margin = new System.Windows.Forms.Padding(4);
            this.button_CreateQuetion.Name = "button_CreateQuetion";
            this.button_CreateQuetion.Size = new System.Drawing.Size(100, 28);
            this.button_CreateQuetion.TabIndex = 16;
            this.button_CreateQuetion.Text = "Create New";
            this.button_CreateQuetion.UseVisualStyleBackColor = true;
            // 
            // comboBox_no_leaf
            // 
            this.comboBox_no_leaf.FormattingEnabled = true;
            this.comboBox_no_leaf.Location = new System.Drawing.Point(329, 230);
            this.comboBox_no_leaf.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_no_leaf.Name = "comboBox_no_leaf";
            this.comboBox_no_leaf.Size = new System.Drawing.Size(160, 24);
            this.comboBox_no_leaf.TabIndex = 2;
            // 
            // comboBox_yes_leaf
            // 
            this.comboBox_yes_leaf.FormattingEnabled = true;
            this.comboBox_yes_leaf.Location = new System.Drawing.Point(83, 230);
            this.comboBox_yes_leaf.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_yes_leaf.Name = "comboBox_yes_leaf";
            this.comboBox_yes_leaf.Size = new System.Drawing.Size(160, 24);
            this.comboBox_yes_leaf.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(329, 202);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 202);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Questions
            // 
            this.dataGridView_Questions.AllowUserToAddRows = false;
            this.dataGridView_Questions.AllowUserToDeleteRows = false;
            this.dataGridView_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_title});
            this.dataGridView_Questions.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_Questions.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Questions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Questions.Name = "dataGridView_Questions";
            this.dataGridView_Questions.ReadOnly = true;
            this.dataGridView_Questions.RowHeadersVisible = false;
            this.dataGridView_Questions.RowHeadersWidth = 51;
            this.dataGridView_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Questions.Size = new System.Drawing.Size(247, 362);
            this.dataGridView_Questions.TabIndex = 0;
            // 
            // Column_title
            // 
            this.Column_title.HeaderText = "Title";
            this.Column_title.MinimumWidth = 6;
            this.Column_title.Name = "Column_title";
            this.Column_title.ReadOnly = true;
            this.Column_title.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dataGridView_Answers);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(806, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Answers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_RemoveAnswer);
            this.panel2.Controls.Add(this.textBox_AnswerText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_UpdateAnswer);
            this.panel2.Controls.Add(this.comboBox_Answers);
            this.panel2.Controls.Add(this.button_CreateAnswer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(257, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 362);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Answer";
            // 
            // button_RemoveAnswer
            // 
            this.button_RemoveAnswer.Location = new System.Drawing.Point(187, 158);
            this.button_RemoveAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.button_RemoveAnswer.Name = "button_RemoveAnswer";
            this.button_RemoveAnswer.Size = new System.Drawing.Size(100, 28);
            this.button_RemoveAnswer.TabIndex = 9;
            this.button_RemoveAnswer.Text = "Remove";
            this.button_RemoveAnswer.UseVisualStyleBackColor = true;
            this.button_RemoveAnswer.Click += new System.EventHandler(this.button_RemoveAnswer_Click);
            // 
            // textBox_AnswerText
            // 
            this.textBox_AnswerText.Location = new System.Drawing.Point(24, 126);
            this.textBox_AnswerText.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AnswerText.Name = "textBox_AnswerText";
            this.textBox_AnswerText.Size = new System.Drawing.Size(485, 22);
            this.textBox_AnswerText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // button_UpdateAnswer
            // 
            this.button_UpdateAnswer.Location = new System.Drawing.Point(24, 158);
            this.button_UpdateAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateAnswer.Name = "button_UpdateAnswer";
            this.button_UpdateAnswer.Size = new System.Drawing.Size(155, 28);
            this.button_UpdateAnswer.TabIndex = 7;
            this.button_UpdateAnswer.Text = "Save answer";
            this.button_UpdateAnswer.UseVisualStyleBackColor = true;
            this.button_UpdateAnswer.Click += new System.EventHandler(this.button_UpdateAnswer_Click);
            // 
            // comboBox_Answers
            // 
            this.comboBox_Answers.FormattingEnabled = true;
            this.comboBox_Answers.Location = new System.Drawing.Point(24, 44);
            this.comboBox_Answers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Answers.Name = "comboBox_Answers";
            this.comboBox_Answers.Size = new System.Drawing.Size(485, 24);
            this.comboBox_Answers.TabIndex = 2;
            this.comboBox_Answers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Answers_SelectedIndexChanged);
            // 
            // button_CreateAnswer
            // 
            this.button_CreateAnswer.Location = new System.Drawing.Point(409, 158);
            this.button_CreateAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.button_CreateAnswer.Name = "button_CreateAnswer";
            this.button_CreateAnswer.Size = new System.Drawing.Size(100, 28);
            this.button_CreateAnswer.TabIndex = 6;
            this.button_CreateAnswer.Text = "Create New";
            this.button_CreateAnswer.UseVisualStyleBackColor = true;
            this.button_CreateAnswer.Click += new System.EventHandler(this.button_CreateAnswer_Click);
            // 
            // dataGridView_Answers
            // 
            this.dataGridView_Answers.AllowUserToAddRows = false;
            this.dataGridView_Answers.AllowUserToDeleteRows = false;
            this.dataGridView_Answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Answers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_Answers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_Answers.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Answers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Answers.Name = "dataGridView_Answers";
            this.dataGridView_Answers.ReadOnly = true;
            this.dataGridView_Answers.RowHeadersVisible = false;
            this.dataGridView_Answers.RowHeadersWidth = 51;
            this.dataGridView_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Answers.Size = new System.Drawing.Size(253, 362);
            this.dataGridView_Answers.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TItle";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 399);
            this.Controls.Add(this.tabControl_Criteries);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.tabControl_Criteries.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Questions)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Criteries;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView_Questions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AnswerText;
        private System.Windows.Forms.ComboBox comboBox_Answers;
        private System.Windows.Forms.DataGridView dataGridView_Answers;
        private System.Windows.Forms.Button button_RemoveAnswer;
        private System.Windows.Forms.Button button_UpdateAnswer;
        private System.Windows.Forms.Button button_CreateAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_no_leaf;
        private System.Windows.Forms.ComboBox comboBox_yes_leaf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox_no_isAnswer;
        private System.Windows.Forms.CheckBox checkBox_yes_isAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RemoveQuestion;
        private System.Windows.Forms.TextBox textBox_QuestionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DiscardTreeChanges;
        private System.Windows.Forms.Button button_UpdateTreeStructure;
        private System.Windows.Forms.Button button_UpdateQuestion;
        private System.Windows.Forms.ComboBox comboBox_Questions;
        private System.Windows.Forms.Button button_CreateQuetion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_title;
    }
}