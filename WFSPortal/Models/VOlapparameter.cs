using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VOlapparameter
{
    [Column("OLAPParametersGUID")]
    public Guid OlapparametersGuid { get; set; }

    public int RowVersion { get; set; }

    [Column("OLAPServerName")]
    public string? OlapserverName { get; set; }

    [Column("OLAPDatabaseName")]
    public string? OlapdatabaseName { get; set; }
}
