using System;
namespace SecretOperation.Subscribers
{
    public class Listner
    {
        public void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am a general lsitner and the message I got is: \n "+message.Data);
        }
    }
}
