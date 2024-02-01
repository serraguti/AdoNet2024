using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            //DEBEMOS CARGAR EL FILE config.json
            IConfigurationBuilder builder =
                new ConfigurationBuilder()
                .AddJsonFile("config.json", true, true);
            //RECUPERAMOS LA CLASE QUE PROPORCIONA LOS VALUES DEL JSON
            IConfigurationRoot config = builder.Build();
            string connectionString = config["SqlHospital"];
            return connectionString;
        }
    }
}
