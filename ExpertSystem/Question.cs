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

        public string LeftChild { get; set; }
        public string LeftText { get; set; }
        public bool LeftChild_IsAnswer { get; set; }


        public string RightChild{ get; set; }
        public string RightText { get; set; }
        public bool RightChild_IsAnswer { get; set; }

        public Question(string key, string text)
        {
            Key = key;
            Text = text;

            LeftText = "Yes";
            RightText = "No";

            LeftChild_IsAnswer = false;
            RightChild_IsAnswer = false;

            LeftChild = "";
            RightChild = "";
        }
    }
}
