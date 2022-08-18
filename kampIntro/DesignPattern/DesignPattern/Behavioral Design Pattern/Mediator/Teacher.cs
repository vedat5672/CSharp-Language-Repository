namespace DesignPattern.Mediator
{
    public class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }
        public string Name { get; set; }
        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher received a question from {0},{1}",student.Name,question);
        }
        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide :{0}",url);
            _mediator.UpdateImage(url);
        }
        public void AnswerQuestion(string answer,Student student)
        {
            Console.WriteLine("Teacher Answer question {0}:  ,{1}",student.Name,answer);
        }
    }
}
