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

        public string NextLeftQuestion__KeyIndex { get; set; }
        public string NextRightQuestion_KeyIndex { get; set; }

        public string NextLeftAnswer_KeyIndex { get; set; }
        public string NextRightAnswer_KeyIndex { get; set; }

        public bool NextLeftLeaf_IsAnswer { get; set; }
        public bool NextRightLeaf_IsAnswer { get; set; }

        public Question(string key, string text)
        {
            this.KeyIndex = key;
            this.Text = text;
            
            NextLeftQuestion__KeyIndex = null;
            NextRightQuestion_KeyIndex = null;
            NextLeftAnswer_KeyIndex = null;
            NextRightAnswer_KeyIndex = null;

            NextLeftLeaf_IsAnswer = false;
            NextRightLeaf_IsAnswer = false;
        }
    }
}
