using System;

namespace SecretOperation
{
    /// <summary>
    /// Dummy encryption class. Introduces a dummy encryption 
    /// in which every letter of the message is replaced with 
    /// another which is 'key' times beyond in ASCII table. 
    /// </summary>
    public class CeasorCipherWithKey: IEncryptionTechnique
    {
        private readonly Message message;
        private readonly int key;
        /// <summary>
        /// Constructor for ceasor cipher method
        /// </summary>
        /// <param name="message">Accepts the message object</param>
        /// <param name="key">Number of positions to shift letters </param>
        public CeasorCipherWithKey(Message message, int key)
        {
            if(message==null)
                throw new ArgumentNullException(nameof(message));
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
                throw;
            }
            
            
        }
    }
}
