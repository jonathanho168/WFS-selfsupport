using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcOrgUnitLevel")]
public partial class DcOrgUnitLevel
{
    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationUnitLevelCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? OrganizationUnitLevelDescription { get; set; }
}
