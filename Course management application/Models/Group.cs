using Course_management_application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_management_application.Models
{
    class Group
    {
        public string No;
        //public bool IsOnline;
        public Categories Category;

        public Student Student { get; private set; }

        public static int count;
        public Students[,] Students;
        public string id;
        public string fullname;
        public string groupno;

        //public Student Student { get; }          
        //public int switch_on;

        public Group()
        {
            count = 300;
        }

        public Group(string no, Categories category)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P" + count;
                    break;
                case Categories.Design:
                    No = $"D" + count;
                    break;
                case Categories.System_administration:
                    No = $"S" + count;
                    break;
                default:
                    break;
            }
            count++;
            int count1 = count;
            Category = category;
            Student = new Student(id, fullname, groupno);

            
            for (int count = 300; count < count1; count++)    
            {
                Group group = new Group();   
            }

            Group(string no, Categories category)
        {
                No = no;
                Category = category;
        }
        }

        private void Group(string v, string no, Categories categories, Categories category)
        {
            throw new NotImplementedException();
        }
    }
}
