namespace DesignPattern.Bridge
{
    public class EmailSender : MessageSender
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was send via SmsSender \n {1}", body.Title = "Software Deeveloper", body.Text = "I want to work");
        }
    }
}
