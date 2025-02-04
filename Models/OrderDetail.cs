﻿using System.ComponentModel.DataAnnotations;

namespace baitapnho.Models;

public class OrderDetail
{
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
}