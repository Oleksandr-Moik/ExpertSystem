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
            this.button_edit = new System.Windows.Forms.Button();
            this.button_launch = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button_next = new System.Windows.Forms.Button();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.richTextBox_content = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.editSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.button_launch.ForeColor = System.Drawing.Color.Black;
            this.button_launch.Name = "button_launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSystemToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startTestingToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // button_next
            // 
            resources.ApplyResources(this.button_next, "button_next");
            this.button_next.Name = "button_next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // radioButton_yes
            // 
            resources.ApplyResources(this.radioButton_yes, "radioButton_yes");
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            this.radioButton_yes.CheckedChanged += new System.EventHandler(this.radioButton_yes_CheckedChanged);
            // 
            // radioButton_no
            // 
            resources.ApplyResources(this.radioButton_no, "radioButton_no");
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.UseVisualStyleBackColor = true;
            this.radioButton_no.CheckedChanged += new System.EventHandler(this.radioButton_no_CheckedChanged);
            // 
            // richTextBox_content
            // 
            resources.ApplyResources(this.richTextBox_content, "richTextBox_content");
            this.richTextBox_content.Name = "richTextBox_content";
            this.richTextBox_content.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // editSystemToolStripMenuItem
            // 
            this.editSystemToolStripMenuItem.Name = "editSystemToolStripMenuItem";
            resources.ApplyResources(this.editSystemToolStripMenuItem, "editSystemToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // startTestingToolStripMenuItem
            // 
            this.startTestingToolStripMenuItem.Name = "startTestingToolStripMenuItem";
            resources.ApplyResources(this.startTestingToolStripMenuItem, "startTestingToolStripMenuItem");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.richTextBox_content);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_yes);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTestingToolStripMenuItem;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RichTextBox richTextBox_content;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

