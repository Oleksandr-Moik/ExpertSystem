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
        public string Key { get; set; }
        public string Text { get; set; }

        public string NextYesQuestion__KeyIndex { get; set; }
        public string NextNoQuestion_KeyIndex { get; set; }

        public string NextYesAnswer_KeyIndex { get; set; }
        public string NextNoAnswer_KeyIndex { get; set; }

        public bool NextYesChild_IsAnswer { get; set; }
        public bool NextNoChild_IsAnswer { get; set; }

        public Question(string key, string text)
        {
            this.Key = key;
            this.Text = text;
            
            NextYesQuestion__KeyIndex = null;
            NextNoQuestion_KeyIndex = null;
            NextYesAnswer_KeyIndex = null;
            NextNoAnswer_KeyIndex = null;

            NextYesChild_IsAnswer = false;
            NextNoChild_IsAnswer = false;
        }
    }
}
