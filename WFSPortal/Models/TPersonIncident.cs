using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonIncident")]
[Index("PersonGuid", "IncidentGuid", Name = "AK_tPersonIncident")]
public partial class TPersonIncident
{
    [Key]
    [Column("PersonIncidentGUID")]
    public Guid PersonIncidentGuid { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [StringLength(30)]
    public string? CaseNumber { get; set; }

    [StringLength(15)]
    public string IllnessInjuryStatusCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IllnessInjuryDate { get; set; }

    [StringLength(15)]
    public string IllnessInjuryCode { get; set; } = null!;

    [StringLength(15)]
    public string OccupationalIllnessCategoryCode { get; set; } = null!;

    [StringLength(15)]
    public string WorkersCompensationCode { get; set; } = null!;

    [StringLength(15)]
    public string RegularJobCode { get; set; } = null!;

    [StringLength(15)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(15)]
    public string ShiftCode { get; set; } = null!;

    [Column("SupervisorPersonGUID")]
    public Guid? SupervisorPersonGuid { get; set; }

    public string? EquipmentInvolved { get; set; }

    public string? ActivityComments { get; set; }

    public string? ObjectOrSubstanceInvolved { get; set; }

    public string? IllnessInjuryComments { get; set; }

    public bool HospitalizedOvernightFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HospitalAdmittanceDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HospitalDischargeDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InitialDiagnosisDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextMedicalRecheckDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FullCapacityToWorkDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedToReturnWithRestrictionsDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeathDate { get; set; }

    public bool CompletedShiftFlag { get; set; }

    public bool PreExistingConditionFlag { get; set; }

    public bool TerminationFlag { get; set; }

    public bool? PermanentTransferFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FirstReportOfInjuryCompletedDate { get; set; }

    [Column("FirstReportCompletedByPersonGUID")]
    public Guid? FirstReportCompletedByPersonGuid { get; set; }

    [StringLength(15)]
    public string FirstReportCompletedByPersonJobCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ReportedToWorkDateTime { get; set; }

    public string? ActivityBeforeIncident { get; set; }

    public string? WhereEventOccurred { get; set; }

    public bool EmergencyRoomFlag { get; set; }

    public bool PrivacyCaseFlag { get; set; }

    public int RowVersion { get; set; }

    public Guid IncidentGuid { get; set; }

    public string? NoTreatment { get; set; }

    public string? PreventingReoccurance { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? NumberofDependents { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TDepartment DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("FirstReportCompletedByPersonGuid")]
    [InverseProperty("TPersonIncidentFirstReportCompletedByPeople")]
    public virtual TPerson? FirstReportCompletedByPerson { get; set; }

    [ForeignKey("FirstReportCompletedByPersonJobCode")]
    [InverseProperty("TPersonIncidentFirstReportCompletedByPersonJobCodeNavigations")]
    public virtual TJob FirstReportCompletedByPersonJobCodeNavigation { get; set; } = null!;

    [ForeignKey("IllnessInjuryCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TIllnessInjury IllnessInjuryCodeNavigation { get; set; } = null!;

    [ForeignKey("IllnessInjuryStatusCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TIllnessInjuryStatus IllnessInjuryStatusCodeNavigation { get; set; } = null!;

    [ForeignKey("IncidentGuid")]
    [InverseProperty("TPersonIncidents")]
    public virtual TIncident Incident { get; set; } = null!;

    [ForeignKey("OccupationalIllnessCategoryCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TOccupationalIllnessCategory OccupationalIllnessCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonIncidentPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("RegularJobCode")]
    [InverseProperty("TPersonIncidentRegularJobCodeNavigations")]
    public virtual TJob RegularJobCodeNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TShift ShiftCodeNavigation { get; set; } = null!;

    [ForeignKey("SupervisorPersonGuid")]
    [InverseProperty("TPersonIncidentSupervisorPeople")]
    public virtual TPerson? SupervisorPerson { get; set; }

    [InverseProperty("PersonIncident")]
    public virtual ICollection<TPersonIncidentBodyPart> TPersonIncidentBodyParts { get; set; } = new List<TPersonIncidentBodyPart>();

    [InverseProperty("PersonIncident")]
    public virtual ICollection<TPersonIncidentLostTimeHist> TPersonIncidentLostTimeHists { get; set; } = new List<TPersonIncidentLostTimeHist>();

    [InverseProperty("PersonIncident")]
    public virtual ICollection<TPersonIncidentRestrictedTimeHist> TPersonIncidentRestrictedTimeHists { get; set; } = new List<TPersonIncidentRestrictedTimeHist>();

    [InverseProperty("PersonIncident")]
    public virtual ICollection<TPersonIncidentTreatment> TPersonIncidentTreatments { get; set; } = new List<TPersonIncidentTreatment>();

    [ForeignKey("WorkersCompensationCode")]
    [InverseProperty("TPersonIncidents")]
    public virtual TWorkersCompensation WorkersCompensationCodeNavigation { get; set; } = null!;
}
