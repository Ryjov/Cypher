using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class MessageProcessor
    {
        public static int CreateMessage(string OriginalMessage, string EncryptedMessage)
        {
            MessageModel data = new MessageModel
            {
                OriginalMessage = OriginalMessage,
                EncryptedMessage = EncryptedMessage
            };

            string sql = @"insert into dbo.EncodedMessages (OriginalMessage, EncryptedMessage)
                            values (@OriginalMessage, @EncryptedMessage);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<MessageModel> LoadMessages()
        {
            string sql = @"select * from dbo.EncodedMessages;";

            return SqlDataAccess.LoadData<MessageModel>(sql);
        }
    }
}
