using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class GeneralListener:Subscriber
    {
        public GeneralListener(IPublisher publisher) : base(publisher) { }
        public override void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am a general lsitner and the message I got is: \n " + message.Data);
        }
    }
}
