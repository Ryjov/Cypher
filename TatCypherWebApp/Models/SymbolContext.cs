using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TatCypherWebApp.Models
{
    public class SymbolContext : DbContext
    {
        public SymbolContext()
            : base("DbConnection")
        { }

        public DbSet<SymbolModel> Symbols { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
    }
}