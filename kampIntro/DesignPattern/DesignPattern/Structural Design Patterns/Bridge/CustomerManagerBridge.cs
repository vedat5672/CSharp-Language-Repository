namespace DesignPattern.Bridge
{
    public class CustomerManagerBridge
    {
        public MessageSender message { get; set; }
        public void UpdateCustomer()
        {
            message.Send(new Body() { Text = "merhaba", Title = "dkjfdf" });
            Console.WriteLine("customer updated");
        }

    }
}
