using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonAbsenceHistFile")]
public partial class TPersonAbsenceHistFile
{
    [Key]
    [Column("PersonAbsenceHistFileGUID")]
    public Guid PersonAbsenceHistFileGuid { get; set; }

    [Column("PersonAbsenceGUID")]
    public Guid PersonAbsenceGuid { get; set; }

    public byte[]? PersonAbsenceHistFile { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("PersonAbsenceGuid")]
    [InverseProperty("TPersonAbsenceHistFiles")]
    public virtual TPersonAbsenceHist PersonAbsence { get; set; } = null!;
}
