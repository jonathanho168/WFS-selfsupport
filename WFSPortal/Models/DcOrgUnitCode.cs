using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcOrgUnitCode")]
public partial class DcOrgUnitCode
{
    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnitCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnitLevelCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? OrganizationUnitDescription { get; set; }
}
