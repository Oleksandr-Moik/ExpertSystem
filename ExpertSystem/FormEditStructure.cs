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
        private FormMain _FormMain;
        public FormEditStructure(FormMain formMain)
        {
            InitializeComponent();

            _FormMain = formMain;
        }
    }
}
