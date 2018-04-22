using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class DefenceListener:Subscriber
    {
        public DefenceListener(IPublisher publisher) : base(publisher) { }        
        public override void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Defence messages and the message I got is :\n " + message.Data);
        }
    }
}
