using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tCensusMetropolitanArea")]
[Index("CensusMetropolitanAreaGuid", Name = "RG_tCensusMetropolitanArea", IsUnique = true)]
public partial class TCensusMetropolitanArea
{
    [Key]
    [StringLength(15)]
    public string CensusMetropolitanAreaCode { get; set; } = null!;

    public string? CensusMetropolitanAreaDescription { get; set; }

    [Column("CensusMetropolitanAreaGUID")]
    public Guid CensusMetropolitanAreaGuid { get; set; }

    public int RowVersion { get; set; }

    public bool InactiveFlag { get; set; }

    [InverseProperty("CensusMetropolitanAreaCodeNavigation")]
    public virtual ICollection<TLocation> TLocations { get; set; } = new List<TLocation>();
}
