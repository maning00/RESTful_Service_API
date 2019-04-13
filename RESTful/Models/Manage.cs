using System;
using System.Collections.Generic;
using System.Linq;
namespace RESTful.Models
{
    public class Manage
    {
        static Manage manage;
        List<Student> studentlist;
        private Manage()
        {
            studentlist = new List<Student>();
        }

        public void Add(Student student)
        {
            studentlist.Add(student);
        }

        public static Manage GetContent()
        {
            if (manage == null)
            {
                manage = new Manage();
                return manage;
            }
            else
                return manage;
        }

        public String Remove(int num)
        {
            for (int i = 0; i < studentlist.Count; i++)
            {
                Student stu = studentlist.ElementAt(i);
                if (stu.Number == num)
                {
                    studentlist.RemoveAt(i);
                    return "Deleted";
                }
            }
            return "Delete failed";
        }

        public Student GetOneStudent(int id)   //寻找特定学号的学生信息
        {
            for(int i=0;i<studentlist.Count;i++)
            {
                Student stu = studentlist.ElementAt(i);
                if (stu.Number == id)
                    return stu;
            }
            return null;
        }

        public List<Student> GetAllStudent()   
        {
            return studentlist;   //返回整个学生表
        }


        public String UpdateStudent(Student num)
        {
            for (int i = 0; i < studentlist.Count; i++)
            {
                Student stu = studentlist.ElementAt(i);
                if (stu.Number.Equals(num.Number))
                {
                    studentlist[i] = num;
                    return "Updated";
                }
            }
            return "Update Failed";
        }


    }
}