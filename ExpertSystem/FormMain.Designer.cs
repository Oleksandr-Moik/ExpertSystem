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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
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
            this.button_launch.ForeColor = System.Drawing.Color.Black;
            this.button_launch.Name = "button_launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_launch);
            this.panel1.Controls.Add(this.button_edit);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
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
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.RichTextBox richTextBox_content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

