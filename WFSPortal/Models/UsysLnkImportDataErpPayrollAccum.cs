using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportDataErpPayrollAccum")]
public partial class UsysLnkImportDataErpPayrollAccum
{
    [Column("CompanyID")]
    [StringLength(50)]
    public string? CompanyId { get; set; }

    [Column("EmployeeID")]
    [StringLength(50)]
    public string? EmployeeId { get; set; }

    [StringLength(50)]
    public string? CheckNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckDate { get; set; }

    [StringLength(50)]
    public string? AccumulatorCode { get; set; }

    [Column(TypeName = "numeric(15, 5)")]
    public decimal? CheckValue { get; set; }

    [Column("MTD", TypeName = "numeric(15, 5)")]
    public decimal? Mtd { get; set; }

    [Column("QTD", TypeName = "numeric(15, 5)")]
    public decimal? Qtd { get; set; }

    [Column("YTD", TypeName = "numeric(15, 5)")]
    public decimal? Ytd { get; set; }

    [Column(TypeName = "numeric(15, 5)")]
    public decimal? Hours { get; set; }

    [Column(TypeName = "numeric(15, 5)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecordDate { get; set; }

    [Key]
    [Column("LnkImportDataErpPayrollAccumGUID")]
    public Guid LnkImportDataErpPayrollAccumGuid { get; set; }

    public bool ProcessedByImportFlag { get; set; }

    public int RowVersion { get; set; }
}
