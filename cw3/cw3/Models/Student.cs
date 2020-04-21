using System;
namespace cw3.Models
{
    public class Student
    {

        public Student(int IdStudent, string FirstName, string LastName)
        {
            this.IdStudent = IdStudent;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
    }
}
