using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Refactor.Domain
{
    class KitRepositoryFactory
    {

        #region Singleton pattern

        private static KitRepositoryFactory instance;

        private KitRepositoryFactory() { }

        public static KitRepositoryFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KitRepositoryFactory();
                }
                return instance;
            }
        }

        #endregion

        public IKitRepository Get(string type)
        {

        IKitRepository result = null;

            switch (type)
            {
                case "postgresql":
                    result = new PostgresqlKitRepository();
                    break;
            }

            return result;

        }

    }
}
