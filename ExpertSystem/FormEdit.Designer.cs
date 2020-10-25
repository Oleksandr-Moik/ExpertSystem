namespace ExpertSystem
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
            this.comboBox_no_child = new System.Windows.Forms.ComboBox();
            this.comboBox_yes_child = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView_Questions = new System.Windows.Forms.DataGridView();
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
            this.Column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl_Criteries.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl_Criteries.Name = "tabControl_Criteries";
            this.tabControl_Criteries.SelectedIndex = 0;
            this.tabControl_Criteries.Size = new System.Drawing.Size(1002, 549);
            this.tabControl_Criteries.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView_Questions);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(994, 514);
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
            this.panel3.Controls.Add(this.comboBox_no_child);
            this.panel3.Controls.Add(this.comboBox_yes_child);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 502);
            this.panel3.TabIndex = 9;
            // 
            // checkBox_no_isAnswer
            // 
            this.checkBox_no_isAnswer.AutoSize = true;
            this.checkBox_no_isAnswer.Location = new System.Drawing.Point(498, 279);
            this.checkBox_no_isAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_no_isAnswer.Name = "checkBox_no_isAnswer";
            this.checkBox_no_isAnswer.Size = new System.Drawing.Size(114, 28);
            this.checkBox_no_isAnswer.TabIndex = 20;
            this.checkBox_no_isAnswer.Text = "is Answer";
            this.checkBox_no_isAnswer.UseVisualStyleBackColor = true;
            this.checkBox_no_isAnswer.CheckedChanged += new System.EventHandler(this.checkBox_no_isAnswer_CheckedChanged);
            // 
            // checkBox_yes_isAnswer
            // 
            this.checkBox_yes_isAnswer.AutoSize = true;
            this.checkBox_yes_isAnswer.Location = new System.Drawing.Point(196, 278);
            this.checkBox_yes_isAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox_yes_isAnswer.Name = "checkBox_yes_isAnswer";
            this.checkBox_yes_isAnswer.Size = new System.Drawing.Size(114, 28);
            this.checkBox_yes_isAnswer.TabIndex = 20;
            this.checkBox_yes_isAnswer.Text = "is Answer";
            this.checkBox_yes_isAnswer.UseVisualStyleBackColor = true;
            this.checkBox_yes_isAnswer.CheckedChanged += new System.EventHandler(this.checkBox_yes_isAnswer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select question";
            // 
            // button_RemoveQuestion
            // 
            this.button_RemoveQuestion.Location = new System.Drawing.Point(245, 186);
            this.button_RemoveQuestion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_RemoveQuestion.Name = "button_RemoveQuestion";
            this.button_RemoveQuestion.Size = new System.Drawing.Size(125, 38);
            this.button_RemoveQuestion.TabIndex = 19;
            this.button_RemoveQuestion.Text = "Remove";
            this.button_RemoveQuestion.UseVisualStyleBackColor = true;
            this.button_RemoveQuestion.Click += new System.EventHandler(this.button_RemoveQuestion_Click);
            // 
            // textBox_QuestionText
            // 
            this.textBox_QuestionText.Location = new System.Drawing.Point(41, 144);
            this.textBox_QuestionText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_QuestionText.Name = "textBox_QuestionText";
            this.textBox_QuestionText.Size = new System.Drawing.Size(605, 28);
            this.textBox_QuestionText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Question";
            // 
            // button_DiscardTreeChanges
            // 
            this.button_DiscardTreeChanges.Location = new System.Drawing.Point(376, 397);
            this.button_DiscardTreeChanges.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_DiscardTreeChanges.Name = "button_DiscardTreeChanges";
            this.button_DiscardTreeChanges.Size = new System.Drawing.Size(194, 38);
            this.button_DiscardTreeChanges.TabIndex = 17;
            this.button_DiscardTreeChanges.Text = "Discard changes";
            this.button_DiscardTreeChanges.UseVisualStyleBackColor = true;
            this.button_DiscardTreeChanges.Click += new System.EventHandler(this.button_DiscardTreeChanges_Click);
            // 
            // button_UpdateTreeStructure
            // 
            this.button_UpdateTreeStructure.Location = new System.Drawing.Point(164, 397);
            this.button_UpdateTreeStructure.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_UpdateTreeStructure.Name = "button_UpdateTreeStructure";
            this.button_UpdateTreeStructure.Size = new System.Drawing.Size(194, 38);
            this.button_UpdateTreeStructure.TabIndex = 17;
            this.button_UpdateTreeStructure.Text = "Save changes";
            this.button_UpdateTreeStructure.UseVisualStyleBackColor = true;
            this.button_UpdateTreeStructure.Click += new System.EventHandler(this.button_UpdateTreeStructure_Click);
            // 
            // button_UpdateQuestion
            // 
            this.button_UpdateQuestion.Location = new System.Drawing.Point(41, 186);
            this.button_UpdateQuestion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_UpdateQuestion.Name = "button_UpdateQuestion";
            this.button_UpdateQuestion.Size = new System.Drawing.Size(194, 38);
            this.button_UpdateQuestion.TabIndex = 17;
            this.button_UpdateQuestion.Text = "Save Question";
            this.button_UpdateQuestion.UseVisualStyleBackColor = true;
            this.button_UpdateQuestion.Click += new System.EventHandler(this.button_UpdateQuestion_Click);
            // 
            // comboBox_Questions
            // 
            this.comboBox_Questions.FormattingEnabled = true;
            this.comboBox_Questions.Location = new System.Drawing.Point(35, 45);
            this.comboBox_Questions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_Questions.Name = "comboBox_Questions";
            this.comboBox_Questions.Size = new System.Drawing.Size(605, 30);
            this.comboBox_Questions.TabIndex = 11;
            this.comboBox_Questions.SelectedIndexChanged += new System.EventHandler(this.comboBox_Questions_SelectedIndexChanged);
            // 
            // button_CreateQuetion
            // 
            this.button_CreateQuetion.Location = new System.Drawing.Point(522, 186);
            this.button_CreateQuetion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_CreateQuetion.Name = "button_CreateQuetion";
            this.button_CreateQuetion.Size = new System.Drawing.Size(125, 38);
            this.button_CreateQuetion.TabIndex = 16;
            this.button_CreateQuetion.Text = "Create New";
            this.button_CreateQuetion.UseVisualStyleBackColor = true;
            this.button_CreateQuetion.Click += new System.EventHandler(this.button_CreateQuetion_Click);
            // 
            // comboBox_no_child
            // 
            this.comboBox_no_child.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_no_child.FormattingEnabled = true;
            this.comboBox_no_child.Location = new System.Drawing.Point(411, 316);
            this.comboBox_no_child.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_no_child.Name = "comboBox_no_child";
            this.comboBox_no_child.Size = new System.Drawing.Size(199, 30);
            this.comboBox_no_child.TabIndex = 2;
            this.comboBox_no_child.SelectedIndexChanged += new System.EventHandler(this.comboBox_no_child_SelectedIndexChanged);
            // 
            // comboBox_yes_child
            // 
            this.comboBox_yes_child.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yes_child.FormattingEnabled = true;
            this.comboBox_yes_child.Location = new System.Drawing.Point(104, 316);
            this.comboBox_yes_child.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_yes_child.Name = "comboBox_yes_child";
            this.comboBox_yes_child.Size = new System.Drawing.Size(199, 30);
            this.comboBox_yes_child.TabIndex = 2;
            this.comboBox_yes_child.SelectedIndexChanged += new System.EventHandler(this.comboBox_yes_child_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(411, 278);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(104, 278);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 28);
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
            this.Column_title,
            this.Column2});
            this.dataGridView_Questions.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_Questions.Location = new System.Drawing.Point(680, 6);
            this.dataGridView_Questions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView_Questions.Name = "dataGridView_Questions";
            this.dataGridView_Questions.ReadOnly = true;
            this.dataGridView_Questions.RowHeadersVisible = false;
            this.dataGridView_Questions.RowHeadersWidth = 51;
            this.dataGridView_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Questions.Size = new System.Drawing.Size(309, 502);
            this.dataGridView_Questions.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dataGridView_Answers);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Size = new System.Drawing.Size(994, 520);
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
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 508);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Answer";
            // 
            // button_RemoveAnswer
            // 
            this.button_RemoveAnswer.Location = new System.Drawing.Point(234, 217);
            this.button_RemoveAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_RemoveAnswer.Name = "button_RemoveAnswer";
            this.button_RemoveAnswer.Size = new System.Drawing.Size(125, 38);
            this.button_RemoveAnswer.TabIndex = 9;
            this.button_RemoveAnswer.Text = "Remove";
            this.button_RemoveAnswer.UseVisualStyleBackColor = true;
            this.button_RemoveAnswer.Click += new System.EventHandler(this.button_RemoveAnswer_Click);
            // 
            // textBox_AnswerText
            // 
            this.textBox_AnswerText.Location = new System.Drawing.Point(30, 173);
            this.textBox_AnswerText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_AnswerText.Name = "textBox_AnswerText";
            this.textBox_AnswerText.Size = new System.Drawing.Size(605, 28);
            this.textBox_AnswerText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // button_UpdateAnswer
            // 
            this.button_UpdateAnswer.Location = new System.Drawing.Point(30, 217);
            this.button_UpdateAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_UpdateAnswer.Name = "button_UpdateAnswer";
            this.button_UpdateAnswer.Size = new System.Drawing.Size(194, 38);
            this.button_UpdateAnswer.TabIndex = 7;
            this.button_UpdateAnswer.Text = "Save answer";
            this.button_UpdateAnswer.UseVisualStyleBackColor = true;
            this.button_UpdateAnswer.Click += new System.EventHandler(this.button_UpdateAnswer_Click);
            // 
            // comboBox_Answers
            // 
            this.comboBox_Answers.FormattingEnabled = true;
            this.comboBox_Answers.Location = new System.Drawing.Point(30, 60);
            this.comboBox_Answers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_Answers.Name = "comboBox_Answers";
            this.comboBox_Answers.Size = new System.Drawing.Size(605, 30);
            this.comboBox_Answers.TabIndex = 2;
            this.comboBox_Answers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Answers_SelectedIndexChanged);
            // 
            // button_CreateAnswer
            // 
            this.button_CreateAnswer.Location = new System.Drawing.Point(511, 217);
            this.button_CreateAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_CreateAnswer.Name = "button_CreateAnswer";
            this.button_CreateAnswer.Size = new System.Drawing.Size(125, 38);
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
            this.dataGridView_Answers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_Answers.Location = new System.Drawing.Point(673, 6);
            this.dataGridView_Answers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView_Answers.Name = "dataGridView_Answers";
            this.dataGridView_Answers.ReadOnly = true;
            this.dataGridView_Answers.RowHeadersVisible = false;
            this.dataGridView_Answers.RowHeadersWidth = 51;
            this.dataGridView_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Answers.Size = new System.Drawing.Size(316, 508);
            this.dataGridView_Answers.TabIndex = 0;
            this.dataGridView_Answers.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TItle";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column_title
            // 
            this.Column_title.HeaderText = "Title";
            this.Column_title.MinimumWidth = 6;
            this.Column_title.Name = "Column_title";
            this.Column_title.ReadOnly = true;
            this.Column_title.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 549);
            this.Controls.Add(this.tabControl_Criteries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
        private System.Windows.Forms.ComboBox comboBox_no_child;
        private System.Windows.Forms.ComboBox comboBox_yes_child;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}