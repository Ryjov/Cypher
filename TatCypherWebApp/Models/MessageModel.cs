using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatCypherWebApp.Models
{
    public class MessageModel
    {
        public int ID { get; set; }
        public int OriginalMessage { get; set; }
        public string EncryptedMessage { get; set; }
    }
}