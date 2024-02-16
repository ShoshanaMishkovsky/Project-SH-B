using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Meeting
{
    public int Code { get; set; }

    public int DieticanId { get; set; }

    public int ClientId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Date { get; set; }

    public TimeSpan Hour { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Dietitian Dietican { get; set; } = null!;
}
