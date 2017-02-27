using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ToniqueAcademy.Data
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}