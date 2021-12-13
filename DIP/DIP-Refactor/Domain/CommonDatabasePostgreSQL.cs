using System;
using System.Data;

namespace DIP_Refactor.Domain
{
    public class CommonDatabasePostgreSQL
    {
        public String CentralConnectionString
        {
            get; set;
        }

        public CommonDatabasePostgreSQL(string connectionString)
        {
        }
        public void Open()
        { 
        
        }

        internal IDbCommand CreateCommand(string sql)
        {
            return null;
        }

        internal long GetReaderValueInt64(IDataReader reader, string v)
        {
            return 0;
        }

        internal string GetReaderValueString(IDataReader reader, string v)
        {
            return "";
        }

        internal double GetReaderValueDouble(IDataReader reader, string v)
        {
            return 0.0;
        }
    }
}
