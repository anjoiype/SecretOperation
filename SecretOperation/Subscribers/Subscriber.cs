using SecretOperation.Publishers;
using System;
namespace SecretOperation.Subscribers
{
    /// <summary>
    /// Abstract class for the subscriber. Subscriber can call event of publisher through interface
    /// </summary>
    abstract class Subscriber
    {
        public readonly IPublisher publisher;
        protected Subscriber(IPublisher publisher)
        {
            if (publisher == null)
                throw new ArgumentNullException(nameof(publisher));

            this.publisher = publisher;
        }
        public virtual void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am a lsitner and the message I got is: \n "+message.Data);
        }
    }
}
