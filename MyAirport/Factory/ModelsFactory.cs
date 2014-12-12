using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Factory
{
    public static class ModelsFactory
    {
        private static MyAirport.Data.AbstractModel singleton = null;
        public static MyAirport.Data.AbstractModel Model
        {
            get
            {
                if (singleton == null)
                {
                    switch (ConfigurationManager.AppSettings["Factory"])
                    {
                        case "Sql":
                            singleton = new MyAirport.Data.ModelSql();
                            break;
                        case "natif":
                            singleton = new MyAirport.Data.ModelNatif();
                            break;
                    }

                }
                return singleton;
            }
        }

    }
}
