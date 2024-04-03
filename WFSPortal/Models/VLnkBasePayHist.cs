using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkBasePayHist
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonBasePayStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonBasePayEndDate { get; set; }

    [StringLength(15)]
    public string ScheduleCode { get; set; } = null!;
}
