using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    [Serializable]
    public class Question : Object
    {
        public string KeyIndex { get; set; }
        public string Text { get; set; }

        public string NextLeftQuetion__KeyIndex { get; set; }
        public string NextRightQuetion_KeyIndex { get; set; }

        public string NextLeftAnswer_KeyIndex { get; set; }
        public string NextRightAnswer_KeyIndex { get; set; }

        public Question(string key, string text)
        {
            this.KeyIndex = key;
            this.Text = text;
            
            NextLeftQuetion__KeyIndex = null;
            NextRightQuetion_KeyIndex = null;
            NextLeftAnswer_KeyIndex = null;
            NextRightAnswer_KeyIndex = null;
        }
    }
}
