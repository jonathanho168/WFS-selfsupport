using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonMilitaryHist")]
[Index("PersonGuid", "PersonMilitaryStartDate", "MilitaryBranchCode", Name = "AK_tPersonMilitaryHist", IsUnique = true)]
public partial class TPersonMilitaryHist
{
    [Key]
    [Column("PersonMilitaryGUID")]
    public Guid PersonMilitaryGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PersonMilitaryStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PersonMilitaryEndDate { get; set; }

    public bool PersonMilitaryCurrentFlag { get; set; }

    [StringLength(15)]
    public string MilitaryStatusCode { get; set; } = null!;

    [StringLength(15)]
    public string MilitaryBranchCode { get; set; } = null!;

    [StringLength(15)]
    public string MilitaryConflictCode { get; set; } = null!;

    public bool OfficerFlag { get; set; }

    [StringLength(80)]
    public string? AchievedRankOrRate { get; set; }

    [StringLength(80)]
    public string? OccupationalSpecialty { get; set; }

    public string? Comments { get; set; }

    [StringLength(15)]
    public string? ServiceCountryCode { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("MilitaryBranchCode")]
    [InverseProperty("TPersonMilitaryHists")]
    public virtual TMilitaryBranch MilitaryBranchCodeNavigation { get; set; } = null!;

    [ForeignKey("MilitaryConflictCode")]
    [InverseProperty("TPersonMilitaryHists")]
    public virtual TMilitaryConflict MilitaryConflictCodeNavigation { get; set; } = null!;

    [ForeignKey("MilitaryStatusCode")]
    [InverseProperty("TPersonMilitaryHists")]
    public virtual TMilitaryStatus MilitaryStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonMilitaryHists")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("ServiceCountryCode")]
    [InverseProperty("TPersonMilitaryHists")]
    public virtual TCountry? ServiceCountryCodeNavigation { get; set; }
}
