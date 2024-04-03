using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tClass")]
public partial class TClass
{
    [StringLength(15)]
    public string CourseCode { get; set; } = null!;

    [StringLength(15)]
    public string ClassStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CanceledDate { get; set; }

    [StringLength(15)]
    public string TrainingProviderCode { get; set; } = null!;

    public int? MinimumEnrollment { get; set; }

    public int? MaximumEnrollment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClassStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClassEndDate { get; set; }

    [StringLength(15)]
    public string ClassCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? ClassCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? ClassDepositCost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelCostEffectiveDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CancelCost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DropCostEffectiveDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? DropCost { get; set; }

    [StringLength(15)]
    public string PrimaryInstructorCode { get; set; } = null!;

    [StringLength(15)]
    public string SecondaryInstructorCode { get; set; } = null!;

    public string? Comments { get; set; }

    [Key]
    [Column("ClassGUID")]
    public Guid ClassGuid { get; set; }

    public bool AutoEnrollFlag { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    [StringLength(128)]
    public string? ClassUrl { get; set; }

    [StringLength(15)]
    public string FacilityCode { get; set; } = null!;

    public bool Act48 { get; set; }

    [ForeignKey("ClassCurrencyCode")]
    [InverseProperty("TClasses")]
    public virtual TCurrency ClassCurrencyCodeNavigation { get; set; } = null!;

    [ForeignKey("ClassStatusCode")]
    [InverseProperty("TClasses")]
    public virtual TClassStatus ClassStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("CourseCode")]
    [InverseProperty("TClasses")]
    public virtual TCourse CourseCodeNavigation { get; set; } = null!;

    [ForeignKey("FacilityCode")]
    [InverseProperty("TClasses")]
    public virtual TFacility FacilityCodeNavigation { get; set; } = null!;

    [ForeignKey("PrimaryInstructorCode")]
    [InverseProperty("TClassPrimaryInstructorCodeNavigations")]
    public virtual TInstructor PrimaryInstructorCodeNavigation { get; set; } = null!;

    [ForeignKey("SecondaryInstructorCode")]
    [InverseProperty("TClassSecondaryInstructorCodeNavigations")]
    public virtual TInstructor SecondaryInstructorCodeNavigation { get; set; } = null!;

    [InverseProperty("Class")]
    public virtual ICollection<TClassSchedule> TClassSchedules { get; set; } = new List<TClassSchedule>();

    [InverseProperty("Class")]
    public virtual ICollection<TClassTrainingMaterial> TClassTrainingMaterials { get; set; } = new List<TClassTrainingMaterial>();

    [InverseProperty("Class")]
    public virtual ICollection<TClassTrainingResource> TClassTrainingResources { get; set; } = new List<TClassTrainingResource>();

    [InverseProperty("Class")]
    public virtual ICollection<TPersonTraining> TPersonTrainings { get; set; } = new List<TPersonTraining>();

    [InverseProperty("Class")]
    public virtual ICollection<TPersonWaitList> TPersonWaitLists { get; set; } = new List<TPersonWaitList>();

    [ForeignKey("TrainingProviderCode")]
    [InverseProperty("TClasses")]
    public virtual TTrainingProvider TrainingProviderCodeNavigation { get; set; } = null!;
}
