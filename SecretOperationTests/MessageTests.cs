﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretOperation.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void Message_GetMessageCorrectly_ReturnsTrue()
        {
            var message = new Message(MessageType.DefenceInfo);
            Assert.AreNotEqual(message.Text, string.Empty);
        }

        [TestMethod()]
        public void Message_GetMessageAccordingToType_ReturnsTrue()
        {
            var messageOne = new Message(MessageType.DefenceInfo);
            var messageTwo = new Message(MessageType.FinancialInfo);
            Assert.AreNotEqual(messageOne.Type, messageTwo.Type);
        }
    }
}