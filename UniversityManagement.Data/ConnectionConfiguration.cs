using Microsoft.Extensions.Configuration;

namespace UniversityManagement.Data
{
    public static class ConnectionConfiguration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../UniversityManagement.Api"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("UniveristyConnection");
            }
        }
    }
}
