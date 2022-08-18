namespace DesignPattern.Bridge
{
    public class SmsSender : MessageSender
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was send via SmsSender", body);
        }
    }
}
