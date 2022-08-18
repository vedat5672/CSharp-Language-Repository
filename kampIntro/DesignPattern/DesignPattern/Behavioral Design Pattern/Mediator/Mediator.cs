namespace DesignPattern.Mediator
{
    public class Mediator 
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.ReceiveImage(url);
            }
        }
        public void SendQuestion(string question,Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }
        public void SendAnswer(string answer,Student student)
        {
            student.ReceiveAnswer(answer,student);
        }
    }
}
