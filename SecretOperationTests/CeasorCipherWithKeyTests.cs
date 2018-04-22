using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretOperation.Tests
{
    [TestClass()]
    public class CeasorCipherWithKeyTests
    {
        [TestMethod()]
        public void Encrypt_EncryptsDataCorrectly_ReturnsTrue()
        {
            Message message = new Message(MessageType.DefenceInfo);
            var technique = new CeasorCipherWithKey(message, 3);
            var encryptedText = string.Empty;

            encryptedText = technique.Encrypt();

            Assert.AreNotEqual(message.Text, encryptedText);
        }
    }
}