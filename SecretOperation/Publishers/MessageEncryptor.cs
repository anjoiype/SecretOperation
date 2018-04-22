using System;

namespace SecretOperation.Publishers
{
    public class MessageEncryptor
    {
        IEncrypt encryptionTechnique;        
        public event EventHandler<MessageEventArgs> MessageEncrypted;

        public MessageEncryptor(IEncrypt encryptionTechnique)
        {
            this.encryptionTechnique = encryptionTechnique;
        }
        /// <summary>
        /// Method to perform encryption of message.
        /// Contains event notifier.
        /// </summary>
        public void Encrypt()
        {
            try
            {
                string encrytpedMessage = encryptionTechnique.Encrypt();
                OnMessageEncrypted(encrytpedMessage);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error occured while calling the encryption technique.Please find below the details: \n" + ex);
            }
        }
        /// <summary>
        /// Notifying the listners about the event
        /// </summary>
        /// <param name="message">Encrypted message</param>
        protected virtual void OnMessageEncrypted(string message)
        {
            try
            {
                MessageEncrypted?.Invoke(this, new MessageEventArgs { Data = message });
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured while invoking the listners.Please find below the details: \n" + ex);
            }
            
        }
    }
}
