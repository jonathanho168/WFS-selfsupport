using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHealthAndSafetyChecklist")]
[Index("HealthAndSafetyChecklistGuid", Name = "RG_tHealthAndSafetyChecklist", IsUnique = true)]
public partial class THealthAndSafetyChecklist
{
    [Key]
    [StringLength(15)]
    public string HealthAndSafetyChecklistCode { get; set; } = null!;

    public string? HealthAndSafetyChecklistDescription { get; set; }

    [Column("HealthAndSafetyChecklistGUID")]
    public Guid HealthAndSafetyChecklistGuid { get; set; }

    public string? HeaderText { get; set; }

    [StringLength(80)]
    public string? HeaderTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCompleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateReviewed { get; set; }

    [StringLength(80)]
    public string? PositionTitle { get; set; }

    [StringLength(80)]
    public string? CompanyWorkplace { get; set; }

    public string? Comments { get; set; }

    [Column("EmployeePersonGUID")]
    public Guid? EmployeePersonGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [Column("PersonWhoCompletedChecklistPersonGUID")]
    public Guid? PersonWhoCompletedChecklistPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateAgreedActionsReviewed { get; set; }

    public bool AreChemicalsUsedFlag { get; set; }

    [ForeignKey("EmployeePersonGuid")]
    [InverseProperty("THealthAndSafetyChecklistEmployeePeople")]
    public virtual TPerson? EmployeePerson { get; set; }

    [ForeignKey("PersonWhoCompletedChecklistPersonGuid")]
    [InverseProperty("THealthAndSafetyChecklistPersonWhoCompletedChecklistPeople")]
    public virtual TPerson? PersonWhoCompletedChecklistPerson { get; set; }

    [InverseProperty("HealthAndSafetyChecklistCodeNavigation")]
    public virtual ICollection<THealthAndSafetyChecklistDetail> THealthAndSafetyChecklistDetails { get; set; } = new List<THealthAndSafetyChecklistDetail>();
}
