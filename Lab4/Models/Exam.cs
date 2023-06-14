﻿namespace Lab_4.Models
{
    abstract public class Trial
    {
        public string Trial_name { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public int Mounth { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Speciality { get; set; }
        public int Number { get; set; }
    }


    [Serializable]
    public class Exam : Trial
    {
        public int Id { get; set; }
        public List<string> Questions { get; set; } 
        public Int16 Grade { get; set; }
    }
}
