namespace LatihanInheritance
{
    public class Teacher : Person
    {

        private string teacherId;
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }


        public Teacher(string name, int age, string teacherId, string subject) : base(name, age)
        {
            this.teacherId = teacherId;
            this.subject = subject;
        }
    }
}