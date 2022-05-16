using System;
using System.Collections.Generic;
using System.Text;

namespace Course_management_application.Models
{
    class Student
    {
        public string Id;
        public string Fullname;
        public string GroupNo;
        public string Type;

        public Student(string id, string fullname, string groupno)
        {
            Id = id;
            Fullname = fullname;
            GroupNo = groupno;
        }

        public Student(string id, string fullname, string groupno, string type)
        {
            Id = id;
            Fullname = fullname;
            GroupNo = groupno;
            Type = type;
        }
    }
}
