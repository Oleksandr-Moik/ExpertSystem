namespace ExpertSystem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_content = new System.Windows.Forms.RichTextBox();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.button_next = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_launch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_content);
            this.groupBox1.Controls.Add(this.radioButton_no);
            this.groupBox1.Controls.Add(this.radioButton_yes);
            this.groupBox1.Controls.Add(this.button_next);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // richTextBox_content
            // 
            resources.ApplyResources(this.richTextBox_content, "richTextBox_content");
            this.richTextBox_content.Name = "richTextBox_content";
            this.richTextBox_content.ReadOnly = true;
            // 
            // radioButton_no
            // 
            resources.ApplyResources(this.radioButton_no, "radioButton_no");
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.UseVisualStyleBackColor = true;
            this.radioButton_no.CheckedChanged += new System.EventHandler(this.radioButton_no_CheckedChanged);
            // 
            // radioButton_yes
            // 
            resources.ApplyResources(this.radioButton_yes, "radioButton_yes");
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            this.radioButton_yes.CheckedChanged += new System.EventHandler(this.radioButton_yes_CheckedChanged);
            // 
            // button_next
            // 
            resources.ApplyResources(this.button_next, "button_next");
            this.button_next.Name = "button_next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_edit
            // 
            resources.ApplyResources(this.button_edit, "button_edit");
            this.button_edit.Name = "button_edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_launch
            // 
            resources.ApplyResources(this.button_launch, "button_launch");
            this.button_launch.Name = "button_launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.RichTextBox richTextBox_content;
    }
}

