using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tHealthAndSafetyChecklistDetail")]
public partial class THealthAndSafetyChecklistDetail
{
    [Key]
    [Column("HealthAndSafetyChecklistDetailGUID")]
    public Guid HealthAndSafetyChecklistDetailGuid { get; set; }

    [StringLength(15)]
    public string HealthAndSafetyChecklistCode { get; set; } = null!;

    [StringLength(15)]
    public string HealthAndSafetyChecklistQuestionCode { get; set; } = null!;

    public string? Comments { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public bool? Answer { get; set; }

    [ForeignKey("HealthAndSafetyChecklistCode")]
    [InverseProperty("THealthAndSafetyChecklistDetails")]
    public virtual THealthAndSafetyChecklist HealthAndSafetyChecklistCodeNavigation { get; set; } = null!;

    [ForeignKey("HealthAndSafetyChecklistQuestionCode")]
    [InverseProperty("THealthAndSafetyChecklistDetails")]
    public virtual THealthAndSafetyChecklistQuestion HealthAndSafetyChecklistQuestionCodeNavigation { get; set; } = null!;
}
