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

            ProductRepository repo = new ProductRepository();

            // repo.Insert(new Product(){Name = "Sharpner", Price = 2.3}, dbConnFactory.CreateConnection());
            var prodItem =  repo.FindById(2, dbConnFactory.CreateConnection());
            Console.WriteLine("Id: " + prodItem.Id + ", Name: " + prodItem.Result.Name + ", Price: " + prodItem.Result.Price);
            prodItem = repo.FindByName("pant", dbConnFactory.CreateConnection());
            Console.WriteLine("Id: " + prodItem.Id + ", Name: " + prodItem.Result.Name + ", Price: " + prodItem.Result.Price);
            var list = repo.FindAll(dbConnFactory.CreateConnection()).Result;
            foreach (var prod in list)
            {
                Console.WriteLine("Id: " + prod.Id + ", Name: " + prod.Name + ", Price: " + prod.Price);
            }
        }
    }
}