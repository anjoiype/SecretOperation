using SecretOperation.Publishers;
using System;

namespace SecretOperation.Subscribers
{
    class DefenceListener
    {
        public IPublisher Publisher { get; private set; }

        public DefenceListener(IPublisher publisher)
        {
            Publisher = publisher;
        }
        public void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Defence messages and the message I got is :\n " + message.Data);
        }
    }
}
