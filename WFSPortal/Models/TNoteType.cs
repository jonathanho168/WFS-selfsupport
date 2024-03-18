using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Table("tNoteType")]
[Index("NoteTypeGuid", Name = "RG_tNoteType", IsUnique = true)]
public partial class TNoteType
{
    [Key]
    [StringLength(15)]
    public string NoteTypeCode { get; set; } = null!;

    [Column("NoteTypeGUID")]
    public Guid NoteTypeGuid { get; set; }

    public bool InactiveFlag { get; set; }

    public int RowVersion { get; set; }

    public string? NoteTypeDescription { get; set; }

    [InverseProperty("NoteTypeCodeNavigation")]
    public virtual ICollection<TPersonNote> TPersonNotes { get; set; } = new List<TPersonNote>();
}
