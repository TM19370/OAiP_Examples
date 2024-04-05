namespace kontrvatiantist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email emailBox = SendMessage;
            emailBox(new EmailMessage("Welcome"));

            //контрвариантность позволяет присваевать делегату метод, тип параметра которого является более универсальным по отношению к типу параметра делегата

            //ДЗ: ковариантный обобщенный делегат и контрвариантный обабщенный делегат
        }

        static void SendMessage(Message message) =>
                message.Print();

        delegate void Email(EmailMessage email);
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