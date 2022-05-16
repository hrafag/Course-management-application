using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Course_management_application.Servvices
{
    class CourseManagementServices
    {
    }

    public void ShowAllGroups(string no)
    {
        if (Group.count > 300)
            foreach (Group group in Group)
            {
                Console.WriteLine(group);
            }
        else
        {
            Console.WriteLine("There is no group");
        }
    }




}
