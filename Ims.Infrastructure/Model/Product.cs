using System.ComponentModel.DataAnnotations;

namespace Ims.Infrastructure.Model
{
    public class Products : BaseEntity
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public double Price { set; get; }
        
    }
}