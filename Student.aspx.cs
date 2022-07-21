using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<StudentList> StudentsList = new List<StudentList>();
            StudentsList.Add(new StudentList(1, "Manas", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(2, "Raheem", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(3, "Sameen", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(4, "Khan", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(5, "Bhatti", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(6, "Tuba", 2.33, "12 Ala baad Lahore"));
            StudentsList.Add(new StudentList(7, "Rameesa", 2.33, "12 Ala baad Lahore"));
        }
    }
}