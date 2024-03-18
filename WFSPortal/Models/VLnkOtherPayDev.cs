using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkOtherPayDev
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonOtherPayStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonOtherPayEndDate { get; set; }

    [StringLength(15)]
    public string OtherPayTypeCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? PersonOtherPayAmount { get; set; }
}
