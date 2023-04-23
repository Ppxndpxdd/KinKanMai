using System;
using System.Collections.Generic;

namespace KinKanMai.Models;

public partial class Receive
{
    public string OrderId { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string RecUsrId { get; set; } = null!;
}
