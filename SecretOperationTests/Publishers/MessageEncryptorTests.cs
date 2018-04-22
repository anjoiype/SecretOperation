using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SecretOperation.Publishers.Tests
{
    [TestClass()]
    public class MessageEncryptorTests
    {
        #region positive scenarios
        [TestMethod()]
        public void Encrypt_InvokeEvent_ReturnsTrue()
        {
            var message = new Message(MessageType.DefenceInfo);
            var encryptionTechnique = new CeasorCipherWithKey(message, 3);
            var messageEncryptor = new MessageEncryptor(encryptionTechnique);
            var emptyMessage = string.Empty;
            
            messageEncryptor.MessageEncrypted += delegate (object source, MessageEventArgs args)
            {
                emptyMessage = args.Data;
            };
            messageEncryptor.Encrypt();

            Assert.AreNotEqual(emptyMessage, string.Empty);
        }
        #endregion
        #region negative scenario
        [TestMethod()]
        public void Constructor_PassNull_ThrowError()
        {
            ArgumentNullException argumentNullException = null;
            try
            {
                new MessageEncryptor(null);
                
            }
            catch(ArgumentNullException argex)
            {
                argumentNullException = argex;
            }
            Assert.IsNotNull(argumentNullException);
        }       
        #endregion
    }
}