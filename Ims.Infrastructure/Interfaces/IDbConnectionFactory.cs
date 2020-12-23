using System.Data.Common;

namespace Ims.Infrastructure.Interfaces
{
    public interface IDbConnectionFactory
    {
        DbConnection CreateConnection();
    }
}