using Carlib.Common.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace SRP_Refactor.Domain
{
    class KitRepository
    {
        private CommonDatabasePostgreSQL databaseConnection;

        public KitRepository()
        {
            string connectionString = String.Format("Server={0};Port={1};Username={3};Password={4};Database={2};{5}",
                                             "host", "5432", "test", "test", "test", "Pooling = False;");

            this.databaseConnection = new CommonDatabasePostgreSQL(connectionString);
            this.databaseConnection.Open(); //<- Ull l'hauriem de tancar, IDisposable, etc....
        }

        internal bool SaveKit(Kit kit)
        {
            //Validate product
            if (kit == null || kit.KitId < 0 || string.IsNullOrEmpty(kit.Code))
            {
                return false;
            }

            String sql = String.Format("INSERT INTO kit "
                + "(id, codigo, pvp) "
                + "VALUES ({0}, {1}, '{2}') RETURNING id",
                kit.KitId,
                kit.Code,
                kit.Price);

            using (IDbCommand command = databaseConnection.CreateCommand(sql))
            {
                command.ExecuteNonQuery();
            }

            return true;
        }

        internal List<Kit> ListKits()
        {
            String sql = String.Format("SELECT k.id, k.codigo, k.pvp FROM kit k ");

            List<Kit> kits = new List<Kit>();
            using (IDbCommand command = databaseConnection.CreateCommand(sql))
            {
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kit kit = new Kit();
                        kit.KitId = databaseConnection.GetReaderValueInt64(reader, "id");
                        kit.Code = databaseConnection.GetReaderValueString(reader, "codigo");
                        kit.Price = databaseConnection.GetReaderValueDouble(reader, "pvp");

                        kits.Add(kit);
                    }
                }
            }

            return kits;
        }
    }
}
