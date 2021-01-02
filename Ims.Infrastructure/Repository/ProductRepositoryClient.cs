using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ims.Infrastructure.Interfaces;
using Ims.Infrastructure.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace Ims.Infrastructure.Repository
{
    public class ProductRepositoryClient : IProductRepositoryClient
    {
        private readonly IDbConnectionFactory _connectionFactory;
        private readonly IMapper _mapper;
        private readonly IRepository<Product> _productRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

      
        public Task<ActionResult<bool>> ProductExistAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<bool>> ProductExistAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<Product>> GetProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<Product>> GetProductAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<bool>> RemoveProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<bool>> RemoveProductAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<IList<Product>>> GetAllProductsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}