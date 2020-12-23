using System;
using System.Data.Common;
using Ims.Infrastructure.Model;
using Ims.Infrastructure.Repository;

namespace Ims.Infrastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString =
                "server=localhost;port=5432;user id=postgres;password=root;database=imsdb;timeout=5;commandtimeout=5;";
            DbConnectionFactory dbConnFactory = new DbConnectionFactory(connString);
            ProductRepository repo = new ProductRepository(dbConnFactory.CreateConnection());

            // repo.Add(new Product(){Name = "Pencil", Price = 2.4});

            var list = repo.FindAll();
            foreach (var prod in list)
            {
                Console.WriteLine("Id: " + prod.Id + ", Name: " + prod.Name + ", Price: " + prod.Price);
            }
        }
    }
}