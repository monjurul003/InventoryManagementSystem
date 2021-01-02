using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Ims.Infrastructure.Interfaces;
using Ims.Infrastructure.Model;

namespace Ims.Infrastructure.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly string TableName = "ims.products";
        public Task<bool> Insert(Product item, DbConnection connection)
        {
            var sql = $"INSERT INTO ims.products (name, price) VALUES (@Name, @Price);";
            var param = new DynamicParameters();
            param.Add("@Name", item.Name);
            param.Add("@Price", item.Price);
            return connection.ExecuteScalarAsync<bool>(sql, param);
        }

        public Task<bool> Remove(int id, DbConnection connection)
        {
            var sql = $"DELETE FROM ims.products WHERE Id=@Id;";
            var param = new DynamicParameters();
            param.Add("@Id", id);
            return connection.ExecuteScalarAsync<bool>(sql, param);
        }

        public Task<bool> Update(Product item, DbConnection connection)
        {
            var sql = $"UPDATE {TableName} SET name=@Name, price=@Price WHERE id = @Id;";
            var param = new DynamicParameters();
            param.Add("@Name", item.Name);
            param.Add("@Price", item.Price);
            return connection.ExecuteScalarAsync<bool>(sql,param);
        }

        public Task<Product> FindById(int id, DbConnection connection)
        {
            var sql = $"Select * FROM {TableName} WHERE id=@Id";
            var param = new DynamicParameters();
            param.Add("@Id", id);
            return connection.QuerySingleAsync<Product>(sql, param);
        }
        public Task<Product> FindByName(string name, DbConnection connection)
        {
            var sql = $"Select * FROM {TableName} WHERE name=@Name;";
            var param = new DynamicParameters();
            param.Add("@Name", name);
            return connection.QuerySingleAsync<Product>(sql, param);
        }

        public Task<IEnumerable<Product>> FindAll(DbConnection connection)
        {
            var sql = $"SELECT * FROM {TableName}";
            return connection.QueryAsync<Product>(sql); ;
        }
    }
}