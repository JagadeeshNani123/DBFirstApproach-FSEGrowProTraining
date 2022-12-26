using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models;

public partial class Employee
{
    public Guid EmpNo { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public long PhoneNumber { get; set; }

    public Guid? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
