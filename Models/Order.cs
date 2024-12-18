using System.ComponentModel.DataAnnotations;

namespace baitapnho.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; }
    
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
} 