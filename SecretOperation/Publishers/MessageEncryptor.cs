﻿using System;

namespace SecretOperation.Publishers
{
    public class MessageEncryptor
    {
        IEncrypt encryptionTechnique;
        public delegate void MessageEncryptedEventHandler(object source, MessageEventArgs args);
        public event MessageEncryptedEventHandler MessageEncrypted;

        public MessageEncryptor(IEncrypt encryptionTechnique)
        {
            this.encryptionTechnique = encryptionTechnique;
        }

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