using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models;

public partial class Department
{
    public Guid DeptId { get; set; }

    public string DepartmentName { get; set; } = null;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
