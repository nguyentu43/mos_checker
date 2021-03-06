﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class Task
    {
        public int TestID { get; set; }

        public string UserName { get; set; }

        public string TestName { get; set; }

        public int ID { get; set; }

        public bool IsCompleted { get; set; }
        public int Score { get; set; }

        public int Mode { get; set; }

        public List<List<bool>> Points { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UsedTime { get; set; }

        public List<List<bool>> MarkCompletedQuestions { get; set; }

        public override string ToString()
        {
            return string.Format("Task ID: {0} - Test ID: {0}", ID, TestID);
        }
    }
}
