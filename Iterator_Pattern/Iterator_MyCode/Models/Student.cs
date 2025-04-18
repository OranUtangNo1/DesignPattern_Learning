﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MyCode.Models
{
    public class Student
    {
        public string Name { get; }
        public Gender Gender { get; }
        public Major Major { get; }
        public string StudentNumber { get; }

        public Student(string name, Gender gender, Major major, string studentNumber)
        {
            Name = name;
            Gender = gender;
            Major = major;
            StudentNumber = studentNumber;
        }
    }
}
