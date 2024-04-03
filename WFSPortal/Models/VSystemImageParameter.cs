using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VSystemImageParameter
{
    [Column("SystemImageParametersGUID")]
    public Guid SystemImageParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? WelcomeImageName { get; set; }

    public string? WelcomeImageLink { get; set; }
}
