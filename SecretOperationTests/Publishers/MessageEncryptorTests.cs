using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretOperation.Publishers.Tests
{
    [TestClass()]
    public class MessageEncryptorTests
    {
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
    }
}