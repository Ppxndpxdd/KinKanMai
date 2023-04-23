using System;
using System.Collections.Generic;

namespace KinKanMai.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public int Amout { get; set; }

    public string UserId { get; set; } = null!;

    public string? Detail { get; set; }

    public bool Status { get; set; }
}
