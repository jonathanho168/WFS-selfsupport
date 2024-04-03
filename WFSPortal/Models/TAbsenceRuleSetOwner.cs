using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tAbsenceRuleSetOwner")]
public partial class TAbsenceRuleSetOwner
{
    [Key]
    [Column("AbsenceRuleSetOwnerGUID")]
    public Guid AbsenceRuleSetOwnerGuid { get; set; }

    [StringLength(15)]
    public string AbsenceRuleSetCode { get; set; } = null!;

    public Guid OwnerPersonGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("AbsenceRuleSetCode")]
    [InverseProperty("TAbsenceRuleSetOwners")]
    public virtual TAbsenceRuleSet AbsenceRuleSetCodeNavigation { get; set; } = null!;

    [ForeignKey("OwnerPersonGuid")]
    [InverseProperty("TAbsenceRuleSetOwners")]
    public virtual TPerson OwnerPerson { get; set; } = null!;
}
