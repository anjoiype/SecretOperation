using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class FinanceListener:Subscriber
    {
        public FinanceListener(IPublisher publisher) : base(publisher) { }        
        public override void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Finance messages and the message I got is: \n " + message.Data);
        }
    }
}
