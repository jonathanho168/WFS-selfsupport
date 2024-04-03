using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VFieldMask
{
    [Column("FieldMasksGUID")]
    public Guid FieldMasksGuid { get; set; }

    public int RowVersion { get; set; }

    public string? EmailMessage { get; set; }

    public string? Email { get; set; }
}
