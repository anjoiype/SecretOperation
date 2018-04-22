using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class InternalSecurityListener:Subscriber
    {
        public InternalSecurityListener(IPublisher publisher) : base(publisher) { }
        public override void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Internal security messages and the message I got is: \n " + message.Data);
        }
    }
}
