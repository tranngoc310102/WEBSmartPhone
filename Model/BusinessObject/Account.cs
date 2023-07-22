using System;
using System.Collections.Generic;

namespace Model.BusinessObject;

public partial class Account
{
    public int AccountId { get; set; }

    public string? AccountName { get; set; }

    public string? Pass { get; set; }

    public int? Role { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
