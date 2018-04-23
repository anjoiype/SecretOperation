using System;
using System.IO;

namespace SecretOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var message = new Message(MessageType.DefenceInfo);
                var encryptionTechnique = new CeasorCipherWithKey(message, 7);
                var messageEncryptor = new Publishers.MessageEncryptor(encryptionTechnique);

                //Adding listners               
                var financeListener = new Subscribers.FinanceListener(messageEncryptor);
                var defenceListener = new Subscribers.DefenceListener(messageEncryptor);
                var internalSecurityListener = new Subscribers.InternalSecurityListener(messageEncryptor);
                var generalListener = new Subscribers.GeneralListener(messageEncryptor);

                //Subscribing
                switch (message.Type)
                {
                    case MessageType.DefenceInfo:
                        defenceListener.publisher.MessageEncrypted += defenceListener.OnMessageEncrypted;
                        break;
                    case MessageType.FinancialInfo:
                        financeListener.publisher.MessageEncrypted += financeListener.OnMessageEncrypted;
                        break;
                    case MessageType.InternalSecurity:
                        internalSecurityListener.publisher.MessageEncrypted += internalSecurityListener.OnMessageEncrypted;
                        break;
                }
                generalListener.publisher.MessageEncrypted += generalListener.OnMessageEncrypted;

                messageEncryptor.Encrypt();                
            } 
            catch(FileNotFoundException fileNotFound)
            {
                Console.WriteLine("File not found. Please check for the correct file. Please find below the details:\n"+fileNotFound);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Exception occured: Please find below the details:\n"+ex);
            }
            Console.ReadLine();

        }
    }
}
