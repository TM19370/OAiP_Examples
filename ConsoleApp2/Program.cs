namespace kovariantnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder messageBuilder = WriteEM;

            Message message = messageBuilder("Hello");
            message.Print();

            //ковариантность позволяет передать делегату метод возвращаемый тип которого является производным от возвращаемого типа делегата
        }

        public static EmailMessage WriteEM(string text) => new EmailMessage(text);

        delegate Message MessageBuilder(string text);
    }

    public class Message
    {
        public string text { get; set; }
        public Message(string _text) =>
            text = _text;

        public virtual void Print() =>
            Console.WriteLine($"Message: {text}");
    }

    public class EmailMessage : Message
    {
        public EmailMessage(string _text) : base(_text) { }

        public override void Print() =>
            Console.WriteLine($"Email: {text}");
    }

    public class SMSMessage : Message
    {
        public SMSMessage(string _text) : base(_text) { }

        public override void Print() =>
            Console.WriteLine($"SMS Message: {text}");
    }
}