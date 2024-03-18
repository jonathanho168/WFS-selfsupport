using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VDirectDepositParameter
{
    [Column("DirectDepositParametersGUID")]
    public Guid DirectDepositParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? MaximumAccounts { get; set; }

    [Column("ValidateABARoutingNumber")]
    public string? ValidateAbaroutingNumber { get; set; }
}
