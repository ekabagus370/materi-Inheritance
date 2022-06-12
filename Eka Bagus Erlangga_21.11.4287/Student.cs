namespace LatihanInheritance
{
    public class Student : Person
    {
        private string studentId;

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public Student(string name, int age, string studentId, string email) : base(name, age)
        {
            this.studentId = studentId;
            this.email = email;
        }
    }
}