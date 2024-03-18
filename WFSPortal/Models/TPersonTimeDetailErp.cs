using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonTimeDetailERP")]
public partial class TPersonTimeDetailErp
{
    [Key]
    [Column("PersonTimeDetailERPGUID")]
    public Guid PersonTimeDetailErpguid { get; set; }

    [Column("TimeDetailGUID")]
    public Guid TimeDetailGuid { get; set; }

    public int LaborHedSeq { get; set; }

    public int? LaborDtlSeq { get; set; }

    public int RowVersion { get; set; }
}
