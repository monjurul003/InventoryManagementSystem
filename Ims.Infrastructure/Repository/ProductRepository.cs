using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;
using Ims.Infrastructure.Interfaces;
using Ims.Infrastructure.Model;

namespace Ims.Infrastructure.Repository
{
    public class ProductRepository : Irepository<Product>
    {
        private IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(Product item)
        {
            using (IDbConnection dbConn = _connection)
            {
                dbConn.Open();
                dbConn.Execute("INSERT INTO ims.products (name, price) VALUES (@Name, @Price)", item);
            }
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConn = _connection)
            {
                dbConn.Open();
                dbConn.Execute("DELETE FROM ims.produsts WHERE Id=@Id", new {Id = id});
            }
        }

        public void Update(Product item)
        {
            using (IDbConnection dbConn = _connection)
            {
                dbConn.Open();
                dbConn.Execute("UPDATE ims.products SET name=@Name, price=@Price WHERE id = @Id", item);
            }
        }

        public Product FindBy(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> FindAll()
        {
            using (IDbConnection dbConn = _connection)
            {
                dbConn.Open();
                return dbConn.Query<Product>("SELECT * FROM ims.products");
                
            }
        }
    }
}