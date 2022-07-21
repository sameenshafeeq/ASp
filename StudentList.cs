using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class StudentList
    {
        public int ID;
        public string Name;
        public double Cgpa;
        public string Address;
        public StudentList(int ID, string Name,double Cgpa ,string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Cgpa = Cgpa;
            this.Address = Address;
        }
        //public List<StudentList> getstudents()
        //{
            //var StudentList = new List<StudentList>()
        //{
             //new StudentList { ID=1, Name="Manas",Cpga=2.33,Address="12 Ala baad Lahore"},
             //new StudentList { ID=2, Name="Naila",Cpga=2.67,Address="13 Ala baad Lahore"},
             //new StudentList { ID=3, Name="Rahima",Cpga=3.00,Address="14 Ala baad Lahore"},
             //new StudentList { ID=4, Name="Sameen Shafeeq",Cpga=3.45,Address="15 Ala baad Lahore"},
             //new StudentList { ID=5, Name="Huda",Cpga=4.0,Address="16 Ala baad Lahore"},
             //new StudentList { ID=6, Name="Verdah",Cpga=3.9,Address="17 Ala baad Lahore"},
             //new StudentList { ID=7, Name="Rimsha",Cpga=3.56,Address="18 Ala baad Lahore"},
             //new StudentList { ID=8, Name="Tehreem",Cpga=3.45,Address="19 Ala baad Lahore"},
             //new StudentList { ID=9, Name="Nadia",Cpga=1.00,Address="20 Ala baad Lahore"},
             //new StudentList { ID=10, Name="Hadia",Cpga=1.89,Address="22 Ala baad Lahore"},
             //new StudentList { ID=11, Name="Sadia",Cpga=5.78,Address="23 Ala baad Lahore"},
        //     new StudentList { ID=12, Name="Narmeen",Cpga=7.88,Address="24 Ala baad Lahore"},
        //     new StudentList { ID=13, Name="Talha",Cpga=4.00,Address="25 Ala baad Lahore"},
        //};
        //    return StudentList;
        //}
    }
}