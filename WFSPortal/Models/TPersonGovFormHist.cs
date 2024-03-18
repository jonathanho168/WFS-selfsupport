using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonGovFormHist")]
public partial class TPersonGovFormHist
{
    [Key]
    [Column("PersonGovFormHistGUID")]
    public Guid PersonGovFormHistGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonGovFormStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonGovFormEndDate { get; set; }

    public bool PersonGovFormCurrentFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(15)]
    public string FormTypeCode { get; set; } = null!;

    public string? FormDescription { get; set; }

    public byte[]? FormAttachment { get; set; }

    public bool FormAdditionalFilesFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("FormTypeCode")]
    [InverseProperty("TPersonGovFormHists")]
    public virtual TFormType FormTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonGovFormHists")]
    public virtual TPerson Person { get; set; } = null!;
}
