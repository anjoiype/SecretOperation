using SecretOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SecretOperation.Tests
{
    [TestClass()]
    public class CeasorCipherWithKeyTests
    {
        #region positive scenarios
        [TestMethod()]
        public void Encrypt_EncryptsDataCorrectly_ReturnsTrue()
        {
            Message message = new Message(MessageType.DefenceInfo);
            var technique = new CeasorCipherWithKey(message, 3);
            var encryptedText = string.Empty;

            encryptedText = technique.Encrypt();

            Assert.AreNotEqual(message.Text, encryptedText);
        }
        #endregion

        #region negative scenarios
        [TestMethod()]
        public void Constructor_PassNullMessage_ThrowError()
        {
            ArgumentNullException argumentNullException = null;
            try
            {
                new CeasorCipherWithKey(null, 3); ;

            }
            catch (ArgumentNullException argex)
            {
                argumentNullException = argex;
            }
            Assert.IsNotNull(argumentNullException);
        }
        #endregion
    }
}