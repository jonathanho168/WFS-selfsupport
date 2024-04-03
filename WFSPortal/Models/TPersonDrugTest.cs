using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonDrugTest")]
[Index("PersonGuid", "DrugTestTypeCode", "ScheduledDateTime", Name = "AK_tPersonDrugTest", IsUnique = true)]
[Index("DrugTestTypeCode", Name = "IX_PersonDrugTest_DrugTestTypeCode")]
public partial class TPersonDrugTest
{
    [Key]
    [Column("PersonDrugTestGUID")]
    public Guid PersonDrugTestGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string DrugTestTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScheduledDateTime { get; set; }

    [StringLength(15)]
    public string ScheduledMedicalFacilityCode { get; set; } = null!;

    [StringLength(15)]
    public string DrugTestReasonCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TestDeadlineDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TestDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextTestDeadlineDate { get; set; }

    [StringLength(15)]
    public string MedicalFacilityCode { get; set; } = null!;

    [Column("RequestedByPersonGUID")]
    public Guid? RequestedByPersonGuid { get; set; }

    [StringLength(30)]
    public string? MedicalFacilityContact { get; set; }

    [StringLength(15)]
    public string DrugTestResultCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ResultDate { get; set; }

    public string? Comments { get; set; }

    public int RowVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastPhysicalExam { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextPhysicalDueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnsetOfSymptoms { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastDayAtWork { get; set; }

    [ForeignKey("DrugTestReasonCode")]
    [InverseProperty("TPersonDrugTests")]
    public virtual TDrugTestReason DrugTestReasonCodeNavigation { get; set; } = null!;

    [ForeignKey("DrugTestResultCode")]
    [InverseProperty("TPersonDrugTests")]
    public virtual TDrugTestResult DrugTestResultCodeNavigation { get; set; } = null!;

    [ForeignKey("DrugTestTypeCode")]
    [InverseProperty("TPersonDrugTests")]
    public virtual TDrugTestType DrugTestTypeCodeNavigation { get; set; } = null!;

    [ForeignKey("MedicalFacilityCode")]
    [InverseProperty("TPersonDrugTestMedicalFacilityCodeNavigations")]
    public virtual TMedicalFacility MedicalFacilityCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonDrugTestPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("RequestedByPersonGuid")]
    [InverseProperty("TPersonDrugTestRequestedByPeople")]
    public virtual TPerson? RequestedByPerson { get; set; }

    [ForeignKey("ScheduledMedicalFacilityCode")]
    [InverseProperty("TPersonDrugTestScheduledMedicalFacilityCodeNavigations")]
    public virtual TMedicalFacility ScheduledMedicalFacilityCodeNavigation { get; set; } = null!;
}
