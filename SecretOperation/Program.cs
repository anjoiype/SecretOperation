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
                var financeListner = new Subscribers.FinanceListener();
                var defenceListner = new Subscribers.DefenceListener();
                var generalListner = new Subscribers.GeneralListener();

                //Subscribing
                switch (message.Type)
                {
                    case MessageType.DefenceInfo:
                        messageEncryptor.MessageEncrypted += defenceListner.OnMessageEncrypted;
                        break;
                    case MessageType.FinancialInfo:
                        messageEncryptor.MessageEncrypted += financeListner.OnMessageEncrypted;
                        break;
                }
                messageEncryptor.MessageEncrypted += generalListner.OnMessageEncrypted;

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
