using System.Collections.Generic;
using System.Threading.Tasks;
using Ims.Infrastructure.Model;

namespace Ims.Infrastructure.Interfaces
{
    public interface IProductRepositoryClient
    {
        Task<ActionResult<bool>> ProductExistAsync(string name);
        Task<ActionResult<bool>> ProductExistAsync(int id);
        Task<ActionResult<Product>> GetProductAsync(int id);
        Task<ActionResult<Product>> GetProductAsync(string name);
        Task<ActionResult<bool>> RemoveProductAsync(int id);
        Task<ActionResult<bool>> RemoveProductAsync(string name);
        Task<ActionResult<IList<Product>>> GetAllProductsAsync();
    }

}