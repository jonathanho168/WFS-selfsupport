using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcDepartment")]
public partial class DcDepartment
{
    [StringLength(50)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DepartmentDescription { get; set; }
}
