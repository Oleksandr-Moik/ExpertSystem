using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    [Serializable]
    class Question : Object
    {
        public string KeyIndex { get; set; }
        public string Text { get; set; }

        public string NextLeftQuetion__KeyIndex { get; set; }
        public string NextRightQuetion_KeyIndex { get; set; }

        public string NextLeftAnsver_KeyIndex { get; set; }
        public string NextRightAnsver_KeyIndex { get; set; }

        public Question(string key, string text)
        {
            this.KeyIndex = key;
            this.Text = text;
        }
    }
}
