namespace DesignPattern.Mediator
{
    public class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get;  set; }

        public void ReceiveImage(string url)
        {
            Console.WriteLine("student reciece ımage {1} : {0}",url ,Name);
            
        }

        public void ReceiveAnswer(string answer,Student student)
        {
            Console.WriteLine("Student receive answer {0}: {1}",student,answer);
        }
    }
}
