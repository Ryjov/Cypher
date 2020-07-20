using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class SymbolModel
    {
        public int Id { get; set; }
        public char oldSymbol { get; set; }
        public char newSymbol { get; set; }
    }
}
