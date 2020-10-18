using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// edit button
        /// open edit form as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).ShowDialog();
        }


        /// <summary>
        /// launch test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            LoadFirstSituation();
            groupBox1.Visible = true;
        }

        private void LoadFirstSituation()
        {

        }

        private void LoadNextProblem()
        {

        }

        private void CheckOnResult()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckOnResult();
            LoadNextProblem();
        }

       
    }
       
}

