using System;

namespace SecretOperation
{
    public class CeasorCipherWithKey:IEncrypt
    {
        private Message message;
        private int key;
        /// <summary>
        /// Constructor for ceasor cipher method
        /// </summary>
        /// <param name="message">Accepts the message object</param>
        /// <param name="key">Number of positions to shift letters </param>
        public CeasorCipherWithKey(Message message, int key)
        {
            this.message = message;
            this.key = key;
        }

        /// <summary>
        /// Method to encrypt the message based on the key provided
        /// </summary>
        /// <returns>Encrypted message</returns>
        public string Encrypt()
        {
            try
            {
                char[] messageArray = message.Text.ToCharArray();
                char[] encryptedText = new char[messageArray.Length];
                for (int i = 0; i < messageArray.Length; i++)
                {
                    if (messageArray[i].Equals(' '))
                    {
                        encryptedText[i] = ' ';
                    }
                    else
                    {
                        encryptedText[i] = (char)(messageArray[i] + key);
                    }
                }
                return new string(encryptedText);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured while encrypting message: "+ex);
            }
            return string.Empty;
            
        }
    }
}
