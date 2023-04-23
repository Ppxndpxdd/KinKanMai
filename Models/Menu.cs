using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KinKanMai.Models;

public partial class Menu
{
    public int MenuId { get; set; }
    public string CanteenName { get; set; } = null!;

    public string FoodName { get; set; } = null!;
    public int Cost { get; set; }

    public byte[]? Image { get; set; }
}
