using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tTrainingMaterial")]
[Index("TrainingMaterialGuid", Name = "RG_tTrainingMaterial", IsUnique = true)]
public partial class TTrainingMaterial
{
    [Key]
    [StringLength(15)]
    public string TrainingMaterialCode { get; set; } = null!;

    public byte[]? Attachment { get; set; }

    public bool InactiveFlag { get; set; }

    [Column("TrainingMaterialGUID")]
    public Guid TrainingMaterialGuid { get; set; }

    public int RowVersion { get; set; }

    public string? TrainingMaterialDescription { get; set; }

    [InverseProperty("TrainingMaterialCodeNavigation")]
    public virtual ICollection<TClassTrainingMaterial> TClassTrainingMaterials { get; set; } = new List<TClassTrainingMaterial>();

    [InverseProperty("TrainingMaterialCodeNavigation")]
    public virtual ICollection<TCourseTrainingMaterial> TCourseTrainingMaterials { get; set; } = new List<TCourseTrainingMaterial>();
}
