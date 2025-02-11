using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory) // Çalışan uygulamanın kök dizinini kullan
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                return configuration.GetConnectionString("PostgreSql");
            }
        }
    }


}
//appsettingse eklediğimiz c. stringi bu katmanda kullanabilmek için gerekli kodları yazdık. C.stringi kullanacağımız zaman bu scripti çağıracağız.