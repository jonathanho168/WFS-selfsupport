using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
[Table("dcFSWPHoursWeek")]
public partial class DcFswphoursWeek
{
    [Column("Last Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("First Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("SSN   National ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SsnNationalId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hours { get; set; }
}
