

using System;

namespace SecretOperation.Publishers
{
    public interface IPublisher
    {
        event EventHandler<MessageEventArgs> MessageEncrypted;
        void MessageEncrypt(string encryptedMessage);
    }
}
