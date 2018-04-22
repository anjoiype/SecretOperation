using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class GeneralListener
    {
        public IPublisher Publisher { get; private set; }
        public GeneralListener(IPublisher publisher)
        {
            Publisher = publisher;
        }
        public void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am a general lsitner and the message I got is: \n " + message.Data);
        }
    }
}
