﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TatCypherWebApp.Models
{
    public class SymbolModel
    {
        [Key]
        public int Id { get; set; }
        public char oldSymbol { get; set; }
        public char newSymbol { get; set; }
    }
}