using System;

namespace SecretOperation.Subscribers
{
    class FinanceListner
    {
        public void OnMessageEncrypted(object source, MessageEventArgs message)
        {
            Console.WriteLine("\nI am interested in Finance messages and the message I got is: \n " + message.Data);
        }
    }
}
