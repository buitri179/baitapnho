using System.ComponentModel.DataAnnotations;

namespace baitapnho.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}