using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tPersonEmploymentDocument")]
public partial class TPersonEmploymentDocument
{
    [Key]
    public Guid PersonEmploymentDocumentGuid { get; set; }

    public Guid PersonGuid { get; set; }

    [StringLength(15)]
    public string EmploymentDocumentCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? NotifiedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FirstViewedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadAcknowledgedDate { get; set; }

    public Guid? SignedByPersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDate { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("EmploymentDocumentCode")]
    [InverseProperty("TPersonEmploymentDocuments")]
    public virtual TEmploymentDocument EmploymentDocumentCodeNavigation { get; set; } = null!;

    [ForeignKey("PersonGuid")]
    [InverseProperty("TPersonEmploymentDocumentPeople")]
    public virtual TPerson Person { get; set; } = null!;

    [ForeignKey("SignedByPersonGuid")]
    [InverseProperty("TPersonEmploymentDocumentSignedByPeople")]
    public virtual TPerson? SignedByPerson { get; set; }

    [InverseProperty("PersonEmploymentDocument")]
    public virtual ICollection<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; } = new List<UsysChecklistInstanceStep>();
}
