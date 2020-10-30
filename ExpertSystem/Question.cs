﻿using System;
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

        public string NextLeftQuestion__KeyIndex { get; set; }
        public string NextLeftAnswer_KeyIndex { get; set; }
        
        public string NextRightAnswer_KeyIndex { get; set; }
        public string NextRightQuestion_KeyIndex { get; set; }

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

            NextLeftQuestion__KeyIndex = null;
            NextRightQuestion_KeyIndex = null;
            NextLeftAnswer_KeyIndex = null;
            NextRightAnswer_KeyIndex = null;
        }

        public Question(Question question)
        {
            this.Key = question.Key;
            this.Text = question.Text;

            this.LeftText = question.LeftText;
            this.RightText = question.RightText;

            this.LeftChild_IsAnswer = question.LeftChild_IsAnswer;
            this.RightChild_IsAnswer = question.RightChild_IsAnswer;

            this.LeftChild = question.LeftChild;
            this.RightChild = question.RightChild;

            this.NextLeftQuestion__KeyIndex = question.NextLeftQuestion__KeyIndex;
            this.NextRightQuestion_KeyIndex = question.NextRightQuestion_KeyIndex;
            this.NextLeftAnswer_KeyIndex = question.NextLeftAnswer_KeyIndex;
            this.NextRightAnswer_KeyIndex = question.NextRightAnswer_KeyIndex;
        }
    }
}
