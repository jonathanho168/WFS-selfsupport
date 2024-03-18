using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("USysLnkImportMaster")]
[Index("ImportMasterCode", Name = "AK_USysLnkImportMaster", IsUnique = true)]
public partial class UsysLnkImportMaster
{
    [StringLength(15)]
    public string ImportMasterCode { get; set; } = null!;

    public string? ImportMasterDescription { get; set; }

    [StringLength(80)]
    public string ImportTemplateClass { get; set; } = null!;

    [StringLength(50)]
    public string ReportEntityName { get; set; } = null!;

    public bool VendorImportFlag { get; set; }

    [StringLength(15)]
    public string ImportTypeCode { get; set; } = null!;

    [StringLength(15)]
    public string? VendorCode { get; set; }

    [Key]
    [Column("LnkImportMasterGUID")]
    public Guid LnkImportMasterGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool UseCustomRunPageFlag { get; set; }

    [ForeignKey("ImportTypeCode")]
    [InverseProperty("UsysLnkImportMasters")]
    public virtual UsysLnkImportType ImportTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("ReportEntityName")]
    [InverseProperty("UsysLnkImportMasters")]
    public virtual UsysEntity ReportEntityNameNavigation { get; set; } = null!;

    [InverseProperty("LnkImportMaster")]
    public virtual ICollection<UsysLnkImportDate> UsysLnkImportDates { get; set; } = new List<UsysLnkImportDate>();

    [InverseProperty("LnkImportMaster")]
    public virtual ICollection<UsysLnkImportGroup> UsysLnkImportGroups { get; set; } = new List<UsysLnkImportGroup>();

    [InverseProperty("LnkImportMaster")]
    public virtual ICollection<UsysLnkImportSource> UsysLnkImportSources { get; set; } = new List<UsysLnkImportSource>();

    [ForeignKey("VendorCode")]
    [InverseProperty("UsysLnkImportMasters")]
    public virtual TVendor? VendorCodeNavigation { get; set; }
}
