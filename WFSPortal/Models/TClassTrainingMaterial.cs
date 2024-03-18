using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tClassTrainingMaterial")]
public partial class TClassTrainingMaterial
{
    [StringLength(15)]
    public string TrainingMaterialCode { get; set; } = null!;

    [Column("ClassGUID")]
    public Guid ClassGuid { get; set; }

    [Key]
    [Column("ClassTrainingMaterialGUID")]
    public Guid ClassTrainingMaterialGuid { get; set; }

    public int RowVersion { get; set; }

    [ForeignKey("ClassGuid")]
    [InverseProperty("TClassTrainingMaterials")]
    public virtual TClass Class { get; set; } = null!;

    [ForeignKey("TrainingMaterialCode")]
    [InverseProperty("TClassTrainingMaterials")]
    public virtual TTrainingMaterial TrainingMaterialCodeNavigation { get; set; } = null!;
}
