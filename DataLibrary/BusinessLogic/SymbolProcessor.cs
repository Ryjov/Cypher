using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class SymbolProcessor
    {
        public static int CreateSymbol(char oldSymbol, char newSymbol)
        {
            SymbolModel data = new SymbolModel
            {
                oldSymbol = oldSymbol,
                newSymbol = newSymbol
            };

            string sql = @"insert into dbo.CypherSymbols (oldSymbol, newSymbol)
                            values (@oldSymbol, @newSymbol);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static SymbolModel GetRow(char oldSymbol)
        {
            string sql = $@"select * from dbo.CypherSymbols where oldSymbol ='{oldSymbol}'";
            return SqlDataAccess.LoadData<SymbolModel>(sql)[0];
        }
        
        public static List<SymbolModel> LoadSymbols()
        {
            string sql = @"select Id, oldSymbol, newSymbol from dbo.CypherSymbols;";

            return SqlDataAccess.LoadData<SymbolModel>(sql);
        }
    }
}
