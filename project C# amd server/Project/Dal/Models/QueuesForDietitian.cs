using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class QueuesForDietitian
{
    public int Code { get; set; }

    public int DieticanId { get; set; }

    public bool Available { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan Hour { get; set; }

    public virtual Dietitian Dietican { get; set; }
}
