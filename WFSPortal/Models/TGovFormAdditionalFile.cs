using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tGovFormAdditionalFile")]
public partial class TGovFormAdditionalFile
{
    [Key]
    [Column("GovFormAdditionalFileGUID")]
    public Guid GovFormAdditionalFileGuid { get; set; }

    public string? GovFormAdditionalFileDescription { get; set; }

    [StringLength(15)]
    public string FormTypeCode { get; set; } = null!;

    public byte[]? FileAttachment { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FormTypeCode")]
    [InverseProperty("TGovFormAdditionalFiles")]
    public virtual TFormType FormTypeCodeNavigation { get; set; } = null!;
}
