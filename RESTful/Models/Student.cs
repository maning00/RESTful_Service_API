using System;
namespace RESTful.Models
{
    public class Student
    {
        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String banji;
        public String Banji
        {
            get { return banji; }
            set { banji = value; }
        }
        int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}