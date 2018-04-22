using System;
using System.IO;
using System.Reflection;

namespace SecretOperation
{
    public class Message
    {
        public string Text { get; private set; }
        public MessageType Type { get; private set; }              
        public Message(MessageType type)
        {
            Type = type;
            switch (Type)
            {
                case MessageType.DefenceInfo:
                    Text = GetFileData("DefenceInfo.txt");
                    break;
                case MessageType.FinancialInfo:
                    Text = GetFileData("FinancialInfo.txt");
                    break;
                case MessageType.InternalSecurity:
                    Text = GetFileData("InternalSecurity.txt");
                    break;
                default:
                    Text = GetFileData("message.txt");
                    break;
            }            
        }

        #region private methods
        private string GetFileData(string fileName)
        {
            try
            {
                if (Assembly.GetExecutingAssembly() != null)
                {
                    string executtingDirPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string fullPath = string.Format("{0}\\Resources\\{1}", executtingDirPath, fileName);
                    using (StreamReader reader = new StreamReader(fullPath))
                    {
                        string fileData = reader.ReadToEnd();
                        return fileData;
                    }
                }                
            }
            catch(FileNotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
                throw;
            }
            return string.Empty;
        }
        #endregion

    }
}
