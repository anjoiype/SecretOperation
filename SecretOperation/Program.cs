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
                var financeListner = new Subscribers.FinanceListener(messageEncryptor);
                var defenceListner = new Subscribers.DefenceListener(messageEncryptor);
                var generalListner = new Subscribers.GeneralListener(messageEncryptor);

                //Subscribing
                switch (message.Type)
                {
                    case MessageType.DefenceInfo:
                        defenceListner.Publisher.MessageEncrypted += defenceListner.OnMessageEncrypted;
                        break;
                    case MessageType.FinancialInfo:
                        financeListner.Publisher.MessageEncrypted += financeListner.OnMessageEncrypted;
                        break;
                }
                generalListner.Publisher.MessageEncrypted += generalListner.OnMessageEncrypted;

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
