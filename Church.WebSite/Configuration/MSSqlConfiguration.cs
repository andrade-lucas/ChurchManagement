using Church.Infra.Context;

namespace Church.WebSite.Configuration
{
    public class MSSqlConfiguration : IDbConfiguration
    {
        public string ConnectionString { get => @""; }
    }
}