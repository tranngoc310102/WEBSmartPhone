using System;
using System.Collections.Generic;

namespace Model.BusinessObject;

public partial class Order
{
    public int OrderId { get; set; }

    public int? AccountId { get; set; }

    public int? ProductId { get; set; }

    public string? FullName { get; set; }

    public double? Total { get; set; }

    public string? Address { get; set; }

    public int? Status { get; set; }
    public int? Quantity { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Product? Product { get; set; }
}
