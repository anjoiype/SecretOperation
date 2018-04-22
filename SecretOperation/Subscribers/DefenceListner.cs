using System;

namespace SecretOperation.Subscribers
{
    class DefenceListner
    {
        public void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Defence messages and the message I got is :\n " + message.Data);
        }
    }
}
