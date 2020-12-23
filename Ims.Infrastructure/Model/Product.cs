using System.ComponentModel.DataAnnotations;

namespace Ims.Infrastructure.Model
{
    public class Product : BaseEntity
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public double Price { set; get; }
        
    }
}