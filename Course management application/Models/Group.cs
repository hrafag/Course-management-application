using Course_management_application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_management_application.Models
{
    class Group
    {
        private string No;
        public bool IsOnline;
        public Categories Category;
        private int switch_on;
        public static int count;

        static Group()
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
            Category = category;
        }
    }
}
