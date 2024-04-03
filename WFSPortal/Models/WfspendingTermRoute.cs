using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class WfspendingTermRoute
{
    [Column("RoutingInstanceGUID")]
    public Guid RoutingInstanceGuid { get; set; }

    [Unicode(false)]
    public string? PropertyName { get; set; }

    [Unicode(false)]
    public string? PropertyValue { get; set; }

    [Unicode(false)]
    public string? PropertyName1 { get; set; }

    [Unicode(false)]
    public string? PropertyValue1 { get; set; }

    [Column("EIN")]
    [StringLength(24)]
    public string? Ein { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? LastName { get; set; }

    [StringLength(256)]
    public string? UserName { get; set; }
}
