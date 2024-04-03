using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcBasePayReason")]
public partial class DcBasePayReason
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BasePayReasonCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BasePayReasonDescription { get; set; }
}
